using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hyoz_mall.Models
{
    public class Clothes
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="옷 이름")]
        public string Name { get; set; }
        [Display(Name ="디자이너")]
        public string Designer { get; set; }
        [Display(Name ="가격")]
        public int KRW { get; set; }
    }
}
