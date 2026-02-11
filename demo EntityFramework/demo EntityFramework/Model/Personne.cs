using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace demo_EntityFramework.Model
{
    [Table("Personne")]
    internal class Personne
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [Column("age")]
        [Range(0,130)]
        public int Age { get; set; }
        [Phone]
        [Column("phone")]
        [StringLength(10)]
        public string Phone {  get; set; }

        [EmailAddress]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }

        public Personne(){ }
        public Personne(string firstaname,string lastname,int age , string phone, string email)
        {
            
            FirstName =firstaname;
            LastName =lastname;
            Age =age;
            Phone =phone;
            Email =email;


        }
        public override string ToString()
        {
                return $"Id :{Id}, Name {FirstName} {LastName},Age :{Age},Contact : {Phone} {Email}";
        }
    }
}
