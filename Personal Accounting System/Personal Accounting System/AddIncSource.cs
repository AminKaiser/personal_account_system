﻿using System;
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
    public partial class AddIncomeSource : Form
    {
        public AddIncomeSource()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB1;Integrated Security=True");
       

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "INSERT INTO tb_AddSource (SL_No,Source_Name)VALUES('" + textBoxSLNo.Text + "','" + textBoxSource.Text + "')";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            sdp.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();


            MessageBox.Show("Insert SuccessFully!!");
        }

        private void IncomeSource_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sdp = new SqlDataAdapter("Select isnull(max(cast(SL_No as int)),0)+1 from tb_AddSource", sqlcon);
            DataTable dtbl = new DataTable();
            sdp.Fill(dtbl);
            textBoxSLNo.Text = dtbl.Rows[0][0].ToString();
        }

        private void TextBoxSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
