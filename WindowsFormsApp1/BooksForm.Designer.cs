namespace WindowsFormsApp1
{
    partial class BooksForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.authorIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new WindowsFormsApp1.LibraryDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new WindowsFormsApp1.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.authorIDTableAdapter = new WindowsFormsApp1.LibraryDataSetTableAdapters.AuthorIDTableAdapter();
            this.bookLV = new MaterialSkin.Controls.MaterialListView();
            this.BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.removeButton = new MaterialSkin.Controls.MaterialButton();
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.addAuthor = new MaterialSkin.Controls.MaterialButton();
            this.addPublisher = new MaterialSkin.Controls.MaterialButton();
            this.addGenre = new MaterialSkin.Controls.MaterialButton();
            this.pcAuthorsButton = new MaterialSkin.Controls.MaterialButton();
            this.pcPublishersButton = new MaterialSkin.Controls.MaterialButton();
            this.pcGenresButton = new MaterialSkin.Controls.MaterialButton();
            this.findTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.authorCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.nameCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.authorIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authorIDBindingSource
            // 
            this.authorIDBindingSource.DataMember = "AuthorID";
            this.authorIDBindingSource.DataSource = this.libraryDataSetBindingSource;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSetBindingSource;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // authorIDTableAdapter
            // 
            this.authorIDTableAdapter.ClearBeforeFill = true;
            // 
            // bookLV
            // 
            this.bookLV.AutoSizeTable = false;
            this.bookLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookID,
            this.BookName,
            this.Author,
            this.Genre,
            this.Publisher});
            this.bookLV.Depth = 0;
            this.bookLV.FullRowSelect = true;
            this.bookLV.HideSelection = false;
            this.bookLV.Location = new System.Drawing.Point(13, 115);
            this.bookLV.MaximumSize = new System.Drawing.Size(667, 372);
            this.bookLV.MinimumSize = new System.Drawing.Size(667, 372);
            this.bookLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bookLV.MouseState = MaterialSkin.MouseState.OUT;
            this.bookLV.Name = "bookLV";
            this.bookLV.OwnerDraw = true;
            this.bookLV.Size = new System.Drawing.Size(667, 372);
            this.bookLV.TabIndex = 6;
            this.bookLV.UseCompatibleStateImageBehavior = false;
            this.bookLV.View = System.Windows.Forms.View.Details;
            // 
            // BookID
            // 
            this.BookID.Text = "ID";
            // 
            // BookName
            // 
            this.BookName.DisplayIndex = 4;
            this.BookName.Text = "Название";
            this.BookName.Width = 150;
            // 
            // Author
            // 
            this.Author.DisplayIndex = 1;
            this.Author.Text = "Автор";
            this.Author.Width = 150;
            // 
            // Genre
            // 
            this.Genre.Text = "Жанр";
            this.Genre.Width = 120;
            // 
            // Publisher
            // 
            this.Publisher.DisplayIndex = 2;
            this.Publisher.Text = "Издатель";
            this.Publisher.Width = 150;
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(13, 70);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(100, 36);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = false;
            this.removeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.removeButton.Depth = 0;
            this.removeButton.HighEmphasis = true;
            this.removeButton.Icon = null;
            this.removeButton.Location = new System.Drawing.Point(295, 70);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeButton.Name = "removeButton";
            this.removeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.removeButton.Size = new System.Drawing.Size(100, 36);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Удалить";
            this.removeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.removeButton.UseAccentColor = false;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateButton.Depth = 0;
            this.updateButton.HighEmphasis = true;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(578, 70);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateButton.Size = new System.Drawing.Size(101, 36);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Изменить";
            this.updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateButton.UseAccentColor = false;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addAuthor
            // 
            this.addAuthor.AutoSize = false;
            this.addAuthor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAuthor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addAuthor.Depth = 0;
            this.addAuthor.HighEmphasis = true;
            this.addAuthor.Icon = null;
            this.addAuthor.Location = new System.Drawing.Point(13, 604);
            this.addAuthor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addAuthor.Size = new System.Drawing.Size(181, 36);
            this.addAuthor.TabIndex = 10;
            this.addAuthor.Text = "Добавить автора";
            this.addAuthor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addAuthor.UseAccentColor = false;
            this.addAuthor.UseVisualStyleBackColor = true;
            this.addAuthor.Click += new System.EventHandler(this.addAuthor_Click);
            // 
            // addPublisher
            // 
            this.addPublisher.AutoSize = false;
            this.addPublisher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPublisher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addPublisher.Depth = 0;
            this.addPublisher.HighEmphasis = true;
            this.addPublisher.Icon = null;
            this.addPublisher.Location = new System.Drawing.Point(259, 604);
            this.addPublisher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.addPublisher.Name = "addPublisher";
            this.addPublisher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addPublisher.Size = new System.Drawing.Size(181, 36);
            this.addPublisher.TabIndex = 11;
            this.addPublisher.Text = "Добавить Издателя";
            this.addPublisher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addPublisher.UseAccentColor = false;
            this.addPublisher.UseVisualStyleBackColor = true;
            this.addPublisher.Click += new System.EventHandler(this.addPublisher_Click);
            // 
            // addGenre
            // 
            this.addGenre.AutoSize = false;
            this.addGenre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addGenre.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addGenre.Depth = 0;
            this.addGenre.HighEmphasis = true;
            this.addGenre.Icon = null;
            this.addGenre.Location = new System.Drawing.Point(498, 604);
            this.addGenre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addGenre.MouseState = MaterialSkin.MouseState.HOVER;
            this.addGenre.Name = "addGenre";
            this.addGenre.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addGenre.Size = new System.Drawing.Size(181, 36);
            this.addGenre.TabIndex = 12;
            this.addGenre.Text = "Добавить Жанр";
            this.addGenre.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addGenre.UseAccentColor = false;
            this.addGenre.UseVisualStyleBackColor = true;
            this.addGenre.Click += new System.EventHandler(this.addGenre_Click);
            // 
            // pcAuthorsButton
            // 
            this.pcAuthorsButton.AutoSize = false;
            this.pcAuthorsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pcAuthorsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pcAuthorsButton.Depth = 0;
            this.pcAuthorsButton.HighEmphasis = true;
            this.pcAuthorsButton.Icon = null;
            this.pcAuthorsButton.Location = new System.Drawing.Point(13, 652);
            this.pcAuthorsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pcAuthorsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pcAuthorsButton.Name = "pcAuthorsButton";
            this.pcAuthorsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.pcAuthorsButton.Size = new System.Drawing.Size(181, 36);
            this.pcAuthorsButton.TabIndex = 13;
            this.pcAuthorsButton.Text = "Статистика авторов";
            this.pcAuthorsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pcAuthorsButton.UseAccentColor = false;
            this.pcAuthorsButton.UseVisualStyleBackColor = true;
            this.pcAuthorsButton.Click += new System.EventHandler(this.pcAuthorsButton_Click);
            // 
            // pcPublishersButton
            // 
            this.pcPublishersButton.AutoSize = false;
            this.pcPublishersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pcPublishersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pcPublishersButton.Depth = 0;
            this.pcPublishersButton.HighEmphasis = true;
            this.pcPublishersButton.Icon = null;
            this.pcPublishersButton.Location = new System.Drawing.Point(259, 652);
            this.pcPublishersButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pcPublishersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pcPublishersButton.Name = "pcPublishersButton";
            this.pcPublishersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.pcPublishersButton.Size = new System.Drawing.Size(181, 36);
            this.pcPublishersButton.TabIndex = 14;
            this.pcPublishersButton.Text = "Статистика издателей";
            this.pcPublishersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pcPublishersButton.UseAccentColor = false;
            this.pcPublishersButton.UseVisualStyleBackColor = true;
            this.pcPublishersButton.Click += new System.EventHandler(this.pcPublishersButton_Click);
            // 
            // pcGenresButton
            // 
            this.pcGenresButton.AutoSize = false;
            this.pcGenresButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pcGenresButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pcGenresButton.Depth = 0;
            this.pcGenresButton.HighEmphasis = true;
            this.pcGenresButton.Icon = null;
            this.pcGenresButton.Location = new System.Drawing.Point(498, 652);
            this.pcGenresButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pcGenresButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pcGenresButton.Name = "pcGenresButton";
            this.pcGenresButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.pcGenresButton.Size = new System.Drawing.Size(181, 36);
            this.pcGenresButton.TabIndex = 15;
            this.pcGenresButton.Text = "Статистика жанров";
            this.pcGenresButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pcGenresButton.UseAccentColor = false;
            this.pcGenresButton.UseVisualStyleBackColor = true;
            this.pcGenresButton.Click += new System.EventHandler(this.pcGenresButton_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.AnimateReadOnly = false;
            this.findTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findTextBox.Depth = 0;
            this.findTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.findTextBox.LeadingIcon = null;
            this.findTextBox.Location = new System.Drawing.Point(13, 533);
            this.findTextBox.MaxLength = 50;
            this.findTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.findTextBox.Multiline = false;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(667, 50);
            this.findTextBox.TabIndex = 17;
            this.findTextBox.Text = "";
            this.findTextBox.TrailingIcon = null;
            // 
            // authorCheckBox
            // 
            this.authorCheckBox.AutoSize = true;
            this.authorCheckBox.Depth = 0;
            this.authorCheckBox.Location = new System.Drawing.Point(432, 490);
            this.authorCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.authorCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.authorCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorCheckBox.Name = "authorCheckBox";
            this.authorCheckBox.ReadOnly = false;
            this.authorCheckBox.Ripple = true;
            this.authorCheckBox.Size = new System.Drawing.Size(159, 37);
            this.authorCheckBox.TabIndex = 20;
            this.authorCheckBox.Text = "Поиск по автору";
            this.authorCheckBox.UseVisualStyleBackColor = true;
            this.authorCheckBox.CheckedChanged += new System.EventHandler(this.authorCheckBox_CheckedChanged);
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Depth = 0;
            this.nameCheckBox.Location = new System.Drawing.Point(83, 493);
            this.nameCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.nameCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.ReadOnly = false;
            this.nameCheckBox.Ripple = true;
            this.nameCheckBox.Size = new System.Drawing.Size(182, 37);
            this.nameCheckBox.TabIndex = 21;
            this.nameCheckBox.Text = "Поиск по названию";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            this.nameCheckBox.CheckedChanged += new System.EventHandler(this.nameCheckBox_CheckedChanged);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 698);
            this.Controls.Add(this.nameCheckBox);
            this.Controls.Add(this.authorCheckBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.pcGenresButton);
            this.Controls.Add(this.pcPublishersButton);
            this.Controls.Add(this.pcAuthorsButton);
            this.Controls.Add(this.addGenre);
            this.Controls.Add(this.addPublisher);
            this.Controls.Add(this.addAuthor);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bookLV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(693, 698);
            this.MinimumSize = new System.Drawing.Size(693, 698);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource authorIDBindingSource;
        private LibraryDataSetTableAdapters.AuthorIDTableAdapter authorIDTableAdapter;
        private MaterialSkin.Controls.MaterialListView bookLV;
        private System.Windows.Forms.ColumnHeader BookID;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Publisher;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader BookName;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialButton removeButton;
        private MaterialSkin.Controls.MaterialButton updateButton;
        private MaterialSkin.Controls.MaterialButton addAuthor;
        private MaterialSkin.Controls.MaterialButton addPublisher;
        private MaterialSkin.Controls.MaterialButton addGenre;
        private MaterialSkin.Controls.MaterialButton pcAuthorsButton;
        private MaterialSkin.Controls.MaterialButton pcPublishersButton;
        private MaterialSkin.Controls.MaterialButton pcGenresButton;
        private MaterialSkin.Controls.MaterialTextBox findTextBox;
        private MaterialSkin.Controls.MaterialCheckbox authorCheckBox;
        private MaterialSkin.Controls.MaterialCheckbox nameCheckBox;
    }
}