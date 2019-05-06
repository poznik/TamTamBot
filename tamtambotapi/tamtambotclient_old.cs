using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Threading;


namespace tamtambotapi
{
    public class TamTamBotClient
    {
        private string _apiKey = "";
        private WebClient _webc;
        private string _baseUrl = "https://botapi.tamtam.chat";

        public event EventHandler<string> OnError;

        public TamTamBotClient(string TamTamBotApiKey)
        {
            _apiKey = TamTamBotApiKey;
            _webc = new WebClient();
        }


        /// <summary>
        /// Gets base info about TamTam bot.
        /// </summary>
        /// <returns>USER instance of bot</returns>
        public User GetMe()
        {
            string url = $"{_baseUrl}/me?access_token={_apiKey}";
            try
            {
                Stream data = _webc.OpenRead(url);
                StreamReader reader = new StreamReader(data);
                string response = reader.ReadToEnd();
                data.Close();
                reader.Close();
                User user = JsonConvert.DeserializeObject<User>(response);
                return user;
            }
            catch (Exception ex)
            {
                OnError?.Invoke(this, ex.Message);
                return null;
            }
        }

        public void Start()
        {
            string url = $"{_baseUrl}/updates?access_token={_apiKey}";

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                while (true)
                {
                    try
                    {
                        Stream data = _webc.OpenRead(url);
                        StreamReader reader = new StreamReader(data);
                        string response = reader.ReadToEnd();
                        data.Close();
                        reader.Close();


                    }
                    catch (Exception ex)
                    {
                        OnError?.Invoke(this, ex.Message);
                    }
                }
            }).Start();
        }
    }
}
