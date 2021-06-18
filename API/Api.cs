using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Project2_QuanLyDuAnGitHub.API
{
    public class Api
    {
        public HttpResponseMessage GET(string URL)
        {

            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                    client.DefaultRequestHeaders.Add("User-Agent", "MyConsoleApp");
                    string basicValue = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{"your_username_on_github"}:{"your_token_on_github"}"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", basicValue);
                    var result = client.GetAsync(URL);
                    result.Wait();
                    return result.Result;

                }
            }
        }
    }
}
