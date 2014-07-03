namespace PersonalLibrary
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LibraryTabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryTab = new System.Windows.Forms.TabPage();
            this.AddItemTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookRatingGroupBox = new System.Windows.Forms.GroupBox();
            this.BookRating10RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating9RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating8RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating7RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating6RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating5RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating4RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating3RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating2RadioButton = new System.Windows.Forms.RadioButton();
            this.BookRating1RadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BindingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BookPublisherImprintLabel = new System.Windows.Forms.Label();
            this.BookPublisherImprintComboBox = new System.Windows.Forms.ComboBox();
            this.BookPublisherLabel = new System.Windows.Forms.Label();
            this.BookPublisherComboBox = new System.Windows.Forms.ComboBox();
            this.ISBN10TextBox = new System.Windows.Forms.TextBox();
            this.ISBN10Label = new System.Windows.Forms.Label();
            this.ISBN13TextBox = new System.Windows.Forms.TextBox();
            this.ISBN13Label = new System.Windows.Forms.Label();
            this.BookCopyrightTextBox = new System.Windows.Forms.TextBox();
            this.BookCopyrightLabel = new System.Windows.Forms.Label();
            this.BookEditionTextBox = new System.Windows.Forms.TextBox();
            this.BookEditionLabel = new System.Windows.Forms.Label();
            this.BookTitleTextBox = new System.Windows.Forms.TextBox();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.AuthorGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthorDataGridView = new System.Windows.Forms.DataGridView();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.AddPeriodicalButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckOutTab = new System.Windows.Forms.TabPage();
            this.MaintenanceTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberOfBooksLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchByAuthorTextBox = new System.Windows.Forms.TextBox();
            this.SearchByTitleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchByISBNTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NumberOfPeriodicalsLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ResetSearchButton = new System.Windows.Forms.Button();
            this.LibraryTabControl.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.QueryTab.SuspendLayout();
            this.AddItemTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.BookRatingGroupBox.SuspendLayout();
            this.BookGroupBox.SuspendLayout();
            this.AuthorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.CheckOutTab.SuspendLayout();
            this.MaintenanceTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LibraryTabControl
            // 
            this.LibraryTabControl.Controls.Add(this.HomeTab);
            this.LibraryTabControl.Controls.Add(this.QueryTab);
            this.LibraryTabControl.Controls.Add(this.AddItemTab);
            this.LibraryTabControl.Controls.Add(this.CheckOutTab);
            this.LibraryTabControl.Controls.Add(this.MaintenanceTab);
            this.LibraryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryTabControl.Location = new System.Drawing.Point(0, 0);
            this.LibraryTabControl.Name = "LibraryTabControl";
            this.LibraryTabControl.SelectedIndex = 0;
            this.LibraryTabControl.Size = new System.Drawing.Size(1095, 699);
            this.LibraryTabControl.TabIndex = 0;
            this.LibraryTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.LibraryTabControl_Selected);
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.panel4);
            this.HomeTab.Controls.Add(this.panel1);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(1087, 673);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PersonalLibrary.Properties.Resources.library61;
            this.panel4.Controls.Add(this.EnterButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1081, 592);
            this.panel4.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(425, 223);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(222, 65);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1076, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Libary Project - CISE 5220 Part 3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QueryTab
            // 
            this.QueryTab.Controls.Add(this.panel8);
            this.QueryTab.Controls.Add(this.panel7);
            this.QueryTab.Location = new System.Drawing.Point(4, 22);
            this.QueryTab.Name = "QueryTab";
            this.QueryTab.Padding = new System.Windows.Forms.Padding(3);
            this.QueryTab.Size = new System.Drawing.Size(1087, 673);
            this.QueryTab.TabIndex = 1;
            this.QueryTab.Text = "Query";
            this.QueryTab.UseVisualStyleBackColor = true;
            // 
            // AddItemTab
            // 
            this.AddItemTab.Controls.Add(this.panel3);
            this.AddItemTab.Controls.Add(this.panel2);
            this.AddItemTab.Location = new System.Drawing.Point(4, 22);
            this.AddItemTab.Name = "AddItemTab";
            this.AddItemTab.Size = new System.Drawing.Size(1087, 673);
            this.AddItemTab.TabIndex = 2;
            this.AddItemTab.Text = "Add Item";
            this.AddItemTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.BookRatingGroupBox);
            this.panel3.Controls.Add(this.BookGroupBox);
            this.panel3.Controls.Add(this.AuthorGroupBox);
            this.panel3.Controls.Add(this.AddPeriodicalButton);
            this.panel3.Controls.Add(this.AddBookButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 617);
            this.panel3.TabIndex = 1;
            // 
            // BookRatingGroupBox
            // 
            this.BookRatingGroupBox.Controls.Add(this.BookRating10RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating9RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating8RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating7RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating6RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating5RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating4RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating3RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating2RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.BookRating1RadioButton);
            this.BookRatingGroupBox.Controls.Add(this.label4);
            this.BookRatingGroupBox.Controls.Add(this.label5);
            this.BookRatingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRatingGroupBox.Location = new System.Drawing.Point(88, 467);
            this.BookRatingGroupBox.Name = "BookRatingGroupBox";
            this.BookRatingGroupBox.Size = new System.Drawing.Size(872, 93);
            this.BookRatingGroupBox.TabIndex = 11;
            this.BookRatingGroupBox.TabStop = false;
            this.BookRatingGroupBox.Text = "Rating";
            // 
            // BookRating10RadioButton
            // 
            this.BookRating10RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating10RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating10RadioButton.Location = new System.Drawing.Point(684, 38);
            this.BookRating10RadioButton.Name = "BookRating10RadioButton";
            this.BookRating10RadioButton.Size = new System.Drawing.Size(27, 40);
            this.BookRating10RadioButton.TabIndex = 16;
            this.BookRating10RadioButton.TabStop = true;
            this.BookRating10RadioButton.Text = "10";
            this.BookRating10RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating10RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating9RadioButton
            // 
            this.BookRating9RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating9RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating9RadioButton.Location = new System.Drawing.Point(626, 38);
            this.BookRating9RadioButton.Name = "BookRating9RadioButton";
            this.BookRating9RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating9RadioButton.TabIndex = 15;
            this.BookRating9RadioButton.TabStop = true;
            this.BookRating9RadioButton.Text = "9";
            this.BookRating9RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating9RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating8RadioButton
            // 
            this.BookRating8RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating8RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating8RadioButton.Location = new System.Drawing.Point(568, 38);
            this.BookRating8RadioButton.Name = "BookRating8RadioButton";
            this.BookRating8RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating8RadioButton.TabIndex = 14;
            this.BookRating8RadioButton.TabStop = true;
            this.BookRating8RadioButton.Text = "8";
            this.BookRating8RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating8RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating7RadioButton
            // 
            this.BookRating7RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating7RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating7RadioButton.Location = new System.Drawing.Point(510, 38);
            this.BookRating7RadioButton.Name = "BookRating7RadioButton";
            this.BookRating7RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating7RadioButton.TabIndex = 13;
            this.BookRating7RadioButton.TabStop = true;
            this.BookRating7RadioButton.Text = "7";
            this.BookRating7RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating7RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating6RadioButton
            // 
            this.BookRating6RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating6RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating6RadioButton.Location = new System.Drawing.Point(452, 38);
            this.BookRating6RadioButton.Name = "BookRating6RadioButton";
            this.BookRating6RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating6RadioButton.TabIndex = 12;
            this.BookRating6RadioButton.TabStop = true;
            this.BookRating6RadioButton.Text = "6";
            this.BookRating6RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating6RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating5RadioButton
            // 
            this.BookRating5RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating5RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating5RadioButton.Location = new System.Drawing.Point(394, 38);
            this.BookRating5RadioButton.Name = "BookRating5RadioButton";
            this.BookRating5RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating5RadioButton.TabIndex = 11;
            this.BookRating5RadioButton.TabStop = true;
            this.BookRating5RadioButton.Text = "5";
            this.BookRating5RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating5RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating4RadioButton
            // 
            this.BookRating4RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating4RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating4RadioButton.Location = new System.Drawing.Point(336, 38);
            this.BookRating4RadioButton.Name = "BookRating4RadioButton";
            this.BookRating4RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating4RadioButton.TabIndex = 10;
            this.BookRating4RadioButton.TabStop = true;
            this.BookRating4RadioButton.Text = "4";
            this.BookRating4RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating4RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating3RadioButton
            // 
            this.BookRating3RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating3RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating3RadioButton.Location = new System.Drawing.Point(278, 38);
            this.BookRating3RadioButton.Name = "BookRating3RadioButton";
            this.BookRating3RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating3RadioButton.TabIndex = 9;
            this.BookRating3RadioButton.TabStop = true;
            this.BookRating3RadioButton.Text = "3";
            this.BookRating3RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating3RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating2RadioButton
            // 
            this.BookRating2RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating2RadioButton.Location = new System.Drawing.Point(220, 38);
            this.BookRating2RadioButton.Name = "BookRating2RadioButton";
            this.BookRating2RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating2RadioButton.TabIndex = 8;
            this.BookRating2RadioButton.TabStop = true;
            this.BookRating2RadioButton.Text = "2";
            this.BookRating2RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating2RadioButton.UseVisualStyleBackColor = true;
            // 
            // BookRating1RadioButton
            // 
            this.BookRating1RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookRating1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating1RadioButton.Location = new System.Drawing.Point(162, 38);
            this.BookRating1RadioButton.Name = "BookRating1RadioButton";
            this.BookRating1RadioButton.Size = new System.Drawing.Size(17, 40);
            this.BookRating1RadioButton.TabIndex = 7;
            this.BookRating1RadioButton.TabStop = true;
            this.BookRating1RadioButton.Text = "1";
            this.BookRating1RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookRating1RadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(683, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Best";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Worse";
            // 
            // BookGroupBox
            // 
            this.BookGroupBox.Controls.Add(this.label6);
            this.BookGroupBox.Controls.Add(this.BindingTypeComboBox);
            this.BookGroupBox.Controls.Add(this.BookPublisherImprintLabel);
            this.BookGroupBox.Controls.Add(this.BookPublisherImprintComboBox);
            this.BookGroupBox.Controls.Add(this.BookPublisherLabel);
            this.BookGroupBox.Controls.Add(this.BookPublisherComboBox);
            this.BookGroupBox.Controls.Add(this.ISBN10TextBox);
            this.BookGroupBox.Controls.Add(this.ISBN10Label);
            this.BookGroupBox.Controls.Add(this.ISBN13TextBox);
            this.BookGroupBox.Controls.Add(this.ISBN13Label);
            this.BookGroupBox.Controls.Add(this.BookCopyrightTextBox);
            this.BookGroupBox.Controls.Add(this.BookCopyrightLabel);
            this.BookGroupBox.Controls.Add(this.BookEditionTextBox);
            this.BookGroupBox.Controls.Add(this.BookEditionLabel);
            this.BookGroupBox.Controls.Add(this.BookTitleTextBox);
            this.BookGroupBox.Controls.Add(this.BookTitleLabel);
            this.BookGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookGroupBox.Location = new System.Drawing.Point(88, 240);
            this.BookGroupBox.Name = "BookGroupBox";
            this.BookGroupBox.Size = new System.Drawing.Size(872, 182);
            this.BookGroupBox.TabIndex = 10;
            this.BookGroupBox.TabStop = false;
            this.BookGroupBox.Text = "Book Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Binding";
            // 
            // BindingTypeComboBox
            // 
            this.BindingTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BindingTypeComboBox.FormattingEnabled = true;
            this.BindingTypeComboBox.Location = new System.Drawing.Point(90, 130);
            this.BindingTypeComboBox.Name = "BindingTypeComboBox";
            this.BindingTypeComboBox.Size = new System.Drawing.Size(198, 28);
            this.BindingTypeComboBox.TabIndex = 19;
            // 
            // BookPublisherImprintLabel
            // 
            this.BookPublisherImprintLabel.AutoSize = true;
            this.BookPublisherImprintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublisherImprintLabel.Location = new System.Drawing.Point(554, 130);
            this.BookPublisherImprintLabel.Name = "BookPublisherImprintLabel";
            this.BookPublisherImprintLabel.Size = new System.Drawing.Size(58, 20);
            this.BookPublisherImprintLabel.TabIndex = 18;
            this.BookPublisherImprintLabel.Text = "Imprint";
            // 
            // BookPublisherImprintComboBox
            // 
            this.BookPublisherImprintComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublisherImprintComboBox.FormattingEnabled = true;
            this.BookPublisherImprintComboBox.Location = new System.Drawing.Point(634, 130);
            this.BookPublisherImprintComboBox.Name = "BookPublisherImprintComboBox";
            this.BookPublisherImprintComboBox.Size = new System.Drawing.Size(209, 28);
            this.BookPublisherImprintComboBox.TabIndex = 17;
            // 
            // BookPublisherLabel
            // 
            this.BookPublisherLabel.AutoSize = true;
            this.BookPublisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublisherLabel.Location = new System.Drawing.Point(554, 88);
            this.BookPublisherLabel.Name = "BookPublisherLabel";
            this.BookPublisherLabel.Size = new System.Drawing.Size(74, 20);
            this.BookPublisherLabel.TabIndex = 16;
            this.BookPublisherLabel.Text = "Publisher";
            // 
            // BookPublisherComboBox
            // 
            this.BookPublisherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublisherComboBox.FormattingEnabled = true;
            this.BookPublisherComboBox.Location = new System.Drawing.Point(634, 88);
            this.BookPublisherComboBox.Name = "BookPublisherComboBox";
            this.BookPublisherComboBox.Size = new System.Drawing.Size(209, 28);
            this.BookPublisherComboBox.TabIndex = 15;
            this.BookPublisherComboBox.SelectedIndexChanged += new System.EventHandler(this.BookPublisherComboBox_SelectedIndexChanged);
            // 
            // ISBN10TextBox
            // 
            this.ISBN10TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN10TextBox.Location = new System.Drawing.Point(391, 124);
            this.ISBN10TextBox.Name = "ISBN10TextBox";
            this.ISBN10TextBox.Size = new System.Drawing.Size(143, 26);
            this.ISBN10TextBox.TabIndex = 14;
            this.ISBN10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ISBN10Label
            // 
            this.ISBN10Label.AutoSize = true;
            this.ISBN10Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN10Label.Location = new System.Drawing.Point(307, 130);
            this.ISBN10Label.Name = "ISBN10Label";
            this.ISBN10Label.Size = new System.Drawing.Size(79, 20);
            this.ISBN10Label.TabIndex = 13;
            this.ISBN10Label.Text = "ISBN (10)";
            // 
            // ISBN13TextBox
            // 
            this.ISBN13TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN13TextBox.Location = new System.Drawing.Point(391, 82);
            this.ISBN13TextBox.Name = "ISBN13TextBox";
            this.ISBN13TextBox.Size = new System.Drawing.Size(143, 26);
            this.ISBN13TextBox.TabIndex = 12;
            this.ISBN13TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ISBN13Label
            // 
            this.ISBN13Label.AutoSize = true;
            this.ISBN13Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN13Label.Location = new System.Drawing.Point(307, 88);
            this.ISBN13Label.Name = "ISBN13Label";
            this.ISBN13Label.Size = new System.Drawing.Size(79, 20);
            this.ISBN13Label.TabIndex = 11;
            this.ISBN13Label.Text = "ISBN (13)";
            // 
            // BookCopyrightTextBox
            // 
            this.BookCopyrightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCopyrightTextBox.Location = new System.Drawing.Point(231, 85);
            this.BookCopyrightTextBox.Name = "BookCopyrightTextBox";
            this.BookCopyrightTextBox.Size = new System.Drawing.Size(59, 26);
            this.BookCopyrightTextBox.TabIndex = 10;
            this.BookCopyrightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookCopyrightLabel
            // 
            this.BookCopyrightLabel.AutoSize = true;
            this.BookCopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCopyrightLabel.Location = new System.Drawing.Point(149, 88);
            this.BookCopyrightLabel.Name = "BookCopyrightLabel";
            this.BookCopyrightLabel.Size = new System.Drawing.Size(76, 20);
            this.BookCopyrightLabel.TabIndex = 9;
            this.BookCopyrightLabel.Text = "Copyright";
            // 
            // BookEditionTextBox
            // 
            this.BookEditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookEditionTextBox.Location = new System.Drawing.Point(90, 85);
            this.BookEditionTextBox.Name = "BookEditionTextBox";
            this.BookEditionTextBox.Size = new System.Drawing.Size(42, 26);
            this.BookEditionTextBox.TabIndex = 8;
            this.BookEditionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookEditionLabel
            // 
            this.BookEditionLabel.AutoSize = true;
            this.BookEditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookEditionLabel.Location = new System.Drawing.Point(27, 88);
            this.BookEditionLabel.Name = "BookEditionLabel";
            this.BookEditionLabel.Size = new System.Drawing.Size(58, 20);
            this.BookEditionLabel.TabIndex = 7;
            this.BookEditionLabel.Text = "Edition";
            // 
            // BookTitleTextBox
            // 
            this.BookTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitleTextBox.Location = new System.Drawing.Point(76, 35);
            this.BookTitleTextBox.Name = "BookTitleTextBox";
            this.BookTitleTextBox.Size = new System.Drawing.Size(767, 26);
            this.BookTitleTextBox.TabIndex = 6;
            // 
            // BookTitleLabel
            // 
            this.BookTitleLabel.AutoSize = true;
            this.BookTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitleLabel.Location = new System.Drawing.Point(22, 38);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(38, 20);
            this.BookTitleLabel.TabIndex = 5;
            this.BookTitleLabel.Text = "Title";
            // 
            // AuthorGroupBox
            // 
            this.AuthorGroupBox.Controls.Add(this.AuthorDataGridView);
            this.AuthorGroupBox.Controls.Add(this.AddAuthorButton);
            this.AuthorGroupBox.Controls.Add(this.LastNameTextBox);
            this.AuthorGroupBox.Controls.Add(this.LastNameLabel);
            this.AuthorGroupBox.Controls.Add(this.FirstNameTextBox);
            this.AuthorGroupBox.Controls.Add(this.FirstNameLabel);
            this.AuthorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorGroupBox.Location = new System.Drawing.Point(88, 90);
            this.AuthorGroupBox.Name = "AuthorGroupBox";
            this.AuthorGroupBox.Size = new System.Drawing.Size(872, 114);
            this.AuthorGroupBox.TabIndex = 4;
            this.AuthorGroupBox.TabStop = false;
            this.AuthorGroupBox.Text = "Author Information";
            // 
            // AuthorDataGridView
            // 
            this.AuthorDataGridView.AllowUserToAddRows = false;
            this.AuthorDataGridView.AllowUserToOrderColumns = true;
            this.AuthorDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorDataGridView.ColumnHeadersVisible = false;
            this.AuthorDataGridView.Location = new System.Drawing.Point(445, 21);
            this.AuthorDataGridView.Name = "AuthorDataGridView";
            this.AuthorDataGridView.RowHeadersVisible = false;
            this.AuthorDataGridView.Size = new System.Drawing.Size(240, 78);
            this.AuthorDataGridView.TabIndex = 9;
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAuthorButton.Location = new System.Drawing.Point(710, 41);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(133, 39);
            this.AddAuthorButton.TabIndex = 5;
            this.AddAuthorButton.Text = "Add Author";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(133, 64);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(287, 26);
            this.LastNameTextBox.TabIndex = 8;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(22, 67);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(133, 32);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(287, 26);
            this.FirstNameTextBox.TabIndex = 6;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(22, 35);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name";
            // 
            // AddPeriodicalButton
            // 
            this.AddPeriodicalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPeriodicalButton.Location = new System.Drawing.Point(582, 25);
            this.AddPeriodicalButton.Name = "AddPeriodicalButton";
            this.AddPeriodicalButton.Size = new System.Drawing.Size(133, 39);
            this.AddPeriodicalButton.TabIndex = 1;
            this.AddPeriodicalButton.Text = "Add Periodical";
            this.AddPeriodicalButton.UseVisualStyleBackColor = true;
            this.AddPeriodicalButton.Click += new System.EventHandler(this.AddPeriodicalButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookButton.Location = new System.Drawing.Point(371, 25);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(133, 39);
            this.AddBookButton.TabIndex = 0;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 56);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1087, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add a Book or Periodical to the Library";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckOutTab
            // 
            this.CheckOutTab.Controls.Add(this.panel6);
            this.CheckOutTab.Location = new System.Drawing.Point(4, 22);
            this.CheckOutTab.Name = "CheckOutTab";
            this.CheckOutTab.Padding = new System.Windows.Forms.Padding(3);
            this.CheckOutTab.Size = new System.Drawing.Size(1087, 673);
            this.CheckOutTab.TabIndex = 3;
            this.CheckOutTab.Text = "Check Out";
            this.CheckOutTab.UseVisualStyleBackColor = true;
            // 
            // MaintenanceTab
            // 
            this.MaintenanceTab.Controls.Add(this.panel5);
            this.MaintenanceTab.Location = new System.Drawing.Point(4, 22);
            this.MaintenanceTab.Name = "MaintenanceTab";
            this.MaintenanceTab.Size = new System.Drawing.Size(1087, 673);
            this.MaintenanceTab.TabIndex = 4;
            this.MaintenanceTab.Text = "Maintenance";
            this.MaintenanceTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1087, 673);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1071, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Methods on this tab will provide for database maintenance.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1081, 667);
            this.panel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1071, 42);
            this.label7.TabIndex = 1;
            this.label7.Text = "Methods on this tab will allow a patron to check out an item from the library.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1081, 56);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel8.Controls.Add(this.ResetSearchButton);
            this.panel8.Controls.Add(this.NumberOfPeriodicalsLabel);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.SearchButton);
            this.panel8.Controls.Add(this.SearchByISBNTextBox);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.SearchByTitleTextBox);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.SearchByAuthorTextBox);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.NumberOfBooksLabel);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.SearchResultsDataGridView);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 59);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1081, 611);
            this.panel8.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1081, 56);
            this.label8.TabIndex = 1;
            this.label8.Text = "Find a Book or Periodical in the Library";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchResultsDataGridView
            // 
            this.SearchResultsDataGridView.AllowUserToAddRows = false;
            this.SearchResultsDataGridView.AllowUserToDeleteRows = false;
            this.SearchResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchResultsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SearchResultsDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.SearchResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultsDataGridView.Location = new System.Drawing.Point(33, 162);
            this.SearchResultsDataGridView.Name = "SearchResultsDataGridView";
            this.SearchResultsDataGridView.ReadOnly = true;
            this.SearchResultsDataGridView.Size = new System.Drawing.Size(1016, 393);
            this.SearchResultsDataGridView.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 586);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Number of Books in Library:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberOfBooksLabel
            // 
            this.NumberOfBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfBooksLabel.Location = new System.Drawing.Point(211, 586);
            this.NumberOfBooksLabel.Name = "NumberOfBooksLabel";
            this.NumberOfBooksLabel.Size = new System.Drawing.Size(88, 23);
            this.NumberOfBooksLabel.TabIndex = 2;
            this.NumberOfBooksLabel.Text = "999999";
            this.NumberOfBooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Search by Author";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchByAuthorTextBox
            // 
            this.SearchByAuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByAuthorTextBox.Location = new System.Drawing.Point(303, 33);
            this.SearchByAuthorTextBox.Name = "SearchByAuthorTextBox";
            this.SearchByAuthorTextBox.Size = new System.Drawing.Size(448, 26);
            this.SearchByAuthorTextBox.TabIndex = 4;
            // 
            // SearchByTitleTextBox
            // 
            this.SearchByTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByTitleTextBox.Location = new System.Drawing.Point(303, 65);
            this.SearchByTitleTextBox.Name = "SearchByTitleTextBox";
            this.SearchByTitleTextBox.Size = new System.Drawing.Size(448, 26);
            this.SearchByTitleTextBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(163, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Search by Title";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchByISBNTextBox
            // 
            this.SearchByISBNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByISBNTextBox.Location = new System.Drawing.Point(303, 98);
            this.SearchByISBNTextBox.Name = "SearchByISBNTextBox";
            this.SearchByISBNTextBox.Size = new System.Drawing.Size(448, 26);
            this.SearchByISBNTextBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(163, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "Search by ISBN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(812, 25);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(113, 43);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NumberOfPeriodicalsLabel
            // 
            this.NumberOfPeriodicalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPeriodicalsLabel.Location = new System.Drawing.Point(988, 586);
            this.NumberOfPeriodicalsLabel.Name = "NumberOfPeriodicalsLabel";
            this.NumberOfPeriodicalsLabel.Size = new System.Drawing.Size(88, 23);
            this.NumberOfPeriodicalsLabel.TabIndex = 11;
            this.NumberOfPeriodicalsLabel.Text = "999999";
            this.NumberOfPeriodicalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(753, 586);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 23);
            this.label14.TabIndex = 10;
            this.label14.Text = "Number of Periodicals in Library:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResetSearchButton
            // 
            this.ResetSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSearchButton.Location = new System.Drawing.Point(812, 88);
            this.ResetSearchButton.Name = "ResetSearchButton";
            this.ResetSearchButton.Size = new System.Drawing.Size(113, 43);
            this.ResetSearchButton.TabIndex = 12;
            this.ResetSearchButton.Text = "Reset";
            this.ResetSearchButton.UseVisualStyleBackColor = true;
            this.ResetSearchButton.Click += new System.EventHandler(this.ResetSearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 699);
            this.Controls.Add(this.LibraryTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LibraryTabControl.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.QueryTab.ResumeLayout(false);
            this.AddItemTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.BookRatingGroupBox.ResumeLayout(false);
            this.BookRatingGroupBox.PerformLayout();
            this.BookGroupBox.ResumeLayout(false);
            this.BookGroupBox.PerformLayout();
            this.AuthorGroupBox.ResumeLayout(false);
            this.AuthorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.CheckOutTab.ResumeLayout(false);
            this.MaintenanceTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LibraryTabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage QueryTab;
        private System.Windows.Forms.TabPage AddItemTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddPeriodicalButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox AuthorGroupBox;
        private System.Windows.Forms.DataGridView AuthorDataGridView;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.GroupBox BookGroupBox;
        private System.Windows.Forms.TextBox BookTitleTextBox;
        private System.Windows.Forms.Label BookTitleLabel;
        private System.Windows.Forms.GroupBox BookRatingGroupBox;
        private System.Windows.Forms.RadioButton BookRating10RadioButton;
        private System.Windows.Forms.RadioButton BookRating9RadioButton;
        private System.Windows.Forms.RadioButton BookRating8RadioButton;
        private System.Windows.Forms.RadioButton BookRating7RadioButton;
        private System.Windows.Forms.RadioButton BookRating6RadioButton;
        private System.Windows.Forms.RadioButton BookRating5RadioButton;
        private System.Windows.Forms.RadioButton BookRating4RadioButton;
        private System.Windows.Forms.RadioButton BookRating3RadioButton;
        private System.Windows.Forms.RadioButton BookRating2RadioButton;
        private System.Windows.Forms.RadioButton BookRating1RadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BookEditionTextBox;
        private System.Windows.Forms.Label BookEditionLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BindingTypeComboBox;
        private System.Windows.Forms.Label BookPublisherImprintLabel;
        private System.Windows.Forms.ComboBox BookPublisherImprintComboBox;
        private System.Windows.Forms.Label BookPublisherLabel;
        private System.Windows.Forms.ComboBox BookPublisherComboBox;
        private System.Windows.Forms.TextBox ISBN10TextBox;
        private System.Windows.Forms.Label ISBN10Label;
        private System.Windows.Forms.TextBox ISBN13TextBox;
        private System.Windows.Forms.Label ISBN13Label;
        private System.Windows.Forms.TextBox BookCopyrightTextBox;
        private System.Windows.Forms.Label BookCopyrightLabel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TabPage CheckOutTab;
        private System.Windows.Forms.TabPage MaintenanceTab;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label NumberOfPeriodicalsLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchByISBNTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SearchByTitleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SearchByAuthorTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label NumberOfBooksLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView SearchResultsDataGridView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetSearchButton;
    }
}