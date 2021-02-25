namespace Personal_Accounting_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeExpenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominieUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.incomeExpenseDetailsToolStripMenuItem,
            this.userSettingsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.profileToolStripMenuItem.Text = "Profile   |";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.ProfileToolStripMenuItem_Click);
            // 
            // incomeExpenseDetailsToolStripMenuItem
            // 
            this.incomeExpenseDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomesToolStripMenuItem,
            this.expenesToolStripMenuItem});
            this.incomeExpenseDetailsToolStripMenuItem.Name = "incomeExpenseDetailsToolStripMenuItem";
            this.incomeExpenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.incomeExpenseDetailsToolStripMenuItem.Text = "Income/Expense Details   |";
            // 
            // incomesToolStripMenuItem
            // 
            this.incomesToolStripMenuItem.Name = "incomesToolStripMenuItem";
            this.incomesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.incomesToolStripMenuItem.Text = "Incomes";
            this.incomesToolStripMenuItem.Click += new System.EventHandler(this.IncomesToolStripMenuItem_Click);
            // 
            // expenesToolStripMenuItem
            // 
            this.expenesToolStripMenuItem.Name = "expenesToolStripMenuItem";
            this.expenesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.expenesToolStripMenuItem.Text = "Expenes";
            this.expenesToolStripMenuItem.Click += new System.EventHandler(this.ExpenesToolStripMenuItem_Click);
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.nominieUserToolStripMenuItem});
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.userSettingsToolStripMenuItem.Text = "User Settings   |";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // nominieUserToolStripMenuItem
            // 
            this.nominieUserToolStripMenuItem.Name = "nominieUserToolStripMenuItem";
            this.nominieUserToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nominieUserToolStripMenuItem.Text = "Nominie User";
            this.nominieUserToolStripMenuItem.Click += new System.EventHandler(this.NominieUserToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomeReportToolStripMenuItem,
            this.expenseReportToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.viewToolStripMenuItem.Text = "View    |";
            // 
            // incomeReportToolStripMenuItem
            // 
            this.incomeReportToolStripMenuItem.Name = "incomeReportToolStripMenuItem";
            this.incomeReportToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.incomeReportToolStripMenuItem.Text = "Income Report";
            this.incomeReportToolStripMenuItem.Click += new System.EventHandler(this.IncomeReportToolStripMenuItem_Click);
            // 
            // expenseReportToolStripMenuItem
            // 
            this.expenseReportToolStripMenuItem.Name = "expenseReportToolStripMenuItem";
            this.expenseReportToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.expenseReportToolStripMenuItem.Text = "Expense Report";
            this.expenseReportToolStripMenuItem.Click += new System.EventHandler(this.ExpenseReportToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomeSourceToolStripMenuItem,
            this.expenseTypeToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.addToolStripMenuItem.Text = "Add     |";
            // 
            // incomeSourceToolStripMenuItem
            // 
            this.incomeSourceToolStripMenuItem.Name = "incomeSourceToolStripMenuItem";
            this.incomeSourceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.incomeSourceToolStripMenuItem.Text = "Income Source";
            this.incomeSourceToolStripMenuItem.Click += new System.EventHandler(this.IncomeSourceToolStripMenuItem_Click);
            // 
            // expenseTypeToolStripMenuItem
            // 
            this.expenseTypeToolStripMenuItem.Name = "expenseTypeToolStripMenuItem";
            this.expenseTypeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.expenseTypeToolStripMenuItem.Text = "Expense Type";
            this.expenseTypeToolStripMenuItem.Click += new System.EventHandler(this.ExpenseTypeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.logOutToolStripMenuItem.Text = "Log Out   |";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 523);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeEvent);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeExpenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem incomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominieUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseTypeToolStripMenuItem;
    }
}