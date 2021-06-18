using Project2_QuanLyDuAnGitHub.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project2_QuanLyDuAnGitHub.Controller.ControllerMain2
{
    class ControllerMain2
    {
        public object GetContext()
        {
            var user = Constants.User;
            return new ViewModelMain2(user.html_url, user.id, user.avatar, user.login, user.name, user.followers, user.following, user.public_repos, user.public_gists, user.star, user.created_at, user.updated_at, user.bio,
                user.company, user.location, user.blog, user.twitter_username, user.email);
        }


    }
}
