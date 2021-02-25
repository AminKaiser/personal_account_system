namespace Personal_Accounting_System
{
    partial class IncomeReport
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerIncomeReport1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIncomeReport2 = new System.Windows.Forms.DateTimePicker();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.sLNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbincomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbincomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerIncomeReport1
            // 
            this.dateTimePickerIncomeReport1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIncomeReport1.Location = new System.Drawing.Point(315, 53);
            this.dateTimePickerIncomeReport1.Name = "dateTimePickerIncomeReport1";
            this.dateTimePickerIncomeReport1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerIncomeReport1.TabIndex = 0;
            // 
            // dateTimePickerIncomeReport2
            // 
            this.dateTimePickerIncomeReport2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIncomeReport2.Location = new System.Drawing.Point(515, 54);
            this.dateTimePickerIncomeReport2.Name = "dateTimePickerIncomeReport2";
            this.dateTimePickerIncomeReport2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerIncomeReport2.TabIndex = 1;
            // 
            // dgvIncome
            // 
            this.dgvIncome.AutoGenerateColumns = false;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sLNoDataGridViewTextBoxColumn,
            this.sourcetypeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvIncome.DataSource = this.tbincomeBindingSource;
            this.dgvIncome.Location = new System.Drawing.Point(256, 90);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.Size = new System.Drawing.Size(439, 375);
            this.dgvIncome.TabIndex = 2;
            this.dgvIncome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIncome_CellContentClick);
            // 
            // sLNoDataGridViewTextBoxColumn
            // 
            this.sLNoDataGridViewTextBoxColumn.DataPropertyName = "SL_No";
            this.sLNoDataGridViewTextBoxColumn.HeaderText = "SL_No";
            this.sLNoDataGridViewTextBoxColumn.Name = "sLNoDataGridViewTextBoxColumn";
            // 
            // sourcetypeDataGridViewTextBoxColumn
            // 
            this.sourcetypeDataGridViewTextBoxColumn.DataPropertyName = "source_type";
            this.sourcetypeDataGridViewTextBoxColumn.HeaderText = "source_type";
            this.sourcetypeDataGridViewTextBoxColumn.Name = "sourcetypeDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // tbincomeBindingSource
            // 
            this.tbincomeBindingSource.DataSource = typeof(Personal_Accounting_System.tb_income);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(620, 54);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(632, 471);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(63, 23);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataSource = typeof(Personal_Accounting_System.income);
            // 
            // IncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(940, 523);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.dateTimePickerIncomeReport2);
            this.Controls.Add(this.dateTimePickerIncomeReport1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncomeReport";
            this.ShowInTaskbar = false;
            this.Text = "viewReport";
            this.Load += new System.EventHandler(this.IncomeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbincomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerIncomeReport1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncomeReport2;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourcetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbincomeBindingSource;
        private System.Windows.Forms.BindingSource incomeBindingSource;
    }
}