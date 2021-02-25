using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personal_Accounting_System
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();

        }
       SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB1;Integrated Security=True");


        

        private void Profile_Load(object sender, EventArgs e)
           {
           // string query ="Selec"





            using (PASDB1Entities2 db = new PASDB1Entities2())
            {
                incomeChart.DataSource = db.tb_income.ToList();
                incomeChart.Series["Source"].XValueMember = "source_type";
                incomeChart.Series["Source"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                incomeChart.Series["Source"].YValueMembers = "amount";
                incomeChart.Series["Source"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                // Expense
                expenseChart.DataSource = db.tb_expense.ToList();
                expenseChart.Series["Expense"].XValueMember = "exp_type";
                expenseChart.Series["Expense"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                expenseChart.Series["Expense"].YValueMembers = "amount";
                expenseChart.Series["Expense"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;


            }
        }

        private void UploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void TotalBalanceTextBox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
