using System;
using System.Windows.Forms;
using Npgsql;
using System.Threading;

namespace TravelAgency
{
    public partial class MainForm : Form
    {
        private NpgsqlConnection connection = null;
        private NpgsqlConnection connToTravel = null;
        private Thread thread;
        

        public MainForm()
        {
            InitializeComponent();
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            /*
            connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                textBoxQuery.Text, connection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridViewSelect.DataSource = dataSet.Tables[0];

            connection.Dispose();
            connection.Close();
            */
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Authorize authorize = new Authorize();
            authorize.ShowDialog();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenUser);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenUser()
        {
            Application.Run(new User());
        }
    }
}
