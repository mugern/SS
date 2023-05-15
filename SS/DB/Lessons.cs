namespace SS.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lessons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lessons()
        {
            ClassLesson = new HashSet<ClassLesson>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_lessons { get; set; }

        [Column("lessons")]
        [Required]
        [StringLength(30)]
        public string lessons1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Сabinet_Number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassLesson> ClassLesson { get; set; }
    }
}
