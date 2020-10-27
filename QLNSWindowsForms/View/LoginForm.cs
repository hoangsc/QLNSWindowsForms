using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Net;
using QLNSWindowsForms.View;
using DevExpress.XtraBars.ToastNotifications;
using Tulpep.NotificationWindow;

namespace QLNSWindowsForms.View
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private Thread _thread;
        public LoginForm()
        {
            InitializeComponent();
            textBoxUsername.KeyDown += TextBoxUsername_KeyDown;
            textBoxPassword.KeyDown += TextBoxPassword_KeyDown;
            
            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Properties.Resources.hcc;
            popup.TitleText = "Lưu ý";
            popup.ShowCloseButton = true;
            popup.ShowOptionsButton = false;
            popup.ShowGrip = true;
            popup.Delay = 10000;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 3000;
            popup.Scroll = true;
            popup.Click += Popup_Click;
            popup.ContentText = $"Mật khẩu mặc định 'admin' 'admin' \nỨng dụng cần yêu cầu có mạng Internet \nHỗ trợ: Hoàng Chu" ;
            popup.Popup();
        }

        private void Popup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/hoangm4v");
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginView();
            }
        }

        private void TextBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginView();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginView();
        }

        private void buttonLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginView();
            }
        }
        private void LoginView() //dang dung
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            if (username == "" || password == "")
            {
                XtraMessageBox.Show("Tài khoản và mật khẩu không thể bỏ trống.");
            }
            else
            {
                
                if (username =="admin" && password == "admin")
                {
                    this.Close();
                    _thread = new Thread(openMain);
                    _thread.SetApartmentState(ApartmentState.STA);
                    _thread.Start();
                }
                else
                {
                    XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
        }
        private void LoginViewư()//huy
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            if (username == "" || password == "")
            {
                XtraMessageBox.Show("Tài khoản và mật khẩu không thể bỏ trống.");
            }
            else
            {
                Authorization.Auth auth = new Authorization.Auth(username, password);
                var token = auth.GetToken();
                if (token == "")
                    XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                else
                {

                    this.Close();
                    Authorization.SingletonToken _singletonToken = Authorization.SingletonToken.Instance(token);
                    _thread = new Thread(openMain);
                    _thread.SetApartmentState(ApartmentState.STA);
                    _thread.Start();

                }
            }
        }
        private void openMain()
        {
            Application.Run(new MainView());
        }
    }
}