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
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonalLibrary;

namespace PersonalLibrary.DataAccess
{
    public class DataAccess
    {
        public static string Connection()
        {
            return "Data Source=Neptune;Initial Catalog=PersonalLibrary;Integrated Security=SSPI;";
        }

        public static BindingList<string> GetAuthors()
        {
            BindingList<string> authors = new BindingList<string>();

            string sql = "SELECT CONCAT(LastName,FirstName) as Author from Authors;";

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            authors.Add(reader["Author"].ToString());
                        }
                    }
                }
            }
            return authors;
        }

        public static BindingList<string> GetBookBindingTypes()
        {
            BindingList<string> bindingTypes = new BindingList<string>();

            string sql = "SELECT BindingType FROM BindingType ORDER BY BindingType;";

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bindingTypes.Add(reader["BindingType"].ToString());
                        }
                    }
                }
            }
            return bindingTypes;
        }

        public static int GetBookBindingTypeId(string bindingType)
        {
            int bindingTypeId = 0;

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("SELECT BindingTypeId FROM BindingType WHERE BindingType like '{0}';", bindingType).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    bindingTypeId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return bindingTypeId;
        }

        public static int GetBookCount()
        {
            int count = 0;

            string sql = "SELECT COUNT(*) FROM Books";

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
        }

        public static DataTable GetBookSearchResults(string sqlQuery)
        {
            DataTable searchResults = new DataTable();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conn.ConnectionString))
                {
                    da.Fill(searchResults);
                }
            }
            return searchResults;
        }

        public static int GetPeriodicalCount()
        {
            int count = 0;

            string sql = "SELECT COUNT(*) FROM Periodicals";

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
        }

        public static BindingList<string> GetPublishers()
        {
            BindingList<string> publishers = new BindingList<string>();

            string sql = "SELECT PublisherName FROM Publishers ORDER BY PublisherName;";

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            publishers.Add(reader["PublisherName"].ToString());
                        }
                    }
                }
            }
            return publishers;
        }
        public static Publisher GetPublisher(string publisherName)
        {
            Publisher publisher = new Publisher();

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("SELECT PublisherId, PublisherName, PublisherAbbreviation FROM Publishers WHERE PublisherName like '{0}';", publisherName).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // There should only be one record
                            publisher.PublisherId = Convert.ToInt32(reader["PublisherId"]);
                            publisher.PublisherName = reader["PublisherName"].ToString();
                            publisher.Abbreviation = reader["PublisherAbbreviation"].ToString();
                        }
                    }
                }
            }
            return publisher;
        }
        public static int GetPublisherId(string publisherName)
        {
            int publisherId = 0;

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("SELECT PublisherId FROM Publishers WHERE PublisherName like '{0}';", publisherName).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    publisherId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return publisherId;
        }


        public static BindingList<string> GetPublisherImprints()
        {
            BindingList<string> imprints = new BindingList<string>();

            string sql = "SELECT PublisherImprintName FROM PublisherImprints ORDER BY PublisherImprintName;";

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            imprints.Add(reader["PublisherImprintName"].ToString());
                        }
                    }
                }
            }
            return imprints;
        }
        public static int GetPublisherImprintId(string publisherImprintName)
        {
            int publisherImprintId = 0;

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("SELECT PublisherImprintId FROM PublisherImprints WHERE PublisherImprintName like '{0}';", publisherImprintName).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    publisherImprintId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return publisherImprintId;
        }
        public static int GetResourceTypeId(string resourceTypeDescription)
        {
            int resourceTypeId = 0;

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("SELECT ResourceTypeId FROM ResourceTypes WHERE ResourceTypeDescription like '{0}';", resourceTypeDescription).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    resourceTypeId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return resourceTypeId;
        }

        public static int InsertAuthor(Author author)
        {
            int authorId = 0;

            StringBuilder sb = new StringBuilder();
            // Either of the following to SQL statements will work:
            //string sql = sb.AppendFormat("INSERT INTO Authors (LastName,FirstName) OUTPUT INSERTED.AuthorId VALUES ('{0}','{1}')", author.LastName, author.FirstName).ToString();
            string sql = sb.AppendFormat("INSERT INTO Authors (LastName,FirstName) VALUES ('{0}','{1}'); SELECT AuthorId FROM Authors WHERE AuthorId = SCOPE_IDENTITY()", author.LastName, author.FirstName).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    
                    // Insert the new record and return the AuthorId
                    authorId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return authorId;
        }

        public static int InsertPublisher(Publisher publisher)
        {
            int publisherId = 0;

            StringBuilder sb = new StringBuilder();
            // Either of the following to SQL statements will work:
            //string sql = sb.AppendFormat("INSERT INTO Authors (LastName,FirstName) OUTPUT INSERTED.AuthorId VALUES ('{0}','{1}')", author.LastName, author.FirstName).ToString();
            string sql = sb.AppendFormat("INSERT INTO Publishers (PublisherName,PublisherAbbreviation) VALUES ('{0}','{1}'); SELECT PublisherId FROM Publishers WHERE PublisherId = SCOPE_IDENTITY()", publisher.PublisherName, publisher.Abbreviation).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    // Insert the new record and return the AuthorId
                    publisherId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return publisherId;
        }
        public static int InsertAuthorsBooks(int bookId, int authorId)
        {
            int success = 0;

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("INSERT INTO AuthorsBooks (AuthorId, BookId) VALUES ({0},{1});", authorId, bookId).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    // Insert the new record and return the AuthorId
                    success = Convert.ToInt32(cmd.ExecuteNonQuery());
                }
            }
            return success;
        }

        public static int InsertNewBook(Book book)
        {
            int bookId = 0;

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("INSERT INTO Books (Title,Rating,[ISBN-10],Edition,BindingTypeId,[ISBN-13],CopyrightDate,ResourceId,PublisherId,PublisherImprintId) " +
                         "VALUES ('{0}',{1},'{2}',{3},{4},'{5}','{6}',{7},{8},{9});" +
                         "SELECT BookId FROM Books WHERE BookId = SCOPE_IDENTITY()",
                         book.Title,book.Rating,book.ISBN10,book.Edition,book.BindingTypeId,book.ISBN13,book.Copyright,book.ResourceId,book.Publisher.PublisherId,book.PublisherImprintId).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    // Insert the new record and return the AuthorId
                    bookId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return bookId;
        }
        public static int InsertResource(Resource resource)
        {
            int resourceId = 0;

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("INSERT INTO Resources (AcquisitionDate, ResourceNotes, ResourceTypeId) VALUES ('{0}','{1}',{2}); SELECT ResourceId FROM Resources WHERE ResourceId = SCOPE_IDENTITY()", resource.AcquisitionDate, resource.ResourceNotes, resource.ResourceTypeId).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    // Insert the new record and return the AuthorId
                    resourceId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return resourceId;
        }
        public static int InsertResourceType(Resource resource)
        {
            int resourceTypeId = 0;

            StringBuilder sb = new StringBuilder();
            string sql = sb.AppendFormat("INSERT INTO ResourceTypes (ResourceTypeDescription) VALUES ('{0}'); SELECT ResourceTypeId FROM ResourceTypes WHERE ResourceTypeId = SCOPE_IDENTITY()", resource.ResourceTypeDescription).ToString();

            using (SqlConnection conn = new SqlConnection(DataAccess.Connection()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    // Insert the new record and return the AuthorId
                    resourceTypeId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return resourceTypeId;
        }
    }
}
