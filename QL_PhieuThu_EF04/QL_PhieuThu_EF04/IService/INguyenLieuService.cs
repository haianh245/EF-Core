using QL_PhieuThu_EF04.Entities;
using QL_PhieuThu_EF04.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_PhieuThu_EF04.IService
{
    interface INguyenLieuService
    {
        public ErrType ThemNguyenLieu(NguyenLieu nguyenLieu);
    }
}
