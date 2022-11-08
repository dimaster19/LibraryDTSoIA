namespace WindowsFormsApp1
{
    partial class AddAuthor
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
            this.addLabel = new MaterialSkin.Controls.MaterialLabel();
            this.addTB = new MaterialSkin.Controls.MaterialTextBox();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Depth = 0;
            this.addLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addLabel.Location = new System.Drawing.Point(26, 130);
            this.addLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(90, 19);
            this.addLabel.TabIndex = 0;
            this.addLabel.Text = "Полное имя";
            // 
            // addTB
            // 
            this.addTB.AnimateReadOnly = false;
            this.addTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTB.Depth = 0;
            this.addTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addTB.LeadingIcon = null;
            this.addTB.Location = new System.Drawing.Point(25, 152);
            this.addTB.MaxLength = 50;
            this.addTB.MouseState = MaterialSkin.MouseState.OUT;
            this.addTB.Multiline = false;
            this.addTB.Name = "addTB";
            this.addTB.Size = new System.Drawing.Size(276, 50);
            this.addTB.TabIndex = 1;
            this.addTB.Text = "";
            this.addTB.TrailingIcon = null;
            // 
            // addButton
            // 
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(99, 240);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(109, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Сохранить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 320);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addTB);
            this.Controls.Add(this.addLabel);
            this.Name = "AddAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel addLabel;
        private MaterialSkin.Controls.MaterialTextBox addTB;
        private MaterialSkin.Controls.MaterialButton addButton;
    }
}