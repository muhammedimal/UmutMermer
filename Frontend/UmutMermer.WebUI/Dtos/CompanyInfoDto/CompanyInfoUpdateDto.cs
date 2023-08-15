using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutMermer.WebUI.Dtos.CompanyInfoDto
{
    public class CompanyInfoUpdateDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen İsim Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Hakkımızda Bilgisi Giriniz.")]
        public string About { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresi  Giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon Numarası Giriniz.")]
        public string Telephone1 { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon Numarası Giriniz.")]
        public string Telephone2 { get; set; }

        [Required(ErrorMessage = "Lütfen Adres Giriniz.")]
        public string Adress { get; set; }
    }
}
