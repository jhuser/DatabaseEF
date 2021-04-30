


namespace DataBase.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayFormat(ApplyFormatInEditMode = false)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Number Phone")]
        public int Phone { get; set; }

        [Required]
        [StringLength(20)]
        public string NickName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false)]
        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        [Display(Name = "Status Log")]
        public bool StatusLog { get; set; }


    }
}
