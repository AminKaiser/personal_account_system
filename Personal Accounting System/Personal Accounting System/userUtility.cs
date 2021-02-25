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
    public partial class userUtility : Form
    {
        public userUtility()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-A3QHQP4\SQLEXPRESS;Initial Catalog=PASDB1;Integrated Security=True");

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "UPDATE tb_userinfo SET username='" + newUserNameTextBox.Text + "', password='" + newPasswordTextBox.Text + "'" +
                "Where username='" + userNameTextBox.Text + "' AND password ='"+ oldPasswordTextBox .Text+ "'";
            SqlDataAdapter sdp = new SqlDataAdapter(query, sqlcon);
            sdp.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();


            MessageBox.Show("Update SuccessFully!!");
            userNameTextBox.Clear();
            oldPasswordTextBox.Clear();
            newUserNameTextBox.Clear();
            newPasswordTextBox.Clear();

        }

        private void NewUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userUtility_Load(object sender, EventArgs e)
        {

        }
    }
}
