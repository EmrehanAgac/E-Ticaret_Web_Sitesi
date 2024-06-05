using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisima.DAL.Entities
{
    public class Admin
    {
        public int ID { get; set; }
        [Column(TypeName ="varchar(20)"), StringLength(20), Display(Name ="Kullanıcı Adı"),Required(ErrorMessage = "Kullanıcı Adı Boş Bırakılamaz")]
        public string UserName { get; set; }
        [Column(TypeName = "varchar(32)"), StringLength(32), Display(Name = "Parola"), Required(ErrorMessage = "Parola Boş Bırakılamaz") ]
        public string Password { get; set; }
        [Column(TypeName="NvarChar(50)"), StringLength(50), Display(Name ="Admin Adı"), Required(ErrorMessage ="Ad Soyad Boş Bırakılamaz")]

        public string NameSurName { get; set; }
        [Display(Name = "Son Giriş Tarihi")]
        public DateTime LastLoginDate { get; set; }
        [Display(Name ="Son Giriş IP No")]
        public string LastLoginIP{ get; set;}
    }
}
