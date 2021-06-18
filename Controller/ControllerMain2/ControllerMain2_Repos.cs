using Project2_QuanLyDuAnGitHub.API;
using Project2_QuanLyDuAnGitHub.View.ViewModel.VIewModelMain2;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;

namespace Project2_QuanLyDuAnGitHub.Controller.ControllerMain2
{
    public class ControllerMain2_Repos
    {
        public object GetContext()
        {
            var repos = Constants.Repos;
            if (repos != null)
            {
                return new ViewModelMain2_Repos(repos.name, repos.created_at, repos.updated_at, repos.pushed_at,
                    repos.size, repos.stargazers_count, repos.watchers_count, repos.language, repos.has_issues,
                    repos.has_projects, repos.has_downloads, repos.has_wiki, repos.has_pages, repos.forks_count,
                    repos.open_issues_count, repos.forks, repos.open_issues, repos.watchers, repos.default_branch,
                    repos.temp_clone_token, repos.network_count, repos.subscribers_count, repos.mirror_url,
                    repos.archived, repos.disabled, repos.license);
            }
            else
            {
                MessageBox.Show("Not Found");
                return new ViewModelMain2_Repos();
            }


        }
    }
}
