using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace VirusHelperLib
{
    public class VirusTotalService : IDisposable
    {
        private const string BaseUrl = "https://www.virustotal.com/vtapi/v2/";
        private readonly string _apiKey;
        private readonly HttpClient _client;

        public VirusTotalService()
        {
            _client = new HttpClient();
            _apiKey = ApiKeyManager.GetApiKey();
        }

        public async Task<JsonElement> GetFileReportAsync(string filePath)
        {
            string fileHash;
            try
            {
                var fileHashing = new FileHash();
                fileHash = fileHashing.CalculateSHA256(filePath);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException(ex.Message);
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            string url = $"{BaseUrl}file/report";
            var parameters = $"?apikey={_apiKey}&resource={fileHash}";

            try
            {
                HttpResponseMessage response = await _client.GetAsync(url + parameters).ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    HandleHttpError(response);
                }

                await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                return await JsonSerializer.DeserializeAsync<JsonElement>(responseStream).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<JsonElement> GetUrlScanReportAsync(string url)
        {
            string cleanUrl = Uri.EscapeUriString(url);
            string endpoint = $"url/report?apikey={_apiKey}&resource={cleanUrl}";

            try
            {
                HttpResponseMessage response = await _client.GetAsync(BaseUrl + endpoint).ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    HandleHttpError(response);
                }

                await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                return await JsonSerializer.DeserializeAsync<JsonElement>(responseStream).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void HandleHttpError(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException("Unauthorized access with API key");
            }
            else
            {
                throw new HttpRequestException($"HTTP request failed with status code {response.StatusCode}; The API key could be exhausted, check limits if you have the free version, if not, report this error.");
            }
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}

