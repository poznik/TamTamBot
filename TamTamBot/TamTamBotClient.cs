using System;
using System.Net.Http;
using TamTamBot.Model;

namespace TamTamBot
{
    public partial class TamTamBotClient
    {
        private string _token = "";
        private string BaseUrl = "https://botapi.tamtam.chat";
        private HttpClient client_;
        private Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

        public TamTamBotClient(string token)
        {
            _token = $"access_token={ token}";
            client_ = new HttpClient();
            _settings = new Lazy<Newtonsoft.Json.JsonSerializerSettings>(() =>
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });

        }

        /// <summary>Get current bot info</summary>
        /// <returns>Expected response to a valid request</returns>
        /// <exception cref="BotApiException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<UserWithPhoto> GetMyInfoAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/me").Append("?").Append(_token);
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = ((int)response_.StatusCode).ToString();
                    if (status_ == "200")
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var result_ = default(UserWithPhoto);
                        try
                        {
                            result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<UserWithPhoto>(responseData_, _settings.Value);
                            return result_;
                        }
                        catch (Exception exception_)
                        {
                            throw new BotApiException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                        }
                    }
                    else
                    if (status_ == "401")
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var result_ = default(Error);
                        try
                        {
                            result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(responseData_, _settings.Value);
                        }
                        catch (Exception exception_)
                        {
                            throw new BotApiException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                        }
                        throw new BotApiException<Error>("Authorization Error. No `access_token` provided or token is invalid", (int)response_.StatusCode, responseData_, headers_, result_, null);
                    }
                    else
                    if (status_ == "500")
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var result_ = default(Error);
                        try
                        {
                            result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(responseData_, _settings.Value);
                        }
                        catch (Exception exception_)
                        {
                            throw new BotApiException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                        }
                        throw new BotApiException<Error>("Internal Server Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                    }
                    else
                    if (status_ != "200" && status_ != "204")
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new BotApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                    }

                    return default;
                }
                finally
                {
                    if (response_ != null)
                        response_.Dispose();
                }
            }
        }
    }
}
