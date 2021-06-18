using Project2_QuanLyDuAnGitHub.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2_QuanLyDuAnGitHub.Controller
{
    public class ControllerMain
    {
        public bool GetUser(string userName)
        {
            TimNguoiDung timNguoiDung = new TimNguoiDung();

            var user = timNguoiDung.GetUserByName(userName);

            Constants.User = user;

            return user != null;


        }
    }
}
