namespace AddressBook
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.UpBelt = new System.Windows.Forms.Panel();
            this.DeveloperName = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DownBelt = new System.Windows.Forms.Panel();
            this.BacgroundTheme = new System.Windows.Forms.PictureBox();
            this.HeaderTheme = new System.Windows.Forms.PictureBox();
            this.LogoAPP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputSearcher = new System.Windows.Forms.TextBox();
            this.SearcherTheme = new System.Windows.Forms.PictureBox();
            this.ContactsTable = new System.Windows.Forms.DataGridView();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTheme = new System.Windows.Forms.PictureBox();
            this.SecondNameTheme = new System.Windows.Forms.PictureBox();
            this.AgeTheme = new System.Windows.Forms.PictureBox();
            this.SexTheme = new System.Windows.Forms.PictureBox();
            this.PostalTheme = new System.Windows.Forms.PictureBox();
            this.CityTheme = new System.Windows.Forms.PictureBox();
            this.HomeNumberTheme = new System.Windows.Forms.PictureBox();
            this.HomeNumerTheme = new System.Windows.Forms.PictureBox();
            this.NameHeader = new System.Windows.Forms.Label();
            this.SecondNameHeader = new System.Windows.Forms.Label();
            this.AgeHeader = new System.Windows.Forms.Label();
            this.SexHeader = new System.Windows.Forms.Label();
            this.PostalHeader = new System.Windows.Forms.Label();
            this.CityHeader = new System.Windows.Forms.Label();
            this.StreetHeader = new System.Windows.Forms.Label();
            this.HomeNumberHeader = new System.Windows.Forms.Label();
            this.editTheme = new System.Windows.Forms.PictureBox();
            this.editHeader = new System.Windows.Forms.Label();
            this.deleteContact = new System.Windows.Forms.Button();
            this.saveAll = new System.Windows.Forms.Button();
            this.editContact = new System.Windows.Forms.Button();
            this.addContact = new System.Windows.Forms.Button();
            this.openFileWithContacts = new System.Windows.Forms.Button();
            this.Navigate = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundTip = new System.Windows.Forms.PictureBox();
            this.restartApplication = new System.Windows.Forms.Button();
            this.UpBelt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BacgroundTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearcherTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeNumberTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeNumerTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundTip)).BeginInit();
            this.SuspendLayout();
            // 
            // UpBelt
            // 
            this.UpBelt.BackColor = System.Drawing.Color.Black;
            this.UpBelt.Controls.Add(this.restartApplication);
            this.UpBelt.Controls.Add(this.DeveloperName);
            this.UpBelt.Controls.Add(this.MinimizeButton);
            this.UpBelt.Controls.Add(this.ExitButton);
            this.UpBelt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpBelt.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpBelt.Location = new System.Drawing.Point(0, 0);
            this.UpBelt.Name = "UpBelt";
            this.UpBelt.Size = new System.Drawing.Size(989, 34);
            this.UpBelt.TabIndex = 11;
            this.UpBelt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBelt_MouseDown);
            this.UpBelt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpBelt_MouseMove);
            this.UpBelt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpBelt_MouseUp);
            // 
            // DeveloperName
            // 
            this.DeveloperName.AutoSize = true;
            this.DeveloperName.BackColor = System.Drawing.Color.Black;
            this.DeveloperName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeveloperName.ForeColor = System.Drawing.Color.White;
            this.DeveloperName.Location = new System.Drawing.Point(7, 9);
            this.DeveloperName.Name = "DeveloperName";
            this.DeveloperName.Size = new System.Drawing.Size(202, 16);
            this.DeveloperName.TabIndex = 47;
            this.DeveloperName.Text = "Copyright © 2020 Damian Czerwiński";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Black;
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(920, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(34, 34);
            this.MinimizeButton.TabIndex = 14;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = " ";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(955, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(34, 34);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DownBelt
            // 
            this.DownBelt.BackColor = System.Drawing.Color.Black;
            this.DownBelt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownBelt.Location = new System.Drawing.Point(0, 582);
            this.DownBelt.Name = "DownBelt";
            this.DownBelt.Size = new System.Drawing.Size(989, 10);
            this.DownBelt.TabIndex = 13;
            // 
            // BacgroundTheme
            // 
            this.BacgroundTheme.BackColor = System.Drawing.Color.White;
            this.BacgroundTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BacgroundTheme.Location = new System.Drawing.Point(9, 43);
            this.BacgroundTheme.Name = "BacgroundTheme";
            this.BacgroundTheme.Size = new System.Drawing.Size(972, 531);
            this.BacgroundTheme.TabIndex = 14;
            this.BacgroundTheme.TabStop = false;
            // 
            // HeaderTheme
            // 
            this.HeaderTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderTheme.Location = new System.Drawing.Point(15, 49);
            this.HeaderTheme.Name = "HeaderTheme";
            this.HeaderTheme.Size = new System.Drawing.Size(960, 28);
            this.HeaderTheme.TabIndex = 15;
            this.HeaderTheme.TabStop = false;
            // 
            // LogoAPP
            // 
            this.LogoAPP.AutoSize = true;
            this.LogoAPP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoAPP.Location = new System.Drawing.Point(413, 54);
            this.LogoAPP.Name = "LogoAPP";
            this.LogoAPP.Size = new System.Drawing.Size(164, 19);
            this.LogoAPP.TabIndex = 16;
            this.LogoAPP.Text = "KSIĄŻKA ADRESOWA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 43);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "WYSZUKIWARKA";
            // 
            // InputSearcher
            // 
            this.InputSearcher.BackColor = System.Drawing.Color.White;
            this.InputSearcher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputSearcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InputSearcher.ForeColor = System.Drawing.Color.Black;
            this.InputSearcher.Location = new System.Drawing.Point(157, 94);
            this.InputSearcher.Name = "InputSearcher";
            this.InputSearcher.Size = new System.Drawing.Size(676, 19);
            this.InputSearcher.TabIndex = 167;
            this.InputSearcher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputSearcher.WordWrap = false;
            this.InputSearcher.TextChanged += new System.EventHandler(this.InputSearcher_TextChanged);
            // 
            // SearcherTheme
            // 
            this.SearcherTheme.BackColor = System.Drawing.Color.White;
            this.SearcherTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearcherTheme.Location = new System.Drawing.Point(141, 82);
            this.SearcherTheme.Name = "SearcherTheme";
            this.SearcherTheme.Size = new System.Drawing.Size(708, 43);
            this.SearcherTheme.TabIndex = 168;
            this.SearcherTheme.TabStop = false;
            this.SearcherTheme.Click += new System.EventHandler(this.SearcherTheme_Click);
            // 
            // ContactsTable
            // 
            this.ContactsTable.AllowUserToAddRows = false;
            this.ContactsTable.AllowUserToDeleteRows = false;
            this.ContactsTable.AllowUserToResizeColumns = false;
            this.ContactsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ContactsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ContactsTable.BackgroundColor = System.Drawing.Color.White;
            this.ContactsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ContactsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContactsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ContactsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.SecondName,
            this.Age,
            this.Sex,
            this.PostalCode,
            this.City,
            this.Street,
            this.HomeNumber});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ContactsTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.ContactsTable.EnableHeadersVisualStyles = false;
            this.ContactsTable.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ContactsTable.Location = new System.Drawing.Point(15, 131);
            this.ContactsTable.Name = "ContactsTable";
            this.ContactsTable.ReadOnly = true;
            this.ContactsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContactsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ContactsTable.RowHeadersVisible = false;
            this.ContactsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ContactsTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ContactsTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ContactsTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.ContactsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ContactsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContactsTable.RowTemplate.ReadOnly = true;
            this.ContactsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ContactsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContactsTable.Size = new System.Drawing.Size(960, 354);
            this.ContactsTable.TabIndex = 169;
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Imie";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 119;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Nazwisko";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 120;
            // 
            // Age
            // 
            this.Age.HeaderText = "Wiek";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 120;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Plec";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 120;
            // 
            // PostalCode
            // 
            this.PostalCode.HeaderText = "Poczta";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            this.PostalCode.Width = 120;
            // 
            // City
            // 
            this.City.HeaderText = "Miasto";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 120;
            // 
            // Street
            // 
            this.Street.HeaderText = "Ulica";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            this.Street.Width = 120;
            // 
            // HomeNumber
            // 
            this.HomeNumber.HeaderText = "Dom";
            this.HomeNumber.Name = "HomeNumber";
            this.HomeNumber.ReadOnly = true;
            this.HomeNumber.Width = 119;
            // 
            // NameTheme
            // 
            this.NameTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTheme.Location = new System.Drawing.Point(15, 131);
            this.NameTheme.Name = "NameTheme";
            this.NameTheme.Size = new System.Drawing.Size(121, 20);
            this.NameTheme.TabIndex = 172;
            this.NameTheme.TabStop = false;
            // 
            // SecondNameTheme
            // 
            this.SecondNameTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SecondNameTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondNameTheme.Location = new System.Drawing.Point(135, 131);
            this.SecondNameTheme.Name = "SecondNameTheme";
            this.SecondNameTheme.Size = new System.Drawing.Size(121, 20);
            this.SecondNameTheme.TabIndex = 173;
            this.SecondNameTheme.TabStop = false;
            // 
            // AgeTheme
            // 
            this.AgeTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AgeTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeTheme.Location = new System.Drawing.Point(255, 131);
            this.AgeTheme.Name = "AgeTheme";
            this.AgeTheme.Size = new System.Drawing.Size(121, 20);
            this.AgeTheme.TabIndex = 174;
            this.AgeTheme.TabStop = false;
            // 
            // SexTheme
            // 
            this.SexTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SexTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SexTheme.Location = new System.Drawing.Point(375, 131);
            this.SexTheme.Name = "SexTheme";
            this.SexTheme.Size = new System.Drawing.Size(121, 20);
            this.SexTheme.TabIndex = 175;
            this.SexTheme.TabStop = false;
            // 
            // PostalTheme
            // 
            this.PostalTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PostalTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostalTheme.Location = new System.Drawing.Point(495, 131);
            this.PostalTheme.Name = "PostalTheme";
            this.PostalTheme.Size = new System.Drawing.Size(121, 20);
            this.PostalTheme.TabIndex = 176;
            this.PostalTheme.TabStop = false;
            // 
            // CityTheme
            // 
            this.CityTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CityTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityTheme.Location = new System.Drawing.Point(615, 131);
            this.CityTheme.Name = "CityTheme";
            this.CityTheme.Size = new System.Drawing.Size(121, 20);
            this.CityTheme.TabIndex = 177;
            this.CityTheme.TabStop = false;
            // 
            // HomeNumberTheme
            // 
            this.HomeNumberTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HomeNumberTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeNumberTheme.Location = new System.Drawing.Point(735, 131);
            this.HomeNumberTheme.Name = "HomeNumberTheme";
            this.HomeNumberTheme.Size = new System.Drawing.Size(121, 20);
            this.HomeNumberTheme.TabIndex = 178;
            this.HomeNumberTheme.TabStop = false;
            // 
            // HomeNumerTheme
            // 
            this.HomeNumerTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HomeNumerTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeNumerTheme.Location = new System.Drawing.Point(855, 131);
            this.HomeNumerTheme.Name = "HomeNumerTheme";
            this.HomeNumerTheme.Size = new System.Drawing.Size(120, 20);
            this.HomeNumerTheme.TabIndex = 179;
            this.HomeNumerTheme.TabStop = false;
            // 
            // NameHeader
            // 
            this.NameHeader.AutoSize = true;
            this.NameHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameHeader.Location = new System.Drawing.Point(58, 133);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(35, 16);
            this.NameHeader.TabIndex = 180;
            this.NameHeader.Text = "IMIĘ";
            // 
            // SecondNameHeader
            // 
            this.SecondNameHeader.AutoSize = true;
            this.SecondNameHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecondNameHeader.Location = new System.Drawing.Point(157, 133);
            this.SecondNameHeader.Name = "SecondNameHeader";
            this.SecondNameHeader.Size = new System.Drawing.Size(77, 16);
            this.SecondNameHeader.TabIndex = 181;
            this.SecondNameHeader.Text = "NAZWISKO";
            // 
            // AgeHeader
            // 
            this.AgeHeader.AutoSize = true;
            this.AgeHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AgeHeader.Location = new System.Drawing.Point(296, 133);
            this.AgeHeader.Name = "AgeHeader";
            this.AgeHeader.Size = new System.Drawing.Size(39, 16);
            this.AgeHeader.TabIndex = 182;
            this.AgeHeader.Text = "WIEK";
            // 
            // SexHeader
            // 
            this.SexHeader.AutoSize = true;
            this.SexHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SexHeader.Location = new System.Drawing.Point(416, 133);
            this.SexHeader.Name = "SexHeader";
            this.SexHeader.Size = new System.Drawing.Size(38, 16);
            this.SexHeader.TabIndex = 183;
            this.SexHeader.Text = "PŁEĆ";
            // 
            // PostalHeader
            // 
            this.PostalHeader.AutoSize = true;
            this.PostalHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PostalHeader.Location = new System.Drawing.Point(499, 133);
            this.PostalHeader.Name = "PostalHeader";
            this.PostalHeader.Size = new System.Drawing.Size(112, 16);
            this.PostalHeader.TabIndex = 184;
            this.PostalHeader.Text = "KOD POCZTOWY";
            // 
            // CityHeader
            // 
            this.CityHeader.AutoSize = true;
            this.CityHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityHeader.Location = new System.Drawing.Point(646, 133);
            this.CityHeader.Name = "CityHeader";
            this.CityHeader.Size = new System.Drawing.Size(58, 16);
            this.CityHeader.TabIndex = 185;
            this.CityHeader.Text = "MIASTO";
            // 
            // StreetHeader
            // 
            this.StreetHeader.AutoSize = true;
            this.StreetHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StreetHeader.Location = new System.Drawing.Point(772, 133);
            this.StreetHeader.Name = "StreetHeader";
            this.StreetHeader.Size = new System.Drawing.Size(46, 16);
            this.StreetHeader.TabIndex = 186;
            this.StreetHeader.Text = "ULICA";
            // 
            // HomeNumberHeader
            // 
            this.HomeNumberHeader.AutoSize = true;
            this.HomeNumberHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeNumberHeader.Location = new System.Drawing.Point(867, 133);
            this.HomeNumberHeader.Name = "HomeNumberHeader";
            this.HomeNumberHeader.Size = new System.Drawing.Size(97, 16);
            this.HomeNumberHeader.TabIndex = 187;
            this.HomeNumberHeader.Text = "NUMER DOMU";
            // 
            // editTheme
            // 
            this.editTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editTheme.Location = new System.Drawing.Point(15, 491);
            this.editTheme.Name = "editTheme";
            this.editTheme.Size = new System.Drawing.Size(960, 28);
            this.editTheme.TabIndex = 188;
            this.editTheme.TabStop = false;
            // 
            // editHeader
            // 
            this.editHeader.AutoSize = true;
            this.editHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editHeader.Location = new System.Drawing.Point(385, 497);
            this.editHeader.Name = "editHeader";
            this.editHeader.Size = new System.Drawing.Size(220, 16);
            this.editHeader.TabIndex = 189;
            this.editHeader.Text = "ZARZĄDZANIE LISTĄ KONTAKTÓW";
            // 
            // deleteContact
            // 
            this.deleteContact.BackColor = System.Drawing.Color.DarkGray;
            this.deleteContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteContact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteContact.Location = new System.Drawing.Point(854, 82);
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(121, 43);
            this.deleteContact.TabIndex = 190;
            this.deleteContact.TabStop = false;
            this.deleteContact.Text = "USUŃ KONTAKT";
            this.deleteContact.UseVisualStyleBackColor = false;
            this.deleteContact.Click += new System.EventHandler(this.deleteContact_Click);
            // 
            // saveAll
            // 
            this.saveAll.BackColor = System.Drawing.Color.DarkGray;
            this.saveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveAll.Location = new System.Drawing.Point(740, 525);
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(235, 43);
            this.saveAll.TabIndex = 191;
            this.saveAll.TabStop = false;
            this.saveAll.Text = "ZAPISZ ZMIANY";
            this.saveAll.UseVisualStyleBackColor = false;
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // editContact
            // 
            this.editContact.BackColor = System.Drawing.Color.DarkGray;
            this.editContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editContact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editContact.Location = new System.Drawing.Point(258, 525);
            this.editContact.Name = "editContact";
            this.editContact.Size = new System.Drawing.Size(235, 43);
            this.editContact.TabIndex = 192;
            this.editContact.TabStop = false;
            this.editContact.Text = "EDYTUJ KONTAKT";
            this.editContact.UseVisualStyleBackColor = false;
            this.editContact.Click += new System.EventHandler(this.editContact_Click);
            // 
            // addContact
            // 
            this.addContact.BackColor = System.Drawing.Color.DarkGray;
            this.addContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addContact.Location = new System.Drawing.Point(15, 525);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(237, 43);
            this.addContact.TabIndex = 193;
            this.addContact.TabStop = false;
            this.addContact.Text = "DODAJ KONTAKT";
            this.addContact.UseVisualStyleBackColor = false;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // openFileWithContacts
            // 
            this.openFileWithContacts.BackColor = System.Drawing.Color.DarkGray;
            this.openFileWithContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileWithContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileWithContacts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openFileWithContacts.Location = new System.Drawing.Point(499, 525);
            this.openFileWithContacts.Name = "openFileWithContacts";
            this.openFileWithContacts.Size = new System.Drawing.Size(235, 43);
            this.openFileWithContacts.TabIndex = 194;
            this.openFileWithContacts.TabStop = false;
            this.openFileWithContacts.Text = "OTWÓRZ LOKACJĘ PLIKU";
            this.openFileWithContacts.UseVisualStyleBackColor = false;
            this.openFileWithContacts.Click += new System.EventHandler(this.sortContacts_Click);
            // 
            // backgroundTip
            // 
            this.backgroundTip.Location = new System.Drawing.Point(15, 435);
            this.backgroundTip.Name = "backgroundTip";
            this.backgroundTip.Size = new System.Drawing.Size(960, 50);
            this.backgroundTip.TabIndex = 195;
            this.backgroundTip.TabStop = false;
            // 
            // restartApplication
            // 
            this.restartApplication.BackColor = System.Drawing.Color.Black;
            this.restartApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartApplication.BackgroundImage")));
            this.restartApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.restartApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartApplication.FlatAppearance.BorderSize = 0;
            this.restartApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.restartApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restartApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restartApplication.ForeColor = System.Drawing.Color.White;
            this.restartApplication.Location = new System.Drawing.Point(886, 0);
            this.restartApplication.Name = "restartApplication";
            this.restartApplication.Size = new System.Drawing.Size(34, 34);
            this.restartApplication.TabIndex = 196;
            this.restartApplication.TabStop = false;
            this.restartApplication.Text = " ";
            this.restartApplication.UseVisualStyleBackColor = false;
            this.restartApplication.Click += new System.EventHandler(this.restartApplication_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(989, 592);
            this.Controls.Add(this.HomeNumberHeader);
            this.Controls.Add(this.StreetHeader);
            this.Controls.Add(this.CityHeader);
            this.Controls.Add(this.PostalHeader);
            this.Controls.Add(this.SexHeader);
            this.Controls.Add(this.AgeHeader);
            this.Controls.Add(this.SecondNameHeader);
            this.Controls.Add(this.NameHeader);
            this.Controls.Add(this.HomeNumerTheme);
            this.Controls.Add(this.HomeNumberTheme);
            this.Controls.Add(this.CityTheme);
            this.Controls.Add(this.PostalTheme);
            this.Controls.Add(this.SexTheme);
            this.Controls.Add(this.AgeTheme);
            this.Controls.Add(this.SecondNameTheme);
            this.Controls.Add(this.NameTheme);
            this.Controls.Add(this.ContactsTable);
            this.Controls.Add(this.backgroundTip);
            this.Controls.Add(this.openFileWithContacts);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.editContact);
            this.Controls.Add(this.saveAll);
            this.Controls.Add(this.deleteContact);
            this.Controls.Add(this.editHeader);
            this.Controls.Add(this.editTheme);
            this.Controls.Add(this.InputSearcher);
            this.Controls.Add(this.SearcherTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogoAPP);
            this.Controls.Add(this.HeaderTheme);
            this.Controls.Add(this.BacgroundTheme);
            this.Controls.Add(this.DownBelt);
            this.Controls.Add(this.UpBelt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Książka Adresowa";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.UpBelt.ResumeLayout(false);
            this.UpBelt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BacgroundTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearcherTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeNumberTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeNumerTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UpBelt;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel DownBelt;
        private System.Windows.Forms.PictureBox BacgroundTheme;
        private System.Windows.Forms.PictureBox HeaderTheme;
        private System.Windows.Forms.Label LogoAPP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputSearcher;
        private System.Windows.Forms.PictureBox SearcherTheme;
        public System.Windows.Forms.DataGridView ContactsTable;
        private System.Windows.Forms.PictureBox NameTheme;
        private System.Windows.Forms.PictureBox SecondNameTheme;
        private System.Windows.Forms.PictureBox AgeTheme;
        private System.Windows.Forms.PictureBox SexTheme;
        private System.Windows.Forms.PictureBox PostalTheme;
        private System.Windows.Forms.PictureBox CityTheme;
        private System.Windows.Forms.PictureBox HomeNumberTheme;
        private System.Windows.Forms.PictureBox HomeNumerTheme;
        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.Label SecondNameHeader;
        private System.Windows.Forms.Label AgeHeader;
        private System.Windows.Forms.Label SexHeader;
        private System.Windows.Forms.Label PostalHeader;
        private System.Windows.Forms.Label CityHeader;
        private System.Windows.Forms.Label StreetHeader;
        private System.Windows.Forms.Label HomeNumberHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeNumber;
        private System.Windows.Forms.PictureBox editTheme;
        private System.Windows.Forms.Label editHeader;
        private System.Windows.Forms.Button deleteContact;
        private System.Windows.Forms.Button saveAll;
        private System.Windows.Forms.Button editContact;
        private System.Windows.Forms.Button addContact;
        private System.Windows.Forms.Button openFileWithContacts;
        private System.Windows.Forms.ToolTip Navigate;
        private System.Windows.Forms.PictureBox backgroundTip;
        private System.Windows.Forms.Label DeveloperName;
        private System.Windows.Forms.Button restartApplication;
    }
}

