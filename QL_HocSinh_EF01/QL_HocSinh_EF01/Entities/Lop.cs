using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_EF01.Entities
{
    class Lop
    {
        public int LopID { get; set; }
        [Required]
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public List<HocSinh> HocSinhs { get; set; }
    }
}
