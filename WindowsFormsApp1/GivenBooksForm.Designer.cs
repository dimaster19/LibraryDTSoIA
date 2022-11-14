namespace WindowsFormsApp1
{
    partial class GivenBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GivenBooksForm));
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.removeButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.bookLV = new MaterialSkin.Controls.MaterialListView();
            this.GivenID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readerCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.workerCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.findTextBox = new MaterialSkin.Controls.MaterialTextBox();
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
            this.updateButton.TabIndex = 16;
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
            this.removeButton.TabIndex = 15;
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
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bookLV
            // 
            this.bookLV.AutoSizeTable = false;
            this.bookLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GivenID,
            this.BookName,
            this.ReaderFullName,
            this.DateStart,
            this.DateEnd,
            this.WorkerFullName});
            this.bookLV.Depth = 0;
            this.bookLV.FullRowSelect = true;
            this.bookLV.HideSelection = false;
            this.bookLV.Location = new System.Drawing.Point(6, 91);
            this.bookLV.MaximumSize = new System.Drawing.Size(767, 415);
            this.bookLV.MinimumSize = new System.Drawing.Size(767, 415);
            this.bookLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bookLV.MouseState = MaterialSkin.MouseState.OUT;
            this.bookLV.Name = "bookLV";
            this.bookLV.OwnerDraw = true;
            this.bookLV.Size = new System.Drawing.Size(767, 415);
            this.bookLV.TabIndex = 13;
            this.bookLV.UseCompatibleStateImageBehavior = false;
            this.bookLV.View = System.Windows.Forms.View.Details;
            // 
            // GivenID
            // 
            this.GivenID.Text = "ID";
            // 
            // BookName
            // 
            this.BookName.Text = "Название";
            this.BookName.Width = 150;
            // 
            // ReaderFullName
            // 
            this.ReaderFullName.Text = "Читатель";
            this.ReaderFullName.Width = 150;
            // 
            // DateStart
            // 
            this.DateStart.Text = "От";
            this.DateStart.Width = 120;
            // 
            // DateEnd
            // 
            this.DateEnd.Text = "До";
            this.DateEnd.Width = 150;
            // 
            // WorkerFullName
            // 
            this.WorkerFullName.Text = "Работник";
            this.WorkerFullName.Width = 120;
            // 
            // readerCheckBox
            // 
            this.readerCheckBox.AutoSize = true;
            this.readerCheckBox.Depth = 0;
            this.readerCheckBox.Location = new System.Drawing.Point(126, 512);
            this.readerCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.readerCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.readerCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.readerCheckBox.Name = "readerCheckBox";
            this.readerCheckBox.ReadOnly = false;
            this.readerCheckBox.Ripple = true;
            this.readerCheckBox.Size = new System.Drawing.Size(180, 37);
            this.readerCheckBox.TabIndex = 24;
            this.readerCheckBox.Text = "Поиск по читателю";
            this.readerCheckBox.UseVisualStyleBackColor = true;
            this.readerCheckBox.CheckedChanged += new System.EventHandler(this.readerCheckBox_CheckedChanged);
            // 
            // workerCheckBox
            // 
            this.workerCheckBox.AutoSize = true;
            this.workerCheckBox.Depth = 0;
            this.workerCheckBox.Location = new System.Drawing.Point(475, 509);
            this.workerCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.workerCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.workerCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.workerCheckBox.Name = "workerCheckBox";
            this.workerCheckBox.ReadOnly = false;
            this.workerCheckBox.Ripple = true;
            this.workerCheckBox.Size = new System.Drawing.Size(186, 37);
            this.workerCheckBox.TabIndex = 23;
            this.workerCheckBox.Text = "Поиск по работнику";
            this.workerCheckBox.UseVisualStyleBackColor = true;
            this.workerCheckBox.CheckedChanged += new System.EventHandler(this.workerCheckBox_CheckedChanged);
            // 
            // findTextBox
            // 
            this.findTextBox.AnimateReadOnly = false;
            this.findTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findTextBox.Depth = 0;
            this.findTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.findTextBox.LeadingIcon = null;
            this.findTextBox.Location = new System.Drawing.Point(56, 552);
            this.findTextBox.MaxLength = 50;
            this.findTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.findTextBox.Multiline = false;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(667, 50);
            this.findTextBox.TabIndex = 22;
            this.findTextBox.Text = "";
            this.findTextBox.TrailingIcon = null;
            // 
            // GivenBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 616);
            this.Controls.Add(this.readerCheckBox);
            this.Controls.Add(this.workerCheckBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bookLV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 616);
            this.MinimumSize = new System.Drawing.Size(900, 616);
            this.Name = "GivenBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GivenBooksForm";
            this.Load += new System.EventHandler(this.GivenBooksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton updateButton;
        private MaterialSkin.Controls.MaterialButton removeButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialListView bookLV;
        private System.Windows.Forms.ColumnHeader GivenID;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader ReaderFullName;
        private System.Windows.Forms.ColumnHeader DateStart;
        private System.Windows.Forms.ColumnHeader DateEnd;
        private System.Windows.Forms.ColumnHeader WorkerFullName;
        private MaterialSkin.Controls.MaterialCheckbox readerCheckBox;
        private MaterialSkin.Controls.MaterialCheckbox workerCheckBox;
        private MaterialSkin.Controls.MaterialTextBox findTextBox;
    }
}