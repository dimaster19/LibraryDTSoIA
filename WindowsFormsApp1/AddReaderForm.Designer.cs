namespace WindowsFormsApp1
{
    partial class AddReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReaderForm));
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.phoneTB = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.addressTB = new MaterialSkin.Controls.MaterialTextBox();
            this.readerFullNameTB = new MaterialSkin.Controls.MaterialLabel();
            this.nameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(197, 372);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(109, 36);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(65, 277);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Телефон";
            // 
            // phoneTB
            // 
            this.phoneTB.AnimateReadOnly = false;
            this.phoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTB.Depth = 0;
            this.phoneTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneTB.LeadingIcon = null;
            this.phoneTB.Location = new System.Drawing.Point(65, 299);
            this.phoneTB.MaxLength = 20;
            this.phoneTB.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneTB.Multiline = false;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(398, 50);
            this.phoneTB.TabIndex = 23;
            this.phoneTB.Text = "";
            this.phoneTB.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(65, 199);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "Адрес";
            // 
            // addressTB
            // 
            this.addressTB.AnimateReadOnly = false;
            this.addressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTB.Depth = 0;
            this.addressTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressTB.LeadingIcon = null;
            this.addressTB.Location = new System.Drawing.Point(65, 220);
            this.addressTB.MaxLength = 100;
            this.addressTB.MouseState = MaterialSkin.MouseState.OUT;
            this.addressTB.Multiline = false;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(398, 50);
            this.addressTB.TabIndex = 36;
            this.addressTB.Text = "";
            this.addressTB.TrailingIcon = null;
            // 
            // readerFullNameTB
            // 
            this.readerFullNameTB.AutoSize = true;
            this.readerFullNameTB.Depth = 0;
            this.readerFullNameTB.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.readerFullNameTB.Location = new System.Drawing.Point(65, 124);
            this.readerFullNameTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.readerFullNameTB.Name = "readerFullNameTB";
            this.readerFullNameTB.Size = new System.Drawing.Size(35, 19);
            this.readerFullNameTB.TabIndex = 35;
            this.readerFullNameTB.Text = "ФИО";
            // 
            // nameTB
            // 
            this.nameTB.AnimateReadOnly = false;
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Depth = 0;
            this.nameTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTB.LeadingIcon = null;
            this.nameTB.Location = new System.Drawing.Point(65, 146);
            this.nameTB.MaxLength = 40;
            this.nameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTB.Multiline = false;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(398, 50);
            this.nameTB.TabIndex = 34;
            this.nameTB.Text = "";
            this.nameTB.TrailingIcon = null;
            // 
            // AddReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 446);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.readerFullNameTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.phoneTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(533, 446);
            this.MinimumSize = new System.Drawing.Size(533, 446);
            this.Name = "AddReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReaderForm";
            this.Load += new System.EventHandler(this.AddReaderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox phoneTB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox addressTB;
        private MaterialSkin.Controls.MaterialLabel readerFullNameTB;
        private MaterialSkin.Controls.MaterialTextBox nameTB;
    }
}