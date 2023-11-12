using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [StringLength(200)]
        public String userName { get; set; }
        [StringLength(500)]
        public String userMail { get; set; }
        [StringLength(200)]
        public String userPassword { get; set; }
        [StringLength(14)]
        public String userPhone { get; set;}
        public DateTime dateJoined { get; set; } =  DateTime.Now;
    }
}
