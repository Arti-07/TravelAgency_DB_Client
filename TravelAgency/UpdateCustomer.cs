using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class UpdateCustomer : Form
    {
        private int customerID;
        private NpgsqlConnection connToTravel = null;

        public UpdateCustomer(int id)
        {
            customerID = id;
            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                $"SELECT customer_id, name, surname, patronymic, date_of_birth, phone_number FROM customer WHERE customer.customer_id = {customerID}", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                textBoxID.Text = ds.Tables[0].Rows[0]["customer_id"].ToString();
                textBoxName.Text = ds.Tables[0].Rows[0]["name"].ToString();
                textBoxSurname.Text = ds.Tables[0].Rows[0]["surname"].ToString();
                textBoxPatronymic.Text = ds.Tables[0].Rows[0]["patronymic"].ToString();
                dateTimePicker.Value = (DateTime)ds.Tables[0].Rows[0]["date_of_birth"];
                textBoxPhone.Text = ds.Tables[0].Rows[0]["phone_number"].ToString();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand($"UPDATE customer SET name = '{textBoxName.Text}', surname = '{textBoxSurname.Text}', patronymic = '{textBoxPatronymic.Text}', date_of_birth = '2002-02-25', phone_number = {textBoxPhone.Text} WHERE customer_id = {customerID}",
               connToTravel);
                MessageBox.Show(command.ExecuteNonQuery().ToString());
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
