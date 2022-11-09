namespace WindowsFormsApp1
{
    partial class AddGivenBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGivenBookForm));
            this.workerCB = new MaterialSkin.Controls.MaterialComboBox();
            this.readerCB = new MaterialSkin.Controls.MaterialComboBox();
            this.bookCB = new MaterialSkin.Controls.MaterialComboBox();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateStartTB = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dateEndTB = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // workerCB
            // 
            this.workerCB.AutoResize = false;
            this.workerCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workerCB.Depth = 0;
            this.workerCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.workerCB.DropDownHeight = 174;
            this.workerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerCB.DropDownWidth = 121;
            this.workerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.workerCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.workerCB.FormattingEnabled = true;
            this.workerCB.IntegralHeight = false;
            this.workerCB.ItemHeight = 43;
            this.workerCB.Location = new System.Drawing.Point(69, 405);
            this.workerCB.MaxDropDownItems = 4;
            this.workerCB.MouseState = MaterialSkin.MouseState.OUT;
            this.workerCB.Name = "workerCB";
            this.workerCB.Size = new System.Drawing.Size(397, 49);
            this.workerCB.StartIndex = 0;
            this.workerCB.TabIndex = 20;
            // 
            // readerCB
            // 
            this.readerCB.AutoResize = false;
            this.readerCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readerCB.Depth = 0;
            this.readerCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.readerCB.DropDownHeight = 174;
            this.readerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readerCB.DropDownWidth = 121;
            this.readerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.readerCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.readerCB.FormattingEnabled = true;
            this.readerCB.IntegralHeight = false;
            this.readerCB.ItemHeight = 43;
            this.readerCB.Location = new System.Drawing.Point(69, 182);
            this.readerCB.MaxDropDownItems = 4;
            this.readerCB.MouseState = MaterialSkin.MouseState.OUT;
            this.readerCB.Name = "readerCB";
            this.readerCB.Size = new System.Drawing.Size(397, 49);
            this.readerCB.StartIndex = 0;
            this.readerCB.TabIndex = 19;
            // 
            // bookCB
            // 
            this.bookCB.AutoResize = false;
            this.bookCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookCB.Depth = 0;
            this.bookCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bookCB.DropDownHeight = 174;
            this.bookCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookCB.DropDownWidth = 121;
            this.bookCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bookCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookCB.FormattingEnabled = true;
            this.bookCB.IntegralHeight = false;
            this.bookCB.ItemHeight = 43;
            this.bookCB.Location = new System.Drawing.Point(68, 113);
            this.bookCB.MaxDropDownItems = 4;
            this.bookCB.MouseState = MaterialSkin.MouseState.OUT;
            this.bookCB.Name = "bookCB";
            this.bookCB.Size = new System.Drawing.Size(397, 49);
            this.bookCB.StartIndex = 0;
            this.bookCB.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(201, 477);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(109, 36);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(66, 383);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Работник";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(66, 234);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(101, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Дата выдачи";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(66, 165);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Читатель";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(66, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(45, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Книга";
            // 
            // dateStartTB
            // 
            this.dateStartTB.AnimateReadOnly = false;
            this.dateStartTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateStartTB.Depth = 0;
            this.dateStartTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateStartTB.LeadingIcon = null;
            this.dateStartTB.Location = new System.Drawing.Point(67, 256);
            this.dateStartTB.MaxLength = 50;
            this.dateStartTB.MouseState = MaterialSkin.MouseState.OUT;
            this.dateStartTB.Multiline = false;
            this.dateStartTB.Name = "dateStartTB";
            this.dateStartTB.Size = new System.Drawing.Size(398, 50);
            this.dateStartTB.TabIndex = 12;
            this.dateStartTB.Text = "";
            this.dateStartTB.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(66, 308);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(88, 19);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Дата сдачи";
            // 
            // dateEndTB
            // 
            this.dateEndTB.AnimateReadOnly = false;
            this.dateEndTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateEndTB.Depth = 0;
            this.dateEndTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateEndTB.LeadingIcon = null;
            this.dateEndTB.Location = new System.Drawing.Point(67, 330);
            this.dateEndTB.MaxLength = 50;
            this.dateEndTB.MouseState = MaterialSkin.MouseState.OUT;
            this.dateEndTB.Multiline = false;
            this.dateEndTB.Name = "dateEndTB";
            this.dateEndTB.Size = new System.Drawing.Size(398, 50);
            this.dateEndTB.TabIndex = 21;
            this.dateEndTB.Text = "";
            this.dateEndTB.TrailingIcon = null;
            // 
            // AddGivenBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 546);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dateEndTB);
            this.Controls.Add(this.workerCB);
            this.Controls.Add(this.readerCB);
            this.Controls.Add(this.bookCB);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateStartTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(533, 546);
            this.MinimumSize = new System.Drawing.Size(533, 546);
            this.Name = "AddGivenBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGivenBookForm";
            this.Load += new System.EventHandler(this.AddGivenBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox workerCB;
        private MaterialSkin.Controls.MaterialComboBox readerCB;
        private MaterialSkin.Controls.MaterialComboBox bookCB;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox dateStartTB;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox dateEndTB;
    }
}