using System.ComponentModel.DataAnnotations;

namespace BaseRepo.Entity
{
    public class Developer:BaseEntity    {

        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Followers { get; set; }
    }
}