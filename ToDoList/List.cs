using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        public string ListTitle { get; set; }
        DateTime ListCreateDate { get; set; } //remove from view and replace with current date
    }
}