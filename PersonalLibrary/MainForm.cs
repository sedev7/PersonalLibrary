/*
 * CISE 5220 - Part 3 Project - Personal Library
 * Team Members:
 *   Ali Aldarraji
 *   James A. Savage
 * Date: April 28, 2014
 * 
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PersonalLibrary.DataAccess;

namespace PersonalLibrary
{
    public partial class MainForm : Form
    {
        #region Variables
        BindingList<Author> _Authors = new BindingList<Author>();
        Publisher _Publisher = new Publisher();
        //ControlCollection _Ratings = null;
        List<Control> _Ratings = new List<Control>();

        bool _AddBookFormLoading = false;

        #endregion

        #region Events
        private void EnterButton_Click(object sender, EventArgs e)
        {
            LibraryTabControl.SelectTab("QueryTab");
        }
        private void MainForm_Load(object sender, EventArgs e)
        {   }
        private void LibraryTabControl_Selected(object sender, TabControlEventArgs e)
        {
            // Configure the initial tab page controls and layout for each tab
            switch (LibraryTabControl.SelectedTab.Name)
            {
                case "AddItemTab":
                    DisableAddBookControls();

                    // Future development - add periodicals
                    AddPeriodicalButton.Enabled = false;
                    break;
                case "QueryTab":
                    SearchResultsDataGridView.Visible = false;
                    NumberOfBooksLabel.Text = GetBookCount().ToString();
                    NumberOfPeriodicalsLabel.Text = GetPeriodicalCount().ToString();
                    SearchByAuthorTextBox.Focus();
                    break;
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            if(AddBookButton.Text == "Add Book")
            {
                AddBookButton.Text = "Cancel";
                AddPeriodicalButton.Enabled = true;
                AddPeriodicalButton.Text = "Update";

                // Enter new book information
                _AddBookFormLoading = true;
                EnableAddBookControls();
                LoadPublishers();
                BookPublisherComboBox.SelectedIndex = 0;
                LoadPublisherImprints();
                BookPublisherImprintComboBox.Enabled = false;
                LoadBindingTypes();
                _AddBookFormLoading = false;
                BookPublisherComboBox.SelectedIndex = BookPublisherComboBox.FindString("None");
                LoadRatingsControls();
            }
            else
            {
                // User is cancelling book insert
                AddPeriodicalButton.Text = "Add Periodical";
                AddPeriodicalButton.Enabled = false;
                ClearAddBookControls();
                AddBookButton.Text = "Add Book";
            }
        }

        private void AddPeriodicalButton_Click(object sender, EventArgs e)
        {
            if (AddPeriodicalButton.Text == "Update")
            {
                // Insert new book in database

                // (1) Collect the book information

                // Check to be sure required data was entered
                ValidateBookData();
                // Create a new book object to hold the new book data
                Book newBook = new Book();
                // Not doing data validation - assume data entered is valid!
                newBook.Title = BookTitleTextBox.Text.Trim();
                newBook.Edition = Convert.ToInt32(BookEditionTextBox.Text.Trim());
                newBook.Copyright = Convert.ToInt32(BookCopyrightTextBox.Text.Trim());
                newBook.ISBN13 = ISBN13TextBox.Text.Trim();
                newBook.ISBN10 = ISBN10TextBox.Text.Trim();
                try
                {
                    newBook.BindingTypeId = DataAccess.DataAccess.GetBookBindingTypeId(BindingTypeComboBox.Items[BindingTypeComboBox.SelectedIndex].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting Binding Type Id: " + ex.Message, "Get BindingTypeId");
                }

                newBook.Publisher = _Publisher;
                if (BookPublisherImprintComboBox.Enabled == true && BookPublisherImprintComboBox.SelectedIndex != BookPublisherImprintComboBox.FindString("None"))
                {
                    try
                    {
                        newBook.PublisherImprintId = DataAccess.DataAccess.GetPublisherImprintId(BookPublisherImprintComboBox.SelectedItem.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error getting Publisher Imprint Id: " + ex.Message, "Get PublisherImprintId");
                    }
                }
                else
                {
                    try
                    {
                        newBook.PublisherImprintId = DataAccess.DataAccess.GetPublisherImprintId("None");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error getting Publisher Imprint Id: " + ex.Message, "Get PublisherImprintId");
                    }
                }
                newBook.Rating = GetRating();

                // Collect the author information
                if (_Authors.Count == 0)
                {
                    // Only one author entered
                    // Get the author's information
                    Author newAuthor = new Author(FirstNameTextBox.Text, LastNameTextBox.Text);

                    // Add the new author to the database and return the AuthorId
                    newAuthor.AuthorId = DataAccess.DataAccess.InsertAuthor(newAuthor);

                    // Keep a list of authors for this book
                    _Authors.Add(newAuthor);
                }
                else if (LastNameTextBox.Text != "")
                {
                    // There are multiple authors - add the current author to the Authors list
                    Author newAuthor = new Author(FirstNameTextBox.Text, LastNameTextBox.Text);

                    // Add the new author to the database and return the AuthorId
                    newAuthor.AuthorId = DataAccess.DataAccess.InsertAuthor(newAuthor);

                    // Keep a list of authors for this book
                    _Authors.Add(newAuthor);
                }
                else
                {
                    // All of the authors were entered in the data grid view - nothing to collect
                    // from first name and last name textboxes
                }

                bool proceed = true;

                // (2) Add the a resource type and resource for this book to the database
                Resource resource = new Resource();
                // Using today's date for acquisiton date - future development will separate into add resource method
                resource.AcquisitionDate = DateTime.Now.ToShortDateString();
                resource.ResourceNotes = "Adding book from AddItems tab";
                resource.ResourceTypeDescription = "Book";
                if (proceed)
                {
                    try
                    {
                        resource.ResourceTypeId = DataAccess.DataAccess.GetResourceTypeId(resource.ResourceTypeDescription);
                        if (resource.ResourceTypeId == 0)
                        {
                            proceed = false;
                            MessageBox.Show("Error adding Resource Type - resource was not added!", "Add Resource Type");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error getting Resource Type Id: " + ex.Message, "Get ResourceTypeId");
                        proceed = false;
                    }
                }
                if (proceed)
                {
                    try
                    {
                        resource.ResourceId = DataAccess.DataAccess.InsertResource(resource);

                        if (resource.ResourceTypeId == 0)
                        {
                            proceed = false;
                            MessageBox.Show("Error adding Resource - resource was not added!", "Add Resource");
                        }
                        else
                        {
                            // Add the resourcId to the new book record
                            newBook.ResourceId = resource.ResourceId;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error getting Resource Id: " + ex.Message, "Get ResourceId");
                        proceed = false;
                    }
                }

                // (3) Add the book to the database
                if (proceed)
                {
                    try
                    {
                        newBook.BookId = DataAccess.DataAccess.InsertNewBook(newBook);
                        if (newBook.BookId == 0)
                        {
                            // There was a problem adding the book to the database
                            proceed = false;
                            MessageBox.Show("Error adding book database - book was not added!", "Add New Book");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding new book to database : " + ex.Message, "Add New Book");
                        proceed = false;
                    }
                }

                // (4) Add the book and authors to the AuthorsBooks table
                if (proceed)
                {
                    foreach (Author author in _Authors)
                    {
                        try
                        {
                            int success = DataAccess.DataAccess.InsertAuthorsBooks(newBook.BookId, author.AuthorId);
                            if (success == 0)
                            {
                                proceed = false;
                                MessageBox.Show("Error entering author [" + author.FirstName + " " + author.LastName + "] for this book - \r\nAuthor was not added!", "Add Book's Authors");
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error adding author for new book to database : " + ex.Message, "Add Book's Authors");
                            proceed = false;
                        }
                    }
                }

                // (5) Display a success or fail message
                if (proceed)
                {
                    //  If we made it this far then the book and authors have been successfully added to the database
                    MessageBox.Show("New book successfully added to database!", "Add New Book");
                }
                // (6) Reset the controls
                AddPeriodicalButton.Text = "Add Periodical";
                AddPeriodicalButton.Enabled = false;
                ClearAddBookControls();
                AddBookButton.Text = "Add Book";
            }
        }

        private void BookPublisherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show the Publisher Imprints if we are not adding a publisher or selecting 'None' for publisher
            if (BookPublisherComboBox.SelectedIndex != 0 && BookPublisherComboBox.SelectedIndex != BookPublisherComboBox.FindString("None"))
            {
                BookPublisherImprintComboBox.Enabled = true;
                BookPublisherImprintComboBox.SelectedIndex = BookPublisherImprintComboBox.FindString("None");
            }
            else
            {
                BookPublisherImprintComboBox.Enabled = false;
            }

            // Add a new publisher
            if(!_AddBookFormLoading && BookPublisherComboBox.SelectedIndex == BookPublisherComboBox.FindString("Add Publisher"))
            {
                DisableAddPublisherControls();
                // Using a delegate to retrieve the publisher information from the AddPublisher form
                Publisher newPublisher = new Publisher();
                AddPublisherForm ap = new AddPublisherForm();
                ap.returnPublisher = new AddPublisherForm.ReturnPublisher(GetNewPublisher);
                ap.Show();
            }
            else
            {
                // We are just selecting a publisher from the list
                try
                {
                    _Publisher = DataAccess.DataAccess.GetPublisher(BookPublisherComboBox.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding publisher to database!", "Add Publisher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GetNewPublisher(object sender)
        {
            _Publisher = (Publisher)sender;

            // Reload the Publishers combo box and set the selected publisher to the publisher that was just added
            LoadPublishers();
            BookPublisherComboBox.SelectedIndex = BookPublisherComboBox.FindString(_Publisher.PublisherName);
            EnableAddPublisherControls();
        }
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disable the Add Author button if no author is entered
            if (FirstNameTextBox.Text != "" && AddAuthorButton.Enabled == false)
            {
                AddAuthorButton.Enabled = true;
            }
            //else
            //{
            //    AddAuthorButton.Enabled = false;
            //}
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disable the Add Author button if no author is entered
            if (LastNameTextBox.Text != "" && AddAuthorButton.Enabled == false)
            {
                AddAuthorButton.Enabled = true;
            }
            //else
            //{
            //    AddAuthorButton.Enabled = false;
            //}
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            // Assume data is valid - no validation being done here!
            // Add the author to the database
            // Get the AuthorId for each author entered
            // Keep a list of entered authors so they can be linked to the book
            // Display any authors already entered in the datagrid

            // Get the author's information
            Author newAuthor = new Author(FirstNameTextBox.Text, LastNameTextBox.Text);

            // Add the new author to the database and return the AuthorId
            newAuthor.AuthorId = DataAccess.DataAccess.InsertAuthor(newAuthor);

            // Keep a list of authors for this book
            _Authors.Add(newAuthor);

            // Add the authors to the data grid
            AuthorDataGridView.Visible = true;
            if (AuthorDataGridView.DataSource != null)
            {
                // Clear out the data grid if it has data
                AuthorDataGridView.DataSource = null;
                //AuthorDataGridView.Items.Clear();
            }
            else
            {
                // Format the data grid
                AuthorDataGridView.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            }
            AuthorDataGridView.AutoGenerateColumns = true;
            AuthorDataGridView.DataSource = _Authors;
            AuthorDataGridView.Columns["AuthorId"].Visible = false;
            AuthorDataGridView.Columns["FirstName"].Width = 103;
            AuthorDataGridView.Columns["LastName"].Width = 135;

            // Reset the Author controls
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AddAuthorButton.Enabled = false;
        }
        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            SearchResultsDataGridView.DataSource = null;
            SearchResultsDataGridView.Rows.Clear();
            SearchResultsDataGridView.Visible = false;
            SearchByAuthorTextBox.Text = "";
            SearchByTitleTextBox.Text = "";
            SearchByISBNTextBox.Text = "";
        }
        #endregion

        #region Methods
        public MainForm()
        {
            InitializeComponent();
        }
        private void ClearAddBookControls()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AuthorDataGridView.DataSource = null;
            AuthorDataGridView.Visible = false;
            AddAuthorButton.Enabled = false;
            BookTitleTextBox.Text = "";
            BookEditionTextBox.Text = "";
            BookCopyrightTextBox.Text = "";
            ISBN13TextBox.Text = "";
            ISBN10TextBox.Text = "";
            BindingTypeComboBox.SelectedIndex = BindingTypeComboBox.FindString("None");
            BookPublisherComboBox.SelectedIndex = BookPublisherComboBox.FindString("None");
            BookPublisherImprintComboBox.SelectedIndex = BookPublisherImprintComboBox.FindString("None");
            ClearRatings();
        }
        private void ClearRatings()
        {
            // Find any ratings radio buttons that are checked and uncheck them
            foreach (RadioButton rb in _Ratings)
            {
                if (rb.Checked == true)
                {
                    rb.Checked = false;
                }
            }
        }
        private int GetRating()
        {
            int rating = 0;
            string rbAttribute = string.Empty;

            foreach (RadioButton rb in _Ratings)
            {
                if(rb.Checked == true)
                {
                    rbAttribute = rb.Name;
                    break;
                }
            }

            // Parse the name to get the rating
            if (rbAttribute != "")
            {
                rating = rbAttribute.Trim().Length > 22 ? Convert.ToInt32(rbAttribute.Substring(10, 2)) : rating = Convert.ToInt32(rbAttribute.Substring(10, 1));
            }
            return rating;
        }
        private void DisableAddBookControls()
        {
            BookGroupBox.Visible = false;
            AuthorGroupBox.Visible = false;
            BookRatingGroupBox.Visible = false;
        }

        private void EnableAddBookControls()
        {
            BookGroupBox.Visible = true;
            AuthorGroupBox.Visible = true;
            BookRatingGroupBox.Visible = true;
            AuthorDataGridView.Visible = false;
            AddAuthorButton.Enabled = false;
            BookPublisherImprintComboBox.Enabled = false;
        }

        private void DisableAddPublisherControls()
        {
            BookPublisherComboBox.Enabled = false;
        }
        private void EnableAddPublisherControls()
        {
            BookPublisherComboBox.Enabled = true;
        }
        private void LoadBindingTypes()
        {
            try
            {
                BindingList<string> bindingTypes = new BindingList<string>();
                bindingTypes = DataAccess.DataAccess.GetBookBindingTypes();
                BindingTypeComboBox.DataSource = bindingTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading binding types: " + ex.Message, "Load Book Binding Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPublishers()
        {
            try
            {
                // Clear out any existing data
                BookPublisherComboBox.DataSource = null;
                BookPublisherComboBox.Items.Clear();

                // Load publisher data
                BindingList<string> publishers = new BindingList<string>();
                publishers = DataAccess.DataAccess.GetPublishers();
                //BookPublisherComboBox.DataSource = publishers;
                BookPublisherComboBox.Items.Add("Add Publisher");
                foreach (string pub in publishers)
                {
                    BookPublisherComboBox.Items.Add(pub);
                }
                //BookPublisherComboBox.SelectedIndex = BookPublisherComboBox.FindString("None");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading publishers: " + ex.Message, "Load Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPublisherImprints()
        {
            try
            {
                BindingList<string> imprints = new BindingList<string>();
                imprints = DataAccess.DataAccess.GetPublisherImprints();
                //BookPublisherImprintComboBox.DataSource = imprints;
                BookPublisherImprintComboBox.Items.Add("Add Imprint");
                foreach (string imp in imprints)
                {
                    BookPublisherImprintComboBox.Items.Add(imp);
                }
                BookPublisherImprintComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading publisher imprints: " + ex.Message, "Load Publisher Imprints", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetBookCount()
        {
            int count = 0;

            try
            {
                count = DataAccess.DataAccess.GetBookCount();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting book count: " + ex.Message, "Get Book Count", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private int GetPeriodicalCount()
        {
            int count = 0;

            try
            {
                count = DataAccess.DataAccess.GetPeriodicalCount();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting periodical count: " + ex.Message, "Get Periodical Count", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void LoadRatingsControls()
        {
            // Clear out the list 
            if(_Ratings.Count > 0)
            {
                _Ratings.Clear();
            }

            _Ratings.Add(BookRating1RadioButton);
            _Ratings.Add(BookRating2RadioButton);
            _Ratings.Add(BookRating3RadioButton);
            _Ratings.Add(BookRating4RadioButton);
            _Ratings.Add(BookRating5RadioButton);
            _Ratings.Add(BookRating6RadioButton);
            _Ratings.Add(BookRating7RadioButton);
            _Ratings.Add(BookRating8RadioButton);
            _Ratings.Add(BookRating9RadioButton);
            _Ratings.Add(BookRating10RadioButton);

            // Clear out any existing ratings
            ClearRatings();
        }
        private void  ValidateBookData()
        {
            // Check required data to be sure something was entered
            if(_Authors.Count == 0 && LastNameTextBox.Text == "")
            {
                MessageBox.Show("Author first name and last name is required!", "Author", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(BookTitleTextBox.Text == "")
            {
                MessageBox.Show("Book title is required!", "Book Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(BookEditionTextBox.Text == "")
            {
                MessageBox.Show("Book edition is required!", "Book Edition", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(BookCopyrightTextBox.Text == "")
            {
                MessageBox.Show("Book copyright is required!", "Book Copyright", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(_Publisher.PublisherId == 0 || BookPublisherComboBox.SelectedItem.ToString() == "None")
            {
                MessageBox.Show("No publisher selected! (Publisher is not required)", "Book Publisher", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            // Validate data entered - future development
        }
        #endregion

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string author = string.Empty;
            string title = string.Empty;
            string isbn = string.Empty;
            string sqlQuery = string.Empty;
            bool IsSearchable = false;

            // Check for search by author
            if (SearchByAuthorTextBox.Text != "")
            {
                // Get the author's name
                // Not validating data here - assume valid data was entered!
                author = SearchByAuthorTextBox.Text.Trim();
                IsSearchable = true;
            }

            // Check for search by title
            if (SearchByTitleTextBox.Text != "")
            {
                // Get the title
                // Not validating data here - assume valid data was entered!
                title = SearchByTitleTextBox.Text.Trim();
                IsSearchable = true;
            }

            // Check for search by ISBN
            if (SearchByISBNTextBox.Text != "")
            {
                // Get the ISBN
                // Not validating data here - assume valid data was entered!
                isbn = SearchByISBNTextBox.Text.Trim();
                IsSearchable = true;
            }

            if (IsSearchable)
            {

                // Create the SQL search query
                if (author.Length > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sqlQuery = sb.AppendFormat("SELECT a.FirstName, a.LastName, b.Title, p.PublisherAbbreviation, bt.BindingType from Authors a join AuthorsBooks au on a.AuthorId = au.AuthorId join Books b on b.BookId = au.BookId join Publishers p on p.PublisherId = b.PublisherId join BindingType bt on bt.BindingTypeId = b.BindingTypeId WHERE (a.FirstName like '%{0}%' OR a.LastName like '%{0}%');", author).ToString();

                    if (title.Length > 0)
                    {
                        StringBuilder sbt = new StringBuilder();
                        sqlQuery = sbt.AppendFormat("SELECT a.FirstName, a.LastName, b.Title, p.PublisherAbbreviation, bt.BindingType from Authors a join AuthorsBooks au on a.AuthorId = au.AuthorId join Books b on b.BookId = au.BookId join Publishers p on p.PublisherId = b.PublisherId join BindingType bt on bt.BindingTypeId = b.BindingTypeId WHERE (a.FirstName like '%{0}%' OR a.LastName like '%{0}%') AND b.Title like '%{1}%';", author, title).ToString();

                        if (isbn.Length > 0)
                        {
                            StringBuilder sbti = new StringBuilder();
                            sqlQuery = sbti.AppendFormat("SELECT a.FirstName, a.LastName, b.Title, p.PublisherAbbreviation, bt.BindingType from Authors a join AuthorsBooks au on a.AuthorId = au.AuthorId join Books b on b.BookId = au.BookId join Publishers p on p.PublisherId = b.PublisherId join BindingType bt on bt.BindingTypeId = b.BindingTypeId WHERE (a.FirstName like '%{0}%' OR a.LastName like '%{0}%') AND b.Title like '%{1}%' and (b.[ISBN-13] like '%{2}%' OR b.[ISBN-10] like '%{2}%');", author, title, isbn).ToString();
                        }
                    }
                }
                else if(title.Length > 0)
                {
                    StringBuilder sbt = new StringBuilder();
                    sqlQuery = sbt.AppendFormat("SELECT a.FirstName, a.LastName, b.Title, p.PublisherAbbreviation, bt.BindingType from Authors a join AuthorsBooks au on a.AuthorId = au.AuthorId join Books b on b.BookId = au.BookId join Publishers p on p.PublisherId = b.PublisherId join BindingType bt on bt.BindingTypeId = b.BindingTypeId WHERE b.Title like '%{0}%';", title).ToString();

                    if (isbn.Length > 0)
                    {
                        StringBuilder sbti = new StringBuilder();
                        sqlQuery = sbti.AppendFormat("SELECT a.FirstName, a.LastName, b.Title, p.PublisherAbbreviation, bt.BindingType from Authors a join AuthorsBooks au on a.AuthorId = au.AuthorId join Books b on b.BookId = au.BookId join Publishers p on p.PublisherId = b.PublisherId join BindingType bt on bt.BindingTypeId = b.BindingTypeId WHERE b.Title like '%{0}%' and (b.[ISBN-13] like '%{1}%' OR b.[ISBN-10] like '%{1}%');", title, isbn).ToString();
                    }
                }
                else
                {
                    // Only ISBN search criteria was entered
                    StringBuilder sbti = new StringBuilder();
                    sqlQuery = sbti.AppendFormat("SELECT a.FirstName, a.LastName, b.Title, p.PublisherAbbreviation, bt.BindingType from Authors a join AuthorsBooks au on a.AuthorId = au.AuthorId join Books b on b.BookId = au.BookId join Publishers p on p.PublisherId = b.PublisherId join BindingType bt on bt.BindingTypeId = b.BindingTypeId WHERE (b.[ISBN-13] like '%{0}%' OR b.[ISBN-10] like '%{0}%');", isbn).ToString();
                }

                // Execute the query and return the search results to the data grid view
                try
                {
                    //DataSet searchResults = new DataSet();
                    DataTable searchResults = new DataTable();
                    searchResults = DataAccess.DataAccess.GetBookSearchResults(sqlQuery);
                    if (searchResults != null)
                    {
                        SearchResultsDataGridView.Visible = true;
                        SearchResultsDataGridView.AutoGenerateColumns = true;
                        SearchResultsDataGridView.DataSource = searchResults;
                        //SearchResultsDataGridView.DataMember = sqlQuery;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting search results: " + ex.Message, "Get Search Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("No search criteria entered!\r\n\r\nEnter an author, title and/or ISBN.", "No Search Criteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
