using System.ComponentModel.DataAnnotations;

namespace Crud__operation.Model
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string Address { get; set; }

        public DateTime DateTime { get; set; }=DateTime.Now;

        //public  string? Department {  get; set; }
    }
}
