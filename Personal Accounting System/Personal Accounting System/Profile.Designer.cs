namespace Personal_Accounting_System
{
    partial class Profile
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.totalBalanceTextBox = new System.Windows.Forms.TextBox();
            this.incomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.expenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uploadPicture = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // totalBalanceTextBox
            // 
            this.totalBalanceTextBox.BackColor = System.Drawing.Color.White;
            this.totalBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalBalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBalanceTextBox.ForeColor = System.Drawing.Color.Black;
            this.totalBalanceTextBox.Location = new System.Drawing.Point(125, 265);
            this.totalBalanceTextBox.Name = "totalBalanceTextBox";
            this.totalBalanceTextBox.Size = new System.Drawing.Size(166, 31);
            this.totalBalanceTextBox.TabIndex = 4;
            this.totalBalanceTextBox.TextChanged += new System.EventHandler(this.TotalBalanceTextBox_TextChanged);
            // 
            // incomeChart
            // 
            this.incomeChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea3.Name = "ChartArea1";
            this.incomeChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.incomeChart.Legends.Add(legend3);
            this.incomeChart.Location = new System.Drawing.Point(461, 12);
            this.incomeChart.Name = "incomeChart";
            this.incomeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Source";
            this.incomeChart.Series.Add(series3);
            this.incomeChart.Size = new System.Drawing.Size(467, 242);
            this.incomeChart.TabIndex = 5;
            this.incomeChart.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Income Chart";
            this.incomeChart.Titles.Add(title3);
            // 
            // expenseChart
            // 
            chartArea4.Name = "ChartArea1";
            this.expenseChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.expenseChart.Legends.Add(legend4);
            this.expenseChart.Location = new System.Drawing.Point(461, 265);
            this.expenseChart.Name = "expenseChart";
            this.expenseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Expense";
            this.expenseChart.Series.Add(series4);
            this.expenseChart.Size = new System.Drawing.Size(467, 237);
            this.expenseChart.TabIndex = 6;
            this.expenseChart.Text = "chart2";
            title4.Name = "Title1";
            title4.Text = "Expense Chart";
            this.expenseChart.Titles.Add(title4);
            // 
            // uploadPicture
            // 
            this.uploadPicture.AutoSize = true;
            this.uploadPicture.ForeColor = System.Drawing.Color.White;
            this.uploadPicture.Location = new System.Drawing.Point(286, 173);
            this.uploadPicture.Name = "uploadPicture";
            this.uploadPicture.Size = new System.Drawing.Size(129, 13);
            this.uploadPicture.TabIndex = 7;
            this.uploadPicture.Text = "update your profile picture";
            this.uploadPicture.Click += new System.EventHandler(this.UploadPicture_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(135, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(145, 136);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "NET $";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(940, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadPicture);
            this.Controls.Add(this.expenseChart);
            this.Controls.Add(this.incomeChart);
            this.Controls.Add(this.totalBalanceTextBox);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox totalBalanceTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart incomeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart expenseChart;
        private System.Windows.Forms.Label uploadPicture;
        private System.Windows.Forms.Label label1;
    }
}