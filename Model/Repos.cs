using System;
using System.Collections.Generic;
using System.Text;

namespace Project2_QuanLyDuAnGitHub.Model
{
    public class Repos
    {
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime pushed_at { get; set; }
        public int size { get; set; }
        public int stargazers_count { get; set; }
        public int watchers_count { get; set; }
        public string language { get; set; }
        public bool has_issues { get; set; }
        public bool has_projects { get; set; }
        public bool has_downloads { get; set; }
        public bool has_wiki { get; set; }
        public bool has_pages { get; set; }
        public int forks_count { get; set; }
        public int open_issues_count { get; set; }
        public int forks { get; set; }
        public int open_issues { get; set; }
        public int watchers { get; set; }
        public string default_branch { get; set; }
        public string temp_clone_token { get; set; }
        public int network_count { get; set; }
        public int subscribers_count { get; set; }
        public string mirror_url { get; set; }
        public bool archived { get; set; }
        public bool disabled { get; set; }
        public string license { get; set; }
    }
}
