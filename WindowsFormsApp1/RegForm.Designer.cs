namespace WindowsFormsApp1
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.loginTB = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTB = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // loginTB
            // 
            this.loginTB.AnimateReadOnly = false;
            this.loginTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTB.Depth = 0;
            this.loginTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTB.LeadingIcon = null;
            this.loginTB.Location = new System.Drawing.Point(32, 144);
            this.loginTB.MaxLength = 20;
            this.loginTB.MouseState = MaterialSkin.MouseState.OUT;
            this.loginTB.Multiline = false;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(348, 50);
            this.loginTB.TabIndex = 0;
            this.loginTB.Text = "";
            this.loginTB.TrailingIcon = null;
            // 
            // passwordTB
            // 
            this.passwordTB.AnimateReadOnly = false;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Depth = 0;
            this.passwordTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTB.LeadingIcon = null;
            this.passwordTB.Location = new System.Drawing.Point(32, 231);
            this.passwordTB.MaxLength = 20;
            this.passwordTB.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(348, 50);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.Text = "";
            this.passwordTB.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(29, 122);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(29, 209);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Пароль";
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(128, 350);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(109, 36);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(413, 450);
            this.MinimumSize = new System.Drawing.Size(413, 450);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox loginTB;
        private MaterialSkin.Controls.MaterialTextBox passwordTB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton saveButton;
    }
}