using System;
using System.Collections.Generic;
using System.Text;

namespace Project2_QuanLyDuAnGitHub
{
    public class User
    {
        public string html_url { get; set; }
        public string login { get; set; }
        public string avatar { get; set; }
        public int id { get; set; }
        public int star { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string location { get; set; }
        public string blog { get; set; }
        public string email { get; set; }
        public string bio { get; set; }
        public string twitter_username { get; set; }
        public int public_repos { get; set; }
        public int public_gists { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

}
