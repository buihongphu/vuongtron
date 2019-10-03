using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _789456
{
    class hinhvuong
    {
         public double cd;
        public double chuvi;
        public double dientich;
        public double Canh
        {
            get { return cd; }
            set { cd = value; }
        }
        public hinhvuong() { }
        public hinhvuong(double canh)
        {
            cd = canh;
        }
        public void Cv()
        {
            chuvi = Canh * 4;
        }
        public void Dt()
        {
            dientich = Canh * Canh;
        }
    }
    }
