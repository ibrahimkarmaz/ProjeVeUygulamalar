using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OtoparkOtomasyonuEFCodeFirst.Entities
{
    public class AracParkYerleri
    {
        public int ID { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(70)]
        public string ParkYerleri { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Durumu { get; set; }

        public virtual ICollection<AracParkBilgileri> AracParkBilgileris { get; set; }
    }
}
