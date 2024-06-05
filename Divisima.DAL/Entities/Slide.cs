using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisima.DAL.Entities
{
    public class Slide
    {
        public int ID { get; set; }
        [Column(TypeName="Nvarchar(50)"), StringLength(50), Display(Name ="Slogan")]
        public string Slogan { get; set; }
        [Column(TypeName = "Nvarchar(50)"), StringLength(50), Display(Name = "Slayt Başlığı"),Required(ErrorMessage ="Slayt Başlığı Boş Bırakılamaz")]
        public string Title { get; set; }
        [Column(TypeName = "Nvarchar(150)"), StringLength(150), Display(Name = "Slayt Açıklaması"), Required(ErrorMessage = "Slayt Açıklaması Boş Bırakılamaz")]

        public string Description { get; set; }
        [Column(TypeName = "Nvarchar(150)"), StringLength(150), Display(Name = "Resim Dosyası")]

        public String Picture { get; set; }
        [Column(TypeName = "Decimal(18,2)"),Display(Name = "Fiyat Bilgisi")]
        public Decimal  Price { get; set; }
        [Column(TypeName = "Nvarchar(150)"), Display(Name = "Link Adresi")]

        public string Link { get; set;}
        [Display(Name = "Görüntüleme Sırası")]
        public int DisplayIndex{ get; set; }
    }
}
