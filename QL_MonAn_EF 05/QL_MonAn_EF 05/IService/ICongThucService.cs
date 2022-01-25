using QL_MonAn_EF_05.Entities;
using QL_MonAn_EF_05.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_MonAn_EF_05.IService
{
    interface ICongThucService
    {
        public ErrType ThemCongThucChoMonAn(MonAn monAn);
    }
}
