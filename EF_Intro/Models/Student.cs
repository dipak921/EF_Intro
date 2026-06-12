using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Intro.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("StudentName", TypeName = "varchar(50)")]
        public string Name { get; set; }


        [Required]
        public string Gender { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
