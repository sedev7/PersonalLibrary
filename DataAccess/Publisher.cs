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
    public class Publisher
    {
        #region Constructors
        public Publisher() { }
        public Publisher(string name, string abbreviation)
        {
            PublisherName = name;
            Abbreviation = abbreviation;
        }
        public Publisher(int id, string name, string abbreviation)
        {
            PublisherId = id;
            PublisherName = name;
            Abbreviation = abbreviation;
        }
        #endregion
        #region Properties
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string Abbreviation { get; set; }
        #endregion
    }
}
