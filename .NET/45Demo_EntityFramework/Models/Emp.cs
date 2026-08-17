using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _45Demo_EntityFramework.Models
{

    [Table("Emp")]

    public class Emp //POCO
    {
        [Key]//
        [Column("Id",TypeName ="int")]
        public int Id { get; set; }


        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }
    }
}
