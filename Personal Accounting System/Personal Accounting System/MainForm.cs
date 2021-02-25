using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Accounting_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Profile profile = new Profile();
            profile.TopLevel = false;
            panel1.Controls.Add(profile);
            profile.Show();
        }

        private void IncomesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            income inc = new income();
            inc.TopLevel = false;
            panel1.Controls.Add(inc);
            inc.Show();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            userUtility ut = new userUtility();
            ut.TopLevel = false;
            panel1.Controls.Add(ut);
            ut.Show();
        }

        private void ExpenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Expenses eps = new Expenses();
            eps.TopLevel = false;
            panel1.Controls.Add(eps);
            eps.Show();
        }

        private void NominieUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            nominiuser nmu = new nominiuser();
            nmu.TopLevel = false;
            panel1.Controls.Add(nmu);
            nmu.Show();
        }

        private void IncomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            IncomeReport vir = new IncomeReport();
            vir.TopLevel = false;
            panel1.Controls.Add(vir);
            vir.Show();
        }

        private void ExpenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            reportExpense ver = new reportExpense();
            ver.TopLevel = false;
            panel1.Controls.Add(ver);
            ver.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.Controls.Clear();
            Profile profile = new Profile();
            profile.TopLevel = false;
            panel1.Controls.Add(profile);
            profile.Show();
        }

        private void IncomeSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddIncomeSource inc = new AddIncomeSource();
            inc.TopLevel = false;
            panel1.Controls.Add(inc);
            inc.Show();
        }

        private void ExpenseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddExpType AET = new AddExpType();
            AET.TopLevel = false;
            panel1.Controls.Add(AET);
            AET.Show();
        }

         private void closeEvent(object sender, FormClosingEventArgs e)
         {
                DialogResult dr = MessageBox.Show("Are you sure want to exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    e.Cancel = true;
         }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
