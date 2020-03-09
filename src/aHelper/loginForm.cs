using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace aHelper
{
    public partial class FormLogin : Form
    {
        const int Indent = 7;
        public string StartText = "аХелпер: Введите пароль для запуска";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ReSize()
        {
            infoBox.Height = infoBox.Lines.Length * Font.Height + 6;
            password.Location = new Point(password.Location.X, infoBox.Location.Y + (infoBox.Lines.Length * Font.Height) + 6 + Indent);
            loginButton.Location = new Point(loginButton.Location.X, password.Location.Y + password.Height + Indent);
            vkButton.Location = new Point(vkButton.Location.X, loginButton.Location.Y);
            Height = loginButton.Location.Y + loginButton.Height * 2 + Indent + 5;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            password.Text = (string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\www.gtasrv.ru\\CR-MP\\GenerationC", "PersPass", null);
            if (password.Text == null) { MessageBox.Show("Привет!\nЭтот софт сохраняет и передает некоторую информацию о Вашем ПК на сервера разработчика.\nНичего ужасного, никаких паролей и личных данных.\nЕсли Вы с этим согласны - просто продолжайте использование.\n\nvk.com/idDrygok", "aHelper"); }
            // Пароль еще не был указан, => это первый запуск. Оповестим пользователя о сохранении некоторой информации

            // Ранее тут было изменение StartText, получаемого с моего сервера, но оно вырезано вместе с проверкой лицензии
            infoBox.Text = StartText;
            ReSize();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\www.gtasrv.ru\\CR-MP\\GenerationC", "PersPass", password.Text);

            Form f = new aPanel();
            f.Show(); Hide();
        }

        private string GET(string URL)
        {
            try
            {
                var webClient = new WebClient();
                webClient.Headers.Add("user-agent", "Mozilla/5.0 (vk.com/idDrygok)");
                return webClient.DownloadString(URL);
            }
            catch { return ""; }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void vkButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/iddrygok");
        }

    }
}
