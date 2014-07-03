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
    public class Resource
    {
        #region Constructors
        public Resource() { }
        #endregion
        #region Properties
        public int ResourceId { get; set; }
        public string AcquisitionDate { get; set; }
        public string ResourceNotes { get; set; }
        public int ResourceTypeId { get; set; }
        public string ResourceTypeDescription { get; set; }
        #endregion
    }
}
