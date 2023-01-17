using System.ComponentModel.DataAnnotations;

namespace BasicAuthenticationWebApiCore.Models
{
    public class User
    {
        [Key]        
        public String UserName { get; set; }
       // public int Id { get; set; }
        public String Password { get; set; }
    }
}
