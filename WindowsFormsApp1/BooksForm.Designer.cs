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
            this.bookLV.Location = new System.Drawing.Point(7, 93);
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
            this.addButton.Location = new System.Drawing.Point(692, 192);
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
            this.removeButton.Location = new System.Drawing.Point(692, 240);
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
            this.updateButton.Location = new System.Drawing.Point(692, 288);
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
            this.addAuthor.Location = new System.Drawing.Point(8, 474);
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
            this.addPublisher.Location = new System.Drawing.Point(254, 474);
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
            this.addGenre.Location = new System.Drawing.Point(493, 474);
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
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.addGenre);
            this.Controls.Add(this.addPublisher);
            this.Controls.Add(this.addAuthor);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bookLV);
            this.MaximumSize = new System.Drawing.Size(800, 535);
            this.MinimumSize = new System.Drawing.Size(800, 535);
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
    }
}