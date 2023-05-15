namespace SS.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_User { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Password { get; set; }

        public int User_Rols { get; set; }

        public virtual Rols Rols { get; set; }
    }
}
