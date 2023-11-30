using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.Model
{
    [Table("tbl_Student")]
    public class Student
    {
        //Fluent api
        //Data Annotation

        //[Required]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        //[Column("StudentName")]
        public string Name { get; set; }
        public string? Address { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        //Navigation Property
        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
