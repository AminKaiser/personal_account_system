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
    public partial class reportExpense : Form
    {
        public reportExpense()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB1;Integrated Security=True");
        private void ButtonShow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tb_expense WHERE date  BETWEEN '" + dateTimePickerExpReport1.Value.ToString() + "' and '" + dateTimePickerExpReport2.Value.ToString()
              + "'";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sdp.Fill(dtb);
            dgvExp.DataSource = dtb;
        }

        private void reportExpense_Load(object sender, EventArgs e)
        {

        }
    }
}
