using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personal_Accounting_System
{
    public partial class IncomeReport : Form
    {
        public IncomeReport()
        {
            InitializeComponent();
        }


        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB1;Integrated Security=True");
        private void Label1_Click(object sender, EventArgs e)
        {
           

        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tb_income WHERE date  BETWEEN '" + dateTimePickerIncomeReport1.Value.ToString() + "' and '" + dateTimePickerIncomeReport2.Value.ToString()
                + "'";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sdp.Fill(dtb);
            dgvIncome.DataSource = dtb;


        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            IncomeGateWay obj = incomeBindingSource.Current as IncomeGateWay;
            if(obj!=null)
            {
                string query = "SELECT * FROM tb_income WHERE date  BETWEEN '" + dateTimePickerIncomeReport1.Value.ToString() + "' and '" + dateTimePickerIncomeReport2.Value.ToString()
                + "'";
                SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
                DataTable dtb = new DataTable();
                sdp.Fill(dtb);
                dgvIncome.DataSource = dtb;
            }
        }

        private void DgvIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IncomeReport_Load(object sender, EventArgs e)
        {

        }
    }
}
