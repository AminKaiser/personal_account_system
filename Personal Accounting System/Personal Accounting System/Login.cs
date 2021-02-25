using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personal_Accounting_System
{
    public partial class Login : Form
    {
        
       // int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB1;Integrated Security=True");
        private void SignInButton_Click(object sender, EventArgs e)
        {
         

            string query = "select * from tb_userinfo where username='"+ UserNameTextBox.Text.Trim() + "'and password='"+PasswordTextBox.Text.Trim()+"'";
            SqlDataAdapter sdp = new SqlDataAdapter(query,sqlcon);
            DataTable dtbl = new DataTable();
            sdp.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
               MainForm mnfrm = new MainForm();
                this.Hide();
                mnfrm.Show();
            }






            //try {
            //    SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB;Integrated Security=True");
            //    string query="SELECT COUNT(*) FROM tb_user_info WHERE username='"+UserNameTextBox.Text.Trim()+"' and password='"+PasswordTextBox.Text.Trim()+"' ";
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);

            //    if (dataTable.Rows[0].ToString()=="1")
            //    {
            //        if (dataTable.Columns[0].ToString() == "1")
            //        {
            //            MainForm mainForm = new MainForm();
            //            this.Hide();
            //            mainForm.Show();
            //        }
            //        else { }

            //    }
            //    else { MessageBox.Show("Error"); }

            //if (UserNameTextBox.Text == "" && PasswordTextBox.Text == "")
            //{
            //    //Form2 form2 = new Form2();    form2.Visible = true;   this.Hide();  
            //    //or
            //    MainForm form2 = new MainForm
            //    {
            //        Visible = true
            //    };
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Sorry");
            //    count++;
            //    MessageBox.Show("You can try" + (3 - count) + " Times");
            //    if (count >= 3)
            //    {
            //        Thread.Sleep(10000);
            //        count = 0;
            //    }
            //}
            //}
            //catch (Exception o) { }


        }

        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        //private Boolean ValidationCheck()
        ////{
        ////    if (UserNameTextBox.Text.Trim().)
        ////    {
        ////        if (PasswordTextBox.Text.ToString() == " ")
        ////        {
        ////            return true;
        //        }
        //        else
        //            MessageBox.Show("Please enter password", "Error");
        //    }
        //    else
        //        MessageBox.Show("Please enter username", "Error");

        //    return false;


        //public void PasswordCheck()
        //{
        //    try
        //    {
        //        String sql = "select password from tbnewuserinfo where fullname like '" + CmbUsername.getSelectedItem().toString().trim() + "'";
        //        ResultSet rs = db.sta.executeQuery(sql);
        //        while (rs.next())
        //        {
        //            password = rs.getString("password");
        //        }
        //    }
        //    catch (Exception exp)
        //    {
        //        JOptionPane.showMessageDialog(null, exp);
        //    }
        //}

    }
}
