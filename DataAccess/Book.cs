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
    public class Book
    {
        #region Constructors
        public Book() { }
        #endregion
        #region Properties
        public int ResourceId { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Edition { get; set; }
        //public string Copyright { get; set; }
        public int Copyright { get; set; }
        public string ISBN13 { get; set; }
        public string ISBN10 { get; set; }
        public string BindingType { get; set; }
        public int BindingTypeId { get; set; }
        public Publisher Publisher { get; set; }
        public string PublisherImprint {get; set; }
        public int PublisherImprintId { get; set; }
        public int Rating { get; set; }
        #endregion
    }
}
