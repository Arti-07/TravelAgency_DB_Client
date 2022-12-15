using Npgsql;
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
    public partial class User : Form
    {
        private NpgsqlConnection connToTravel = null;
        private Thread thread;

        public User()
        {
            InitializeComponent();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenMainMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMainMenu()
        {
            Application.Run(new MainForm());
        }
    }
}
