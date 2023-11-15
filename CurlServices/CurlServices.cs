using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CurlServices
{
    public class CurlServicesReq : ICurlServices
    {
        public async Task<string> Login2()
        {

            string apiUrl = "https://businessyds.csb.gov.tr/api/auth/login";
            string jsonPayload = "{\"departmentId\":null,\"userName\":\"1020393284\",\"password\":\"Prizma2020\"}";

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
                request.Headers.Add("Accept", "application/json, text/plain, */*");
                request.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
                request.Headers.Add("Origin", "https://yds.csb.gov.tr");
                request.Headers.Add("Referer", "https://yds.csb.gov.tr");
                request.Headers.Add("Sec-Fetch-Dest", "empty");
                request.Headers.Add("Sec-Fetch-Mode", "cors");
                request.Headers.Add("Sec-Fetch-Site", "same-site");
                request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36");
                request.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"118\", \"Google Chrome\";v=\"118\", \"Not=A?Brand\";v=\"99\"");
                request.Headers.Add("sec-ch-ua-mobile", "?0");
                request.Headers.Add("sec-ch-ua-platform", "Windows");

                request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");


                try
                {
                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(content);
                        return content;
                    }
                    else
                    {
                        Console.WriteLine($"Hata kodu: {response.StatusCode}");
                        return "hata";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                    return null;
                }
            }
        }

    }
}

