using Newtonsoft.Json;
using Project2_QuanLyDuAnGitHub.Model;
using Project2_QuanLyDuAnGitHub.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Project2_QuanLyDuAnGitHub.API
{
    class TimRepos : Api
    {
        public Repos GetReposByName(string ReposName)
        {
            HttpResponseMessage response = GET("https://api.github.com/repos/" + ViewModelMain2.login + "/" + ReposName);
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Repos>(content);
            }
            else
            {
                return null;
            }

        }
    }
}
