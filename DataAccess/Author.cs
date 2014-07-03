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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary.DataAccess
{
    public class Author
    {
        #region Constructor
        public Author() {}
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Properties
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion
    }
}
