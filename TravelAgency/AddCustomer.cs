using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddCustomer : Form
    {
        private NpgsqlConnection connToTravel = null;

        public AddCustomer()
        {
            InitializeComponent();
            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connToTravel;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT customer_id AS Номер, name AS Имя, surname AS Фамилия, patronymic AS Отчество, date_of_birth AS Дата_рождения, phone_number AS Телефон FROM customer ORDER BY customer_id ASC ";
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView.DataSource = dt;
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO customer(customer_id,name,surname,patronymic,date_of_birth,phone_number) VALUES (@customer_id,@name,@surname,@patronymic,@date_of_birth,@phone_number)",
               connToTravel);
                command.Parameters.AddWithValue("customer_id", int.Parse(textBoxID.Text));
                command.Parameters.AddWithValue("name", textBoxName.Text);
                command.Parameters.AddWithValue("surname", textBoxSurname.Text);
                command.Parameters.AddWithValue("patronymic", textBoxPatronymic.Text);
                command.Parameters.AddWithValue("date_of_birth", dateTimePicker.Value);
                command.Parameters.AddWithValue("phone_number", textBoxPhone.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString());
                textBoxID.Text = String.Empty;
                textBoxName.Text = String.Empty;
                textBoxSurname.Text = String.Empty;
                textBoxPatronymic.Text = String.Empty;
                textBoxPhone.Text = String.Empty;
                dateTimePicker.Value = DateTime.Now;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
