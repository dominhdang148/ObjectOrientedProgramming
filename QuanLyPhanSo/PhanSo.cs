namespace Demo
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;
        public int tu
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public int mau
        {
            get { return mauSo; }
            set { mauSo = value; }
        }
        public bool KiemTraPhanSo(int t, int m)
        {
            if (m != 0)
                return true;
            return false;
        }
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public PhanSo(int t, int m)
        {
            tuSo = t;
            mauSo = m;
        }
        public float TinhGiaTri()
        {
            float kq = (float)tuSo / (float)mauSo;
            return kq;
        }
        public PhanSo(string line)
        {
            string[] str = line.Split('/');
            tuSo = int.Parse(str[0]);
            mauSo = int.Parse(str[1]);

        }
        public static PhanSo TinhTong(PhanSo a, PhanSo b)
        {
            PhanSo sum = new PhanSo();
            if(a.mauSo==b.mauSo)
            {
                sum.tuSo = a.tuSo + b.tuSo;
                sum.mauSo = a.mauSo;
            }
            else
            {
                sum.mauSo = a.mauSo * b.mauSo;
                sum.tuSo = (a.tuSo * b.mauSo) + (b.tuSo * a.mauSo);
            }
            return sum;
        }
        public void ToiGianPhanSo()
        {
            int gcd = ThuVienDungChung.UocChungLonNhat(tuSo, mauSo);
            tuSo /= gcd;
            mauSo /= gcd;
        }
        public override string ToString()
        {
            string s = tuSo + "/" + mauSo;
            return s;
        }
    }
}
