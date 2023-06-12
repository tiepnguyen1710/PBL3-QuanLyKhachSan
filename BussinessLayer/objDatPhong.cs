﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class objDatPhong
    {
        public int IDDP { set; get; }
        public int IDKH { set; get; }
        public string HOTEN { set; get; }
        public DateTime? NGAYDATPHONG { set; get; }
        public DateTime? NGAYTRAPHONG { set; get; }
        public double? SOTIEN { set; get; }
        public int? SONGUOIO { set; get; }
        public int IDUSER { set; get; }
        public string MACTY { set; get; }
        public string MADVI { set; get; }
        public bool? STATUS { set; get; }
        public bool? THEODOAN { set; get; }
        public bool? DISABLED { set; get; }
        public string GHICHU { set; get; }
    }
}
