using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class Form1 : Form
    {
        DataBaseConnector connector = new DataBaseConnector();
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            connector.OpenConnection();
            string query = $"select * from Users where Login = '{LoginTextBox.Text}' and Pass = '{PassTextBox.Text}'";
            SqlCommand sqlCommand = new SqlCommand(query, connector.Connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            int role = 0;
            string name = "";
            while (reader.Read()) 
            {
                role = reader.GetInt32(1);
                name = reader.GetString(2);
            }
            if(role != 0) {
                MessageBox.Show($"Добро пожаловать {name}!");
                OrdersForm ordersForm = new OrdersForm(role, name);
                this.Hide();
                ordersForm.Show();
            }
            else
            {
                MessageBox.Show($"Неправильный логин или пароль");
            }
            connector.CloseConnection();
        }
    }
}
