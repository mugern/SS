namespace SS.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassLesson")]
    public partial class ClassLesson
    {
        
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_class { get; set; }

        
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_lessons { get; set; }

        
        [Column(Order = 2)]
        public byte Day_Life { get; set; }

       
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Lesson_Number { get; set; }

        public virtual Class Class { get; set; }
        public int id { get; set; }
        public void SetValues(ClassLesson e_CL)
        {            
            ID_lessons = e_CL.ID_lessons;          
            Lesson_Number = e_CL.Lesson_Number;
        }
        public virtual Lessons Lessons { get; set; }
    }
}
