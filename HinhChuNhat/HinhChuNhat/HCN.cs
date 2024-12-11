using System;

namespace HinhChuNhat
{
    internal class HCN
    {
        string maso;
        double chieudai;
        double chieurong;

        public string Maso { get => maso; set => maso = value; }
        public double Chieudai { get => chieudai; set => chieudai = value; }
        public double Chieurong { get => chieurong; set => chieurong = value; }

        internal object dientich(double chieudai, double chieurong)
        {
            return chieudai * chieurong;
        }
    }
}