﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        public string TaskDescription { get; set; }
        public bool IsDone { get; set; }
        DateTime DueDate { get; set; }

        [ForeignKey]
        public int ListID { get; set; }
    }
}