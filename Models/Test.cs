using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcMovie.Models
{
    [Table("Tests")]
    public class Test
    {
        [Key]
        public string TestID { get; set; }
        public string TestName { get; set; }

        
    }
}