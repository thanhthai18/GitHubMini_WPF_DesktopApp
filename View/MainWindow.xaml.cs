using Project2_QuanLyDuAnGitHub.View;
using Project2_QuanLyDuAnGitHub.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project2_QuanLyDuAnGitHub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller.ControllerMain controller;
        ViewModelMain viewModel;


        public MainWindow()
        {
            controller = new Controller.ControllerMain();
            viewModel = new ViewModelMain();
            InitializeComponent();
            this.DataContext = viewModel;
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(viewModel.UserName))
                return;
            if (controller.GetUser(viewModel.UserName))
            {
                Main2 main2 = new Main2();
                main2.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
