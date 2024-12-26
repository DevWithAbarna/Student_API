using System.ComponentModel.DataAnnotations;

namespace Crud__operation.Model
{
    public class Student//property,mode,entity
    {
        [Key]
        public int id { get; set; }//primary key
        [Required]
        public string? name { get; set; } 

        public string? address { get; set; }

        public int Phoneno { get; set; }

    }
}
