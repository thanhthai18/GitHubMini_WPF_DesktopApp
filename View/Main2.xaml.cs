using Project2_QuanLyDuAnGitHub.Controller;
using Project2_QuanLyDuAnGitHub.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using Project2_QuanLyDuAnGitHub.Controller.ControllerMain2;
using Project2_QuanLyDuAnGitHub.View.ViewModel.VIewModelMain2;
using Project2_QuanLyDuAnGitHub.API;

namespace Project2_QuanLyDuAnGitHub
{
    public partial class Main2 : Window
    {
        ControllerMain2 controller;
        ControllerMain2_Repos controllerRepos;

        public Main2()
        {
            controller = new ControllerMain2();
            controllerRepos = new ControllerMain2_Repos();
            InitializeComponent();
            this.DataContext = controller.GetContext();
        }

        private void ButtonPopUp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Content.Visibility = Visibility.Visible;
            Repository.Visibility = Visibility.Collapsed;
            GitURL.Visibility = Visibility.Collapsed;
            this.DataContext = controller.GetContext();
        }

        private void ItemRepos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Content.Visibility = Visibility.Collapsed;
            Repository.Visibility = Visibility.Visible;
            GitURL.Visibility = Visibility.Collapsed;
            this.DataContext = controller.GetContext();
        }

        private void ItemProject_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ItemGitURL_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Content.Visibility = Visibility.Collapsed;
            Repository.Visibility = Visibility.Collapsed;
            GitURL.Visibility = Visibility.Visible;
            this.DataContext = controller.GetContext();
        }

        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            MainWindow main2 = new MainWindow();
            main2.Show();
            this.Close();
        }

        private void OpenGit_Click(object sender, RoutedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = ViewModelMain2.html_url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void GhiChu_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void btnTimRepos_Click(object sender, RoutedEventArgs e)
        {
            TimRepos timRepos = new TimRepos();
            InitializeComponent();
            Constants.Repos = timRepos.GetReposByName(txtRepos.Text.ToString());
            this.DataContext = controllerRepos.GetContext();

        }

        private void watch_code_Click(object sender, RoutedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://github.com/" + ViewModelMain2.login + "/" + ViewModelMain2_Repos.name_repos + "/find/master",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void show_commits_Click(object sender, RoutedEventArgs e)
        {

            var psi = new ProcessStartInfo
            {
                FileName = "https://github.com/" + ViewModelMain2.login + "/" + ViewModelMain2_Repos.name_repos + "/commits/master",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void clone_zip_Click(object sender, RoutedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://github.com/" + ViewModelMain2.login + "/" + ViewModelMain2_Repos.name_repos + "/archive/refs/heads/master.zip",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
