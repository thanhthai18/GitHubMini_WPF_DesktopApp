using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Project2_QuanLyDuAnGitHub.View.ViewModel.VIewModelMain2
{
    public class ViewModelMain2_Repos
    {
        public static string name_repos { get; set; }
        public DateTime created_at_repos { get; set; }
        public DateTime updated_at_repos { get; set; }
        public DateTime pushed_at_repos { get; set; }
        public int size_repos { get; set; }
        public int stargazers_count_repos { get; set; }
        public int watchers_count_repos { get; set; }
        public string language_repos { get; set; }
        public bool has_issues_repos { get; set; }
        public bool has_projects_repos { get; set; }
        public bool has_downloads_repos { get; set; }
        public bool has_wiki_repos { get; set; }
        public bool has_pages_repos { get; set; }
        public int forks_count_repos { get; set; }
        public int open_issues_count_repos { get; set; }
        public int forks_repos { get; set; }
        public int open_issues_repos { get; set; }
        public int watchers_repos { get; set; }
        public string default_branch_repos { get; set; }
        public object temp_clone_token_repos { get; set; }
        public int network_count_repos { get; set; }
        public int subscribers_count_repos { get; set; }
        public string mirror_url_repos { get; set; }
        public bool archived_repos { get; set; }
        public bool disabled_repos { get; set; }
        public string license_repos { get; set; }

        public ViewModelMain2_Repos(string name, DateTime created_at, DateTime updated_at, DateTime pushed_at, int size, int stargazers_count, int watchers_count, string language, bool has_issues, bool has_projects, bool has_downloads, bool has_wiki, bool has_pages, int forks_count, int open_issues_count, int forks, int open_issues, int watchers, string default_branch, object temp_clone_token, int network_count, int subscribers_count, string mirror_url, bool archived, bool disabled, string license)
        {
            name_repos = name;
            this.created_at_repos = created_at;
            this.updated_at_repos = updated_at;
            this.pushed_at_repos = pushed_at;
            this.size_repos = size;
            this.stargazers_count_repos = stargazers_count;
            this.watchers_count_repos = watchers_count;
            this.language_repos = language;
            this.has_issues_repos = has_issues;
            this.has_projects_repos = has_projects;
            this.has_downloads_repos = has_downloads;
            this.has_wiki_repos = has_wiki;
            this.has_pages_repos = has_pages;
            this.forks_count_repos = forks_count;
            this.open_issues_count_repos = open_issues_count;
            this.forks_repos = forks;
            this.open_issues_repos = open_issues;
            this.watchers_repos = watchers;
            this.default_branch_repos = default_branch;
            this.temp_clone_token_repos = temp_clone_token;
            this.network_count_repos = network_count;
            this.subscribers_count_repos = subscribers_count;
            this.mirror_url_repos = mirror_url;
            this.archived_repos = archived;
            this.disabled_repos = disabled;
            this.license_repos = license;
        }

        public ViewModelMain2_Repos()
        {
        }
    }
}
