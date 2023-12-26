using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystemLibrary.Models
{
    public class AddBook
    {
        public int book_id { get; set; } 
        public string book_title { get; set; }
        public string book_author { get; set; }
        public string book_genre { get; set; }
        public string book_isbn { get; set; }
    }
}
