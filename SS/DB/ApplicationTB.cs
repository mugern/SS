using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.DB
{
    public class ApplicationTB
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_application { get; set; }
        [Required]
        [StringLength(50)]
        public string FIO_application { get; set; }

        [Required]
        [StringLength(300)]
        public string application { get; set; }
               
        public string Status_application { get; set; }


    }
}
