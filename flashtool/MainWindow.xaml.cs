using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace flashtool
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        void LoginComplete(Object sender, UploadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if(e.Error.Message.Contains("401"))
                {
                    Result.Content = "用户名或密码错误";
                }
                else
                {
                    Result.Content = "无法连接到服务器";
                }
            }
            else
            {
                this.Hide();
                App.window1.Show();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.glassx.cn"); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            App.window1.Show();
            

            //Result.Content = "正在登陆";

            //App.usr = Usr.Text;
            //App.pwd = Pwd.Password;

            //WebClient webclient = new WebClient();
            //try
            //{
            //    webclient.Encoding = System.Text.Encoding.UTF8;
            //    webclient.Headers["Content-type"] = "application/x-www-form-urlencoded";
            //    webclient.Headers["Accept"] = "application/vnd.glassx.v1+json";
            //    webclient.UploadStringCompleted += LoginComplete;

            //    webclient.UploadStringAsync(new Uri("http://10.0.0.36:3000/user"), "email=" + Usr.Text + "&password=" + Pwd.Password);
            //}
            //catch
            //{
            //    Result.Content = "无法连接到服务器";
            //}
        }
		
    }
}
