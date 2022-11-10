namespace WindowsFormsApp1
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.regButton = new MaterialSkin.Controls.MaterialButton();
            this.loginTB = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTB = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 116);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 214);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Пароль";
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = false;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(116, 352);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(173, 36);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Войти";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // regButton
            // 
            this.regButton.AutoSize = false;
            this.regButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.regButton.Depth = 0;
            this.regButton.HighEmphasis = true;
            this.regButton.Icon = null;
            this.regButton.Location = new System.Drawing.Point(116, 392);
            this.regButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.regButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.regButton.Name = "regButton";
            this.regButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.regButton.Size = new System.Drawing.Size(173, 36);
            this.regButton.TabIndex = 6;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.regButton.UseAccentColor = false;
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // loginTB
            // 
            this.loginTB.AnimateReadOnly = false;
            this.loginTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTB.Depth = 0;
            this.loginTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTB.LeadingIcon = null;
            this.loginTB.Location = new System.Drawing.Point(29, 148);
            this.loginTB.MaxLength = 50;
            this.loginTB.MouseState = MaterialSkin.MouseState.OUT;
            this.loginTB.Multiline = false;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(359, 50);
            this.loginTB.TabIndex = 7;
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
            this.passwordTB.Location = new System.Drawing.Point(29, 236);
            this.passwordTB.MaxLength = 50;
            this.passwordTB.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(359, 50);
            this.passwordTB.TabIndex = 8;
            this.passwordTB.Text = "";
            this.passwordTB.TrailingIcon = null;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(413, 450);
            this.MinimumSize = new System.Drawing.Size(413, 450);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialButton regButton;
        private MaterialSkin.Controls.MaterialTextBox loginTB;
        private MaterialSkin.Controls.MaterialTextBox passwordTB;
    }
}