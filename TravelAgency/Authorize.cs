using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Authorize : Form
    {
        private string password;
        private Thread thread;
        public Authorize()
        {
            InitializeComponent();
            password = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == password)
            {
                MessageBox.Show("Успешная авторизация!", "Message");
                this.Close();
                thread = new Thread(OpenAdmin);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Упс ! Неверный пароль", "Message");
            }
        }
        private void OpenAdmin()
        {
            Application.Run(new ViewData());
        }
    }
}
