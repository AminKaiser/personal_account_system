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
    public partial class Expenses : Form
    {
        SqlDataAdapter sdp;
        SqlCommand smd;
        public Expenses()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB1;Integrated Security=True");
        private void Btn_Save_Click(object sender, EventArgs e)
        {
           //try
           // {
                // sqlcon.Open();
            string query = "INSERT INTO tb_expense (EXP_No,exp_type,amount,date)VALUES('" + textBoxSLNo.Text + "','" + comboBoxExpcSrc.Text + "','" + textBoxAmount.Text + "','" + dateTimePickerExpense.Value.Date + "')";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            sdp.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Insert SuccessFully!!");
          //  sqlcon.Close();
            //}catch(Exception) { }
        }
    

        private void Button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT EXP_No,exp_type,amount,date FROM tb_expense where EXP_No='" + textBoxSLNo.Text + "'";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sdp.Fill(dtbl);
            textBoxSLNo.Text = dtbl.Rows[0][0].ToString();
            comboBoxExpcSrc.SelectedItem = dtbl.Rows[0][1].ToString();
            textBoxAmount.Text = dtbl.Rows[0][2].ToString();
            dateTimePickerExpense.Text = dtbl.Rows[0][3].ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "UPDATE tb_expense SET EXP_No='" + textBoxSLNo.Text + "', exp_type='" + comboBoxExpcSrc.Text + "',amount='" + textBoxAmount.Text + "',date='" + dateTimePickerExpense.Value.Date + "'" +
            "Where EXP_No='" + textBoxSLNo.Text + "'";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            sdp.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();


            MessageBox.Show("Update SuccessFully!!");
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sdp = new SqlDataAdapter("Select isnull(max(cast(EXP_No as int)),0)+1 from tb_expense", sqlcon);
            DataTable dtbl = new DataTable();
            sdp.Fill(dtbl);
            textBoxSLNo.Text = dtbl.Rows[0][0].ToString();

            //// ComboBOX expense load

            comboBoxExpcSrc.Text = "--Select Type--";
            sqlcon.Open();
            smd = new SqlCommand("SELECT Exp_type FROM tb_AddExpense", sqlcon);
            try
            {
                SqlDataReader dr = smd.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxExpcSrc.Items.Add(dr["Exp_type"]);
                }

                dr.Close();
                dr.Dispose();
            }
            catch (Exception)
            {

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBoxSLNo.Text = "";
            comboBoxExpcSrc.Text = "";
            textBoxAmount.Text = "";
            dateTimePickerExpense.Text = null ;
            SqlDataAdapter sdp = new SqlDataAdapter("Select isnull(max(cast(EXP_No as int)),0)+1 from tb_expense", sqlcon);
            DataTable dtbl = new DataTable();
            sdp.Fill(dtbl);
            textBoxSLNo.Text = dtbl.Rows[0][0].ToString();

        }

        private void ComboBoxExpcSrc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
