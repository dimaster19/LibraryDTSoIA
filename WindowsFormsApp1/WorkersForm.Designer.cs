namespace WindowsFormsApp1
{
    partial class WorkersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersForm));
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.removeButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.workerLV = new MaterialSkin.Controls.MaterialListView();
            this.IDWorker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
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
            this.updateButton.Location = new System.Drawing.Point(780, 330);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateButton.Size = new System.Drawing.Size(101, 36);
            this.updateButton.TabIndex = 24;
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
            this.removeButton.Location = new System.Drawing.Point(780, 282);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeButton.Name = "removeButton";
            this.removeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.removeButton.Size = new System.Drawing.Size(100, 36);
            this.removeButton.TabIndex = 23;
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
            this.addButton.Location = new System.Drawing.Point(780, 234);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(100, 36);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // workerLV
            // 
            this.workerLV.AutoSizeTable = false;
            this.workerLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workerLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDWorker,
            this.WorkerFullName,
            this.WorkerAddress,
            this.WorkerPhone});
            this.workerLV.Depth = 0;
            this.workerLV.FullRowSelect = true;
            this.workerLV.HideSelection = false;
            this.workerLV.Location = new System.Drawing.Point(6, 94);
            this.workerLV.MaximumSize = new System.Drawing.Size(767, 415);
            this.workerLV.MinimumSize = new System.Drawing.Size(767, 415);
            this.workerLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.workerLV.MouseState = MaterialSkin.MouseState.OUT;
            this.workerLV.Name = "workerLV";
            this.workerLV.OwnerDraw = true;
            this.workerLV.Size = new System.Drawing.Size(767, 415);
            this.workerLV.TabIndex = 21;
            this.workerLV.UseCompatibleStateImageBehavior = false;
            this.workerLV.View = System.Windows.Forms.View.Details;
            // 
            // IDWorker
            // 
            this.IDWorker.Text = "ID";
            // 
            // WorkerFullName
            // 
            this.WorkerFullName.Text = "ФИО";
            this.WorkerFullName.Width = 205;
            // 
            // WorkerAddress
            // 
            this.WorkerAddress.Text = "Адрес";
            this.WorkerAddress.Width = 300;
            // 
            // WorkerPhone
            // 
            this.WorkerPhone.Text = "Телефон";
            this.WorkerPhone.Width = 200;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Depth = 0;
            this.nameCheckBox.Location = new System.Drawing.Point(617, 538);
            this.nameCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.nameCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.ReadOnly = false;
            this.nameCheckBox.Ripple = true;
            this.nameCheckBox.Size = new System.Drawing.Size(154, 37);
            this.nameCheckBox.TabIndex = 27;
            this.nameCheckBox.Text = "Поиск по имени";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            this.nameCheckBox.CheckedChanged += new System.EventHandler(this.nameCheckBox_CheckedChanged);
            // 
            // findTextBox
            // 
            this.findTextBox.AnimateReadOnly = false;
            this.findTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findTextBox.Depth = 0;
            this.findTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.findTextBox.LeadingIcon = null;
            this.findTextBox.Location = new System.Drawing.Point(6, 531);
            this.findTextBox.MaxLength = 50;
            this.findTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.findTextBox.Multiline = false;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(608, 50);
            this.findTextBox.TabIndex = 25;
            this.findTextBox.Text = "";
            this.findTextBox.TrailingIcon = null;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 597);
            this.Controls.Add(this.nameCheckBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.workerLV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 597);
            this.MinimumSize = new System.Drawing.Size(900, 597);
            this.Name = "WorkersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkersForm";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton updateButton;
        private MaterialSkin.Controls.MaterialButton removeButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialListView workerLV;
        private System.Windows.Forms.ColumnHeader IDWorker;
        private System.Windows.Forms.ColumnHeader WorkerFullName;
        private System.Windows.Forms.ColumnHeader WorkerAddress;
        private System.Windows.Forms.ColumnHeader WorkerPhone;
        private MaterialSkin.Controls.MaterialCheckbox nameCheckBox;
        private MaterialSkin.Controls.MaterialTextBox findTextBox;
    }
}