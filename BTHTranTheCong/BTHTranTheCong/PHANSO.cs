using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTHTranTheCong
{
    internal class PHANSO
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public PHANSO (int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
        //Tìm ước chung lớn nhất.
        public int UCLN(PHANSO a)
        {
            int m = a.TuSo;
            int n = a.MauSo;
            if (m == 0 || n == 0)
                return m + n;
            while (m * n != 0)
            {
                if (m > n)
                    m %= n;
                else
                    n %= m;
            }
            return m + n;
        }
        public PHANSO RutGon(PHANSO a)
        {
            int num = UCLN(a);
            a.TuSo /= num;
            a.MauSo /= num;
            return a;
        }
        public PHANSO PhepCong(PHANSO a,PHANSO b)
        {
            PHANSO kq = new PHANSO(0, 1);
            kq.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return RutGon(kq);
        }
        public PHANSO PhepTru(PHANSO a, PHANSO b)
        {
            PHANSO kq = new PHANSO(0, 1);
            kq.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return RutGon(kq);
        }
        public PHANSO PhepNhan(PHANSO a, PHANSO b)
        {
            PHANSO kq = new PHANSO(0, 1);
            kq.TuSo = a.TuSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return RutGon(kq);
        }
        public PHANSO PhepChia(PHANSO a, PHANSO b)
        {
            PHANSO kq = new PHANSO(0, 1);
            kq.TuSo = a.TuSo * b.MauSo;
            kq.MauSo = a.MauSo * b.TuSo;
            return RutGon(kq);
        }
    }
    
}
