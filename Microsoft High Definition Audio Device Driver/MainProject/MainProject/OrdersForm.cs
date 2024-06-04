using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class OrdersForm : Form
    {
        DataBaseConnector connector = new DataBaseConnector();

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private bool isCanDelete;
        private string condition;
        public OrdersForm(int roleID, string name)
        {
            InitializeComponent();
            switch (roleID)
            {
                case 1:
                    isCanDelete = true;
                    break;
                case 2:
                    CompleteButton.Enabled = false;
                    break;
                case 3:
                    condition = $"where FullName = {name}";
                    break;
            }
            RefreshTable();
        }
        private void RefreshTable()
        {
            string query = $"select * from Orders {condition}";
            SqlCommand command = new SqlCommand(query, connector.Connection);
            adapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            OrdersDataGridView.DataSource = dataTable;
            OrdersDataGridView.Columns[0].Visible = false;

            OrdersDataGridView.Columns[4].ReadOnly = true;
            OrdersDataGridView.Columns[5].ReadOnly = true;
            OrdersDataGridView.Columns[6].ReadOnly = true;
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            adapter.Update(dataTable);
            MessageBox.Show("Изменения сохранены");
        }

        private void UnsaveButton_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0;OrdersDataGridView.Rows.Count > i; i++)
            {
                for (int j = 0; OrdersDataGridView.Rows[i].Cells.Count > j; j++)
                {
                    if (OrdersDataGridView.Rows[i].Cells[j].Value!=null&&OrdersDataGridView.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text))
                    {
                        OrdersDataGridView.Rows[i].Cells[j].Selected = true;
                    }
                    else
                    {
                        OrdersDataGridView.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow.Cells[6].Value.ToString().Trim() == "Новый")
            {
                OrdersDataGridView.CurrentRow.Cells[6].Value = "Завершен";
                OrdersDataGridView.CurrentRow.Cells[5].Value = DateTime.Now;
                OrdersDataGridView.CurrentRow.Selected = true;
                DataRowView row =(DataRowView)OrdersDataGridView.CurrentRow.DataBoundItem;
                row.Row.EndEdit();
                adapter.Update(dataTable);
                MessageBox.Show("Заказ успешно завершён!");
            }
            else
            {
                MessageBox.Show("Заказ уже завершён!");
            }
        }

        private void OrdersDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[5].Value = DateTime.Now;
        }

        private void ChangeServices_Click(object sender, EventArgs e)
        {
            ServicesForm form = new ServicesForm((int)OrdersDataGridView.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void OrdersDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = !isCanDelete;
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
