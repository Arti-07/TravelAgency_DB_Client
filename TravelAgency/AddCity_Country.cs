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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgency
{
    public partial class AddCity_Country : Form
    {
        private NpgsqlConnection connToTravel = null;


        public AddCity_Country()
        {
            InitializeComponent();
            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
        }

        private void btnShowCountry_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT * FROM public.country ORDER BY country_id ASC ", connToTravel);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnShowCity_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT * FROM public.cities ORDER BY city_id ASC ", connToTravel);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddCounty_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO country (country_id, name) VALUES (@country_id, @name)",
                connToTravel);
                command.Parameters.AddWithValue("country_id", int.Parse(textBoxCountry_id.Text));
                command.Parameters.AddWithValue("name", textBoxCountry_name.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString());
                textBoxCountry_id.Text = String.Empty;
                textBoxCountry_name.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO cities (city_id,name,country_id) VALUES (@city_id, @name, @country_id)",
                connToTravel);
                command.Parameters.AddWithValue("city_id", int.Parse(textBoxCity_id.Text));
                command.Parameters.AddWithValue("name", textBoxCity_name.Text);
                command.Parameters.AddWithValue("country_id", int.Parse(textBoxCity_Coutry_id.Text));
                MessageBox.Show(command.ExecuteNonQuery().ToString());
                textBoxCity_id.Text = String.Empty;
                textBoxCity_name.Text = String.Empty;
                textBoxCity_Coutry_id.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
