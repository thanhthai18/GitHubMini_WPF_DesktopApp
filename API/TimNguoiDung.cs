using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Project2_QuanLyDuAnGitHub.API
{
    public class TimNguoiDung : Api
    {
        public User GetUserByName(string UserName)
        {
            HttpResponseMessage response = GET("https://api.github.com/users/" + UserName);
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<User>(content);
            }
            else
            {
                return null;
            }

        }
    }
}
