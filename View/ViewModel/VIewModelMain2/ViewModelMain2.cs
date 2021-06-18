using System;
using System.Collections.Generic;
using System.Text;

namespace Project2_QuanLyDuAnGitHub.View.ViewModel
{
    public class ViewModelMain2
    {
        public static string html_url { get; set; }
        public static string login { get; set; }
        public string avatar { get; set; }
        public int id { get; set; }
        public int star { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string location { get; set; }
        public string blog { get; set; }
        public object email { get; set; }
        public string bio { get; set; }
        public string twitter_username { get; set; }
        public int public_repos { get; set; }
        public int public_gists { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public ViewModelMain2(string _html_url, int id, string avatar, string userName, string name, int followers, int following, int repos, int project, int star, DateTime createdAt, DateTime updatedAt, string bio, string company, string location, string website, string twitter, string email)
        {
            html_url = _html_url;
            this.id = id;
            this.avatar = "https://avatars.githubusercontent.com/u/" + id + "?v=4" + ".png";
            login = userName;
            this.name = name;
            this.followers = followers;
            this.following = following;
            this.public_repos = repos;
            this.public_gists = project;
            this.star = star;
            this.created_at = createdAt;
            this.updated_at = updatedAt;
            this.bio = bio;
            this.company = company;
            this.location = location;
            this.blog = website;
            this.twitter_username = twitter;
            this.email = email;
        }

    }
}
