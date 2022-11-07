namespace WindowsFormsApp1
{
    partial class AddBookForm
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
            this.bookNameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.authorCB = new MaterialSkin.Controls.MaterialComboBox();
            this.genreCB = new MaterialSkin.Controls.MaterialComboBox();
            this.publisherCB = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // bookNameTB
            // 
            this.bookNameTB.AnimateReadOnly = false;
            this.bookNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookNameTB.Depth = 0;
            this.bookNameTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bookNameTB.LeadingIcon = null;
            this.bookNameTB.Location = new System.Drawing.Point(74, 118);
            this.bookNameTB.MaxLength = 50;
            this.bookNameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.bookNameTB.Multiline = false;
            this.bookNameTB.Name = "bookNameTB";
            this.bookNameTB.Size = new System.Drawing.Size(398, 50);
            this.bookNameTB.TabIndex = 0;
            this.bookNameTB.Text = "";
            this.bookNameTB.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(72, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Название";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(72, 171);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Автор";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(72, 240);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(43, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Жанр";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(72, 315);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Издатель";
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(211, 421);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(109, 36);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // authorCB
            // 
            this.authorCB.AutoResize = false;
            this.authorCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.authorCB.Depth = 0;
            this.authorCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.authorCB.DropDownHeight = 174;
            this.authorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorCB.DropDownWidth = 121;
            this.authorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.authorCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.authorCB.FormattingEnabled = true;
            this.authorCB.IntegralHeight = false;
            this.authorCB.ItemHeight = 43;
            this.authorCB.Location = new System.Drawing.Point(74, 193);
            this.authorCB.MaxDropDownItems = 4;
            this.authorCB.MouseState = MaterialSkin.MouseState.OUT;
            this.authorCB.Name = "authorCB";
            this.authorCB.Size = new System.Drawing.Size(397, 49);
            this.authorCB.StartIndex = 0;
            this.authorCB.TabIndex = 9;
            // 
            // genreCB
            // 
            this.genreCB.AutoResize = false;
            this.genreCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.genreCB.Depth = 0;
            this.genreCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.genreCB.DropDownHeight = 174;
            this.genreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCB.DropDownWidth = 121;
            this.genreCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.genreCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genreCB.FormattingEnabled = true;
            this.genreCB.IntegralHeight = false;
            this.genreCB.ItemHeight = 43;
            this.genreCB.Location = new System.Drawing.Point(74, 265);
            this.genreCB.MaxDropDownItems = 4;
            this.genreCB.MouseState = MaterialSkin.MouseState.OUT;
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(397, 49);
            this.genreCB.StartIndex = 0;
            this.genreCB.TabIndex = 10;
            // 
            // publisherCB
            // 
            this.publisherCB.AutoResize = false;
            this.publisherCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.publisherCB.Depth = 0;
            this.publisherCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.publisherCB.DropDownHeight = 174;
            this.publisherCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisherCB.DropDownWidth = 121;
            this.publisherCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.publisherCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.publisherCB.FormattingEnabled = true;
            this.publisherCB.IntegralHeight = false;
            this.publisherCB.ItemHeight = 43;
            this.publisherCB.Location = new System.Drawing.Point(75, 339);
            this.publisherCB.MaxDropDownItems = 4;
            this.publisherCB.MouseState = MaterialSkin.MouseState.OUT;
            this.publisherCB.Name = "publisherCB";
            this.publisherCB.Size = new System.Drawing.Size(397, 49);
            this.publisherCB.StartIndex = 0;
            this.publisherCB.TabIndex = 11;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 486);
            this.Controls.Add(this.publisherCB);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.authorCB);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.bookNameTB);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox bookNameTB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialComboBox authorCB;
        private MaterialSkin.Controls.MaterialComboBox genreCB;
        private MaterialSkin.Controls.MaterialComboBox publisherCB;
    }
}