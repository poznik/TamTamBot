using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using TamTamBot;

namespace TamTamBotTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var instance = new Bot();
            instance.StartBot(); //Can call non static method
        }
    }

    public class Bot
    {
        public TamTamBotClient cli;
        public void StartBot()
        {
            string token = File.ReadAllText("token.config");

            try
            {
                cli = new TamTamBotClient(new System.Net.Http.HttpClient(), token);
                var r = cli.GetMyInfoAsync().Result;
                cli.OnMessageUpdate += Cli_OnMessageUpdate;
                cli.OnUpdate += Cli_OnUpdate;

                Console.WriteLine($"Hello from {r.Username}. Ready for updates. For terminate, press Enter");

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    while (1 == 1)
                    {
                        var upd = cli.GetUpdatesAsync(null, null, null, null, cancellationToken: CancellationToken.None).Result;
                    }

                }).Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fatal bot error> Bye-Bye. {ex.Message}");
            }

            Console.ReadLine();
        }

        private void Cli_OnMessageUpdate(object sender, MessageCreatedUpdate e)
        {
            Message message = e.Message;
            Console.WriteLine($"Received message. {message.Body.Text}");


            CallbackButton button = new CallbackButton();
            button.Payload = "/call";
            button.Text = "Кнопка";
            button.Intent = Intent.Positive;

            Collection<Button> col = new Collection<Button>();
            col.Add(button);

            Payload9 keyb = new Payload9();
            keyb.Buttons.Add(col);

            InlineKeyboardAttachmentRequest kb = new InlineKeyboardAttachmentRequest();
            kb.Payload = keyb;

            NewMessageBody b = new NewMessageBody();
            b.Text = $"Echo: {message.Body.Text}";
            b.Attachments = new Collection<AttachmentRequest>();

            b.Attachments.Add(kb);


            var r = cli.SendMessageAsync(b, message.Recipient.User_id, message.Recipient.Chat_id).Result;
        }

        private  void Cli_OnUpdate(object sender, Update e)
        {
            Console.WriteLine($"Received update. Type: {e.GetType()}");
        }
    }

}
