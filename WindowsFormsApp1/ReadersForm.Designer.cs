namespace WindowsFormsApp1
{
    partial class ReadersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadersForm));
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.removeButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.readerLV = new MaterialSkin.Controls.MaterialListView();
            this.IDReader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateButton.Depth = 0;
            this.updateButton.HighEmphasis = true;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(780, 327);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateButton.Size = new System.Drawing.Size(101, 36);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Изменить";
            this.updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateButton.UseAccentColor = false;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = false;
            this.removeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.removeButton.Depth = 0;
            this.removeButton.HighEmphasis = true;
            this.removeButton.Icon = null;
            this.removeButton.Location = new System.Drawing.Point(780, 279);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeButton.Name = "removeButton";
            this.removeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.removeButton.Size = new System.Drawing.Size(100, 36);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "Удалить";
            this.removeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.removeButton.UseAccentColor = false;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(780, 231);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(100, 36);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // readerLV
            // 
            this.readerLV.AutoSizeTable = false;
            this.readerLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readerLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readerLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDReader,
            this.ReaderFullName,
            this.ReaderAddress,
            this.ReaderPhone});
            this.readerLV.Depth = 0;
            this.readerLV.FullRowSelect = true;
            this.readerLV.HideSelection = false;
            this.readerLV.Location = new System.Drawing.Point(6, 91);
            this.readerLV.MaximumSize = new System.Drawing.Size(767, 415);
            this.readerLV.MinimumSize = new System.Drawing.Size(767, 415);
            this.readerLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.readerLV.MouseState = MaterialSkin.MouseState.OUT;
            this.readerLV.Name = "readerLV";
            this.readerLV.OwnerDraw = true;
            this.readerLV.Size = new System.Drawing.Size(767, 415);
            this.readerLV.TabIndex = 17;
            this.readerLV.UseCompatibleStateImageBehavior = false;
            this.readerLV.View = System.Windows.Forms.View.Details;
            // 
            // IDReader
            // 
            this.IDReader.Text = "ID";
            // 
            // ReaderFullName
            // 
            this.ReaderFullName.Text = "ФИО";
            this.ReaderFullName.Width = 205;
            // 
            // ReaderAddress
            // 
            this.ReaderAddress.Text = "Адрес";
            this.ReaderAddress.Width = 300;
            // 
            // ReaderPhone
            // 
            this.ReaderPhone.Text = "Телефон";
            this.ReaderPhone.Width = 200;
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.readerLV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 535);
            this.MinimumSize = new System.Drawing.Size(900, 535);
            this.Name = "ReadersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadersForm";
            this.Load += new System.EventHandler(this.ReadersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton updateButton;
        private MaterialSkin.Controls.MaterialButton removeButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialListView readerLV;
        private System.Windows.Forms.ColumnHeader IDReader;
        private System.Windows.Forms.ColumnHeader ReaderFullName;
        private System.Windows.Forms.ColumnHeader ReaderAddress;
        private System.Windows.Forms.ColumnHeader ReaderPhone;
    }
}