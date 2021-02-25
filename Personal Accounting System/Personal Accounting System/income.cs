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
    public partial class income : Form
    {

       
        SqlDataAdapter sdp;
        SqlCommand smd;
        public income()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB1;Integrated Security=True");

        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                //sqlcon.Open();
                string query = "INSERT INTO tb_income (SL_No,source_type,amount,date,total)VALUES('" + textBoxSLNo.Text + "','" + comboBoxIncSrc.Text + "','" + textBoxAmount.Text + "','" + dateTimePickerIncome.Value.Date + "','" + textBoxTotal.Text + "')";
                SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
                sdp.SelectCommand.ExecuteNonQuery();
               // sqlcon.Close();


                MessageBox.Show("Insert SuccessFully!!");
            }catch(Exception) { }
            //SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            //DataTable dtbl = new DataTable();
            //sdp.Fill(dtbl);
            //if(dtbl.Rows.Count==1)
            //{

            //}
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "UPDATE tb_income SET SL_No='" + textBoxSLNo.Text + "', source_type='" + comboBoxIncSrc.Text + "',amount='" + textBoxAmount.Text + "',date='"+dateTimePickerIncome.Value.Date+"'" +
                "Where SL_No='" + textBoxSLNo.Text + "'";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            sdp.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();


            MessageBox.Show("Update SuccessFully!!");
        }

        private void Income_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sdp = new SqlDataAdapter("Select isnull(max(cast(SL_No as int)),0)+1 from tb_income",sqlcon);
            DataTable dtbl = new DataTable();
            sdp.Fill(dtbl);
            textBoxSLNo.Text = dtbl.Rows[0][0].ToString();


            //// ComboBOX income load

            comboBoxIncSrc.Text="--Select Type--";
            sqlcon.Open();
            smd = new SqlCommand("SELECT Source_Name from tb_AddSource",sqlcon);
            try{
                SqlDataReader dr = smd.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxIncSrc.Items.Add(dr["Source_Name"]);
                }

                dr.Close();
                dr.Dispose();
            }
            catch (Exception ){}

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT SL_No,source_type,amount,date FROM tb_income where SL_No='"+textBoxSLNo.Text+"'";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sdp.Fill(dtbl);
            textBoxSLNo.Text = dtbl.Rows[0][0].ToString();
            comboBoxIncSrc.SelectedItem = dtbl.Rows[0][1].ToString();
            textBoxAmount.Text = dtbl.Rows[0][2].ToString();
            dateTimePickerIncome.Text = dtbl.Rows[0][3].ToString();

            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBoxSLNo.Text = "";
            comboBoxIncSrc.Text = "";
            textBoxAmount.Text = "";
            dateTimePickerIncome.Text = "";
            SqlDataAdapter sdp = new SqlDataAdapter("Select isnull(max(cast(SL_No as int)),0)+1 from tb_income", sqlcon);
            DataTable dtbl = new DataTable();
            sdp.Fill(dtbl);
            textBoxSLNo.Text = dtbl.Rows[0][0].ToString();

        }

        private void ComboBoxIncSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void TextBoxTotal_TextChanged(object sender, EventArgs e)
        {
         
            textBoxTotal.Text = textBoxTotal.Text + textBoxAmount.Text;
        }

        private void enterAction(object sender, EventArgs e)
        {
            //textBoxTotal.Text = textBoxTotal.Text + textBoxAmount.Text;
        }

        private void TextBoxAmount_TextChanged(object sender, EventArgs e)
        {
        //    string q;
        //    q = textBoxTotal.Text + textBoxAmount.Text;
        //    textBoxTotal.Text = q.ToString();
        }

        private void TextBoxAmount_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
