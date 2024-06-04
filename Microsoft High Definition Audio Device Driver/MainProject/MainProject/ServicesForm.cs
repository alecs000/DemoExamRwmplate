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
    public partial class ServicesForm : Form
    {
        DataBaseConnector connector = new DataBaseConnector();
        DataTable allServicesDataTable;
        DataTable selectedServicesDataTable;
        int orderId;
        public ServicesForm(int orderId)
        {
            InitializeComponent();
            selectedServicesDataTable = RefreshServiceText(orderId);
            ServicesDataGridView.DataSource = selectedServicesDataTable;
            ServicesDataGridView.Columns[1].Width = 400;
            RefreshServiceComboBox();
            this.orderId = orderId;
        }

       
    private DataTable RefreshServiceText(int orderId)
    {
        connector.OpenConnection();
        string query = $"select s.ID, s.Name from OrdersAndServices os join [Services] s on s.ID = os.ServiceID join [Orders] o on o.ID = os.OrdersID where o.ID = {orderId}";
        SqlCommand sqlCommand = new SqlCommand(query, connector.Connection);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        DataTable dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
        connector.CloseConnection();
        return dataTable;
    }
    private void RefreshServiceComboBox()
    {
        connector.OpenConnection();
        string query = $"select * from Services";
        SqlCommand sqlCommand = new SqlCommand(query, connector.Connection);
        SqlDataReader dataReader = sqlCommand.ExecuteReader();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        allServicesDataTable = new DataTable();
        while (dataReader.Read())
        {
            ServicesComboBox.Items.Add(dataReader.GetString(1));
        }
        dataReader.Close();
        sqlDataAdapter.Fill(allServicesDataTable);
        connector.CloseConnection();
    }
    private void SaveButton_Click(object sender, EventArgs e)
    {
        DataTable oldTable = RefreshServiceText(orderId);
        for (int i = 0; i < selectedServicesDataTable.Rows.Count; i++)
        {
            bool isExist = false;
            for (int j = 0; j < oldTable.Rows.Count; j++)
            {

                if (oldTable.Rows[j][0].ToString() == selectedServicesDataTable.Rows[i][0].ToString())
                {
                    isExist = true;
                }
            }
            if (!isExist)
            {
                connector.OpenConnection();
                string query = $"insert into OrdersAndServices values('{orderId}','{selectedServicesDataTable.Rows[i][0]}')";
                SqlCommand sqlCommand = new SqlCommand(query, connector.Connection);
                sqlCommand.ExecuteNonQuery();
                connector.CloseConnection();
            }
        }
    }
    private void AddButton_Click(object sender, EventArgs e)
    {
        bool isExist = false;
        string selectedItem = allServicesDataTable.Rows[ServicesComboBox.SelectedIndex][0].ToString();
        for (int i = 0; i < ServicesDataGridView.Rows.Count; i++)
        {
            if (ServicesDataGridView.Rows[i].Cells[0].Value!=null&&ServicesDataGridView.Rows[i].Cells[0].Value.ToString() == selectedItem)
            {
                isExist = true;
            }
        }
        if (!isExist)
            selectedServicesDataTable.Rows.Add(allServicesDataTable.Rows[ServicesComboBox.SelectedIndex][0], allServicesDataTable.Rows[ServicesComboBox.SelectedIndex][1]);
    }
}
}
