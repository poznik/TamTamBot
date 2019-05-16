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


        /// <summary>Get updates</summary>
        /// <param name="limit">Maximim number of updates to be retrieved.</param>
        /// <param name="timeout">Timeout in seconds for long polling.</param>
        /// <param name="marker">Identifier of first requested update. Pass `null` to get updates you didn't get yet.</param>
        /// <param name="types">Comma separated list of update types your bot want to receive.</param>
        /// <returns>List of updates</returns>
        /// <exception cref="BotApiException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<UpdateList> GetUpdatesAsync(int? limit, int? timeout, long? marker, System.Collections.Generic.IEnumerable<string> types, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/updates?").Append(_token).Append("&");
            if (limit != null)
            {
                urlBuilder_.Append("limit=").Append(System.Uri.EscapeDataString(ConvertToString(limit, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (timeout != null)
            {
                urlBuilder_.Append("timeout=").Append(System.Uri.EscapeDataString(ConvertToString(timeout, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (marker != null)
            {
                urlBuilder_.Append("marker=").Append(System.Uri.EscapeDataString(ConvertToString(marker, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (types != null)
            {
                foreach (var item_ in types) { urlBuilder_.Append("types=").Append(System.Uri.EscapeDataString(ConvertToString(item_, System.Globalization.CultureInfo.InvariantCulture))).Append("&"); }
            }
            urlBuilder_.Length--;
            using (var request_ = new System.Net.Http.HttpRequestMessage())
            {
                request_.Method = new System.Net.Http.HttpMethod("GET");
                request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
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
                        var result_ = default(UpdateList);
                        try
                        {
                            result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateList>(responseData_, _settings.Value);
                            return result_;
                        }
                        catch (System.Exception exception_)
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
                        catch (System.Exception exception_)
                        {
                            throw new BotApiException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                        }
                        throw new BotApiException<Error>("Authorization Error. No `access_token` provided or token is invalid", (int)response_.StatusCode, responseData_, headers_, result_, null);
                    }
                    else
                    if (status_ == "405")
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var result_ = default(Error);
                        try
                        {
                            result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(responseData_, _settings.Value);
                        }
                        catch (System.Exception exception_)
                        {
                            throw new BotApiException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                        }
                        throw new BotApiException<Error>("Method not allowed", (int)response_.StatusCode, responseData_, headers_, result_, null);
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
                        catch (System.Exception exception_)
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

        public static string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is System.Enum)
            {
                string name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            return System.Convert.ToString(value, cultureInfo);
        }
    }
}
