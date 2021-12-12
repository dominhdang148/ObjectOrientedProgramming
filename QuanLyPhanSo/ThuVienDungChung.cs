using System.Collections.Generic;
namespace Demo
{
    class ThuVienDungChung
    {
        public static bool KiemTraPhanSo(string line)
        {
            string[] str = line.Split('/');
            if (int.Parse(str[1]) == 0)
                return false;
            return true;
        }
        public static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static int UocChungLonNhat(int a, int b)
        {
            if (a < b)
                Swap<int>(ref a, ref b);
            if (b == 0)
                return a;
            return UocChungLonNhat(b, a % b);
        }
        private static int KiemTraDieuKienSapXep(PhanSo a, PhanSo b, KieuSapXep k)
        {
            switch (k)
            {
                case KieuSapXep.Thoat:
                    break;
                case KieuSapXep.SapXepTang:
                    return a.TinhGiaTri().CompareTo(b.TinhGiaTri());
                case KieuSapXep.SapXepGiam:
                    return -a.TinhGiaTri().CompareTo(b.TinhGiaTri());
                default:
                    break;
            }
            return -1;
        }
        private static void Partition(PhanSo[] danhSach,int left, int right, KieuSapXep kieu)
        {
            int i, j;
            PhanSo phanSoNgan = danhSach[(left + right) / 2];
            i = left;
            j = right;
            do
            {
                while (KiemTraDieuKienSapXep(danhSach[i], phanSoNgan, kieu) == -1)
                    i++;
                while (KiemTraDieuKienSapXep(danhSach[j], phanSoNgan, kieu) == 1)
                    j--;
                if (i <= j)
                {
                    Swap<PhanSo>(ref danhSach[i], ref danhSach[j]);
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j)
                Partition(danhSach, left, j, kieu);
            if (i < right)
                Partition(danhSach, i, right, kieu);
        }
        public static PhanSo[] SapXepPhanSo(List<PhanSo> danhSach, KieuSapXep k)
        {
            PhanSo[] tempList = danhSach.ToArray();
            #region Bubble-sort
            //for(int i=danhSach.Count-1;i>=0;i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (KiemTraDieuKienSapXep(tempList[j], tempList[j + 1], k) == 1)
            //            Swap<PhanSo>(ref tempList[j],ref tempList[j + 1]);
            //    }
            //}
            #endregion
            #region Quick-sort
            Partition(tempList, 0, danhSach.Count - 1, k);
            #endregion
            return tempList;
        }
    }
}
