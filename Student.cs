using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GroupViewer
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string LName { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string GroupStudent { get; set; }

        public double Stip { get; set; }

    }
}
