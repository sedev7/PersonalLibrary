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
    public partial class AddPublisherForm : Form
    {
        Publisher _NewPublisher = new Publisher();

        // Define a delegate
        public delegate void ReturnPublisher(object sender);

        // Create an instance of the delegate (null)
        public ReturnPublisher returnPublisher;

        public AddPublisherForm()
        {
            InitializeComponent();

            // Set the cursor on publisher name
            PublisherNameTextBox.Focus();
        }

        private void AddPublisherButton_Click(object sender, EventArgs e)
        {
            // Assume data is valid - no validation being done on data!
            // But data is required...
            if(PublisherNameTextBox.Text ==  "" || AbbreviationTextBox.Text == "")
            {
                MessageBox.Show("Publisher name and abbreviation are required!", "Publisher Name and Abbreviation");
            }
            else
            {
                // We are not validating data here - assume data entered is valid!
                _NewPublisher.PublisherName = PublisherNameTextBox.Text.Trim();
                _NewPublisher.Abbreviation = AbbreviationTextBox.Text.Trim();
                try
                {
                    _NewPublisher.PublisherId = DataAccess.DataAccess.InsertPublisher(_NewPublisher);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding publisher to database!", "Add Publisher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                // Return the publisher with PublisherId to the main form
                returnPublisher(_NewPublisher);

                // Close the form
                this.Close();
            }
        }
    }
}
