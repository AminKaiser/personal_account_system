namespace Personal_Accounting_System
{
    partial class reportExpense
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExp = new System.Windows.Forms.DataGridView();
            this.eXPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbexpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerExpReport2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExpReport1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbexpenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(614, 54);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 11;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "From";
            // 
            // dgvExp
            // 
            this.dgvExp.AutoGenerateColumns = false;
            this.dgvExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXPNoDataGridViewTextBoxColumn,
            this.exptypeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvExp.DataSource = this.tbexpenseBindingSource;
            this.dgvExp.Location = new System.Drawing.Point(250, 93);
            this.dgvExp.Name = "dgvExp";
            this.dgvExp.Size = new System.Drawing.Size(439, 375);
            this.dgvExp.TabIndex = 8;
            // 
            // eXPNoDataGridViewTextBoxColumn
            // 
            this.eXPNoDataGridViewTextBoxColumn.DataPropertyName = "EXP_No";
            this.eXPNoDataGridViewTextBoxColumn.HeaderText = "EXP_No";
            this.eXPNoDataGridViewTextBoxColumn.Name = "eXPNoDataGridViewTextBoxColumn";
            // 
            // exptypeDataGridViewTextBoxColumn
            // 
            this.exptypeDataGridViewTextBoxColumn.DataPropertyName = "exp_type";
            this.exptypeDataGridViewTextBoxColumn.HeaderText = "exp_type";
            this.exptypeDataGridViewTextBoxColumn.Name = "exptypeDataGridViewTextBoxColumn";
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
            // tbexpenseBindingSource
            // 
            this.tbexpenseBindingSource.DataSource = typeof(Personal_Accounting_System.tb_expense);
            // 
            // dateTimePickerExpReport2
            // 
            this.dateTimePickerExpReport2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpReport2.Location = new System.Drawing.Point(476, 55);
            this.dateTimePickerExpReport2.Name = "dateTimePickerExpReport2";
            this.dateTimePickerExpReport2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerExpReport2.TabIndex = 7;
            // 
            // dateTimePickerExpReport1
            // 
            this.dateTimePickerExpReport1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpReport1.Location = new System.Drawing.Point(297, 55);
            this.dateTimePickerExpReport1.Name = "dateTimePickerExpReport1";
            this.dateTimePickerExpReport1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerExpReport1.TabIndex = 6;
            // 
            // reportExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(940, 523);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExp);
            this.Controls.Add(this.dateTimePickerExpReport2);
            this.Controls.Add(this.dateTimePickerExpReport1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportExpense";
            this.Text = "reportExpense";
            this.Load += new System.EventHandler(this.reportExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbexpenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExp;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpReport2;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpReport1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbexpenseBindingSource;
    }
}