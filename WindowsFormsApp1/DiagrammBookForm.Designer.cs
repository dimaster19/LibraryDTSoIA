namespace WindowsFormsApp1
{
    partial class DiagrammBookForm
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
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(3, 64);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(794, 383);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // DiagrammBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pieChart1);
            this.Name = "DiagrammBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagrammBookForm";
            this.Load += new System.EventHandler(this.DiagrammBookForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
    }
}