using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Demo
{
    class DanhSachPhanSo
    {
        List<PhanSo> ds = new List<PhanSo>();
        #region Nhập dữ liệu
        public void ThemPhanSo(PhanSo phanSo)
        {
            ds.Add(phanSo);
        }
        public void DocFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = "";
            PhanSo phanSo = new PhanSo();
            while ((line = sr.ReadLine()) != null)
            {
                line = line.Trim();
                string[] str = line.Split('/');
                if (int.Parse(str[1]) != 0)
                {
                    phanSo = new PhanSo(int.Parse(str[0]), int.Parse(str[1]));
                    ThemPhanSo(phanSo);
                }
            }
            sr.Close();
        }
        #endregion
        #region Xuất dữ liệu
        public override string ToString()
        {
            string s = "";
            int count = 0;
            foreach (var ps in ds)
            {
                s += ps.ToString() + '\t';
                count++;
                if (count % 10 == 0)
                    s += "\n";
            }
            return s;
        }
        #endregion
        #region Đếm phân số
        //Nếu đếm phân số âm truyền giá trị 0, đếm phân số dương truyền giá trị 1
        public int DemPhanSoAmDuong(int dk)
        {
            int count = 0;
            if (dk == 0)
            {
                foreach (var ps in ds)
                {
                    if (ps.TinhGiaTri() < 0)
                        count++;
                }
            }
            else
            {
                foreach (var ps in ds)
                {
                    if (ps.TinhGiaTri() >= 0)
                        count++;
                }
            }
            return count;
        }
        //Nếu đếm phân số có tử số x truyền giá trị 0, đếm phân só có mẫu số x truyền giá trị 1
        public int DemPhanSoTuMau(int x, int dk)
        {
            int count = 0;
            foreach (var phanSo in ds)
            {
                if (dk == 0)
                {
                    if (phanSo.tu.Equals(x))
                        count++;
                }
                else
                {
                    if (phanSo.mau.Equals(x))
                        count++;
                }
            }
            return count;
        }
        public int DemPhanSo()
        {
            return ds.Count;
        }
        #endregion
        #region Tìm phân số
        //Nếu tìm phân số dương thì truyền số 1, âm thì truyền số 0
        public DanhSachPhanSo TimPhanSoAmDuong(int dk)
        {
            DanhSachPhanSo kq = new DanhSachPhanSo();
            foreach (var phanSo in ds)
            {
                if (dk == 0)
                {
                    if (phanSo.TinhGiaTri() < 0)
                        kq.ThemPhanSo(phanSo);
                }
                else
                {
                    if (phanSo.TinhGiaTri() >= 0)
                        kq.ThemPhanSo(phanSo);
                }
            }
            return kq;
        }
        public DanhSachPhanSo TimPhanSo_TuMau(int x, int dk)
        {
            DanhSachPhanSo kq = new DanhSachPhanSo();
            foreach (var phanSo in ds)
            {
                if (dk == 0)
                {
                    if (phanSo.tu == x)
                        kq.ThemPhanSo(phanSo);
                }
                else
                {
                    if (phanSo.mau == x)
                        kq.ThemPhanSo(phanSo);
                }
            }
            return kq;
        }
        #endregion
        #region Tìm Min Max
        //Nếu tìm phân số dương thì truyền số 1, âm thì truyền số 0
        public PhanSo TimPhanSoCoMax_AmDuong(int dk)
        {
            PhanSo max = new PhanSo();
            if (dk == 0)
                max = new PhanSo(int.MinValue, 1);
            else
                max = new PhanSo(0, 1);
            DanhSachPhanSo danhSach = TimPhanSoAmDuong(dk);
            foreach (var ps in danhSach.ds)
            {
                if (ps.TinhGiaTri() > max.TinhGiaTri())
                    //max = new PhanSo(ps.tu, ps.mau);
                    max = ps;
            }
            return max;
        }
        public PhanSo TimPhanSoCoMin_AmDuong(int dk)
        {
            PhanSo min = new PhanSo();
            if (dk == 0)
                min = new PhanSo(0, 1);
            else
                min = new PhanSo(int.MaxValue, 1);
            DanhSachPhanSo danhSach = TimPhanSoAmDuong(dk);
            foreach (var ps in danhSach.ds)
            {
                if (ps.TinhGiaTri() < min.TinhGiaTri())
                    //min = new PhanSo(ps.tu, ps.mau);
                    min = ps;
            }
            return min;
        }
        //Tìm phân số lớn nhất thì truyền sô 1, tìm phân số bé nhất thì truyền số 0
        public PhanSo TimPhanSoCoMin_Max(int dk)
        {
            PhanSo minMax = new PhanSo(ds.First().tu, ds.First().mau);
            foreach (var phanSo in ds)
            {
                if (dk == 1)
                {
                    if (minMax.TinhGiaTri() < phanSo.TinhGiaTri())
                        minMax = phanSo;
                }
                else
                {
                    if (minMax.TinhGiaTri() > phanSo.TinhGiaTri()) 
                    minMax = phanSo;
                }
            }
            return minMax;

        }
        #endregion
        #region Tìm vị trí của phân số
        public List<int> TimViTriCuaPhanSoX(PhanSo x)
        {
            List<int> kq = new List<int>();
            PhanSo[] temp = ds.ToArray();
            for (int i = 0; i < ds.Count; i++)
            {
                if (temp[i].tu == x.tu && temp[i].mau == x.mau)
                    kq.Add(i);
            }
            ds = temp.ToList();
            return kq;
        }
        //Nếu tìm vị trí của phán số âm thì truyền số 0, tìm vị trí của phân số dương thì truyền số 1
        public List<int> TimViTriPhanSo_AmDuong(int dk)
        {
            List<int> kq = new List<int>();
            PhanSo[] temp = ds.ToArray();
            for (int i = 0; i < ds.Count; i++)
            {
                if (dk == 0)
                {
                    if (temp[i].TinhGiaTri() < 0)
                    {
                        kq.Add(i);
                    }
                }
                else
                {
                    if (temp[i].TinhGiaTri() >= 0)
                    {
                        kq.Add(i);
                    }
                }
            }
            return kq;
        }
        //Nếu tìm vị trí của phân só có tử x thì truyền sô 0, tìm vị trí của phán só có mẫu x thì truyền số 1
        public List<int> TimViTriPhanSo_TuMau(int x, int dk)
        {
            List<int> kq = new List<int>();
            PhanSo[] temp = ds.ToArray();
            for (int i = 0; i < ds.Count; i++)
            {
                if (dk == 0)
                {
                    if (temp[i].tu == x)
                        kq.Add(i);
                }
                else
                {
                    if (temp[i].mau == x)
                        kq.Add(i);
                }
            }
            return kq;
        }
        #endregion
        #region Tính tổng phân số
        public PhanSo TinhTongCacPhanSo_AmDuong(int dk)
        {
            PhanSo kq = new PhanSo();
            foreach (var phanSo in ds)
            {
                if (dk == 0)
                {
                    if (phanSo.TinhGiaTri() < 0)
                        kq = PhanSo.TinhTong(kq, phanSo);
                }
                else
                {
                    if (phanSo.TinhGiaTri() >= 0)
                        kq = PhanSo.TinhTong(kq, phanSo);
                }
            }
            kq.ToiGianPhanSo();

            return kq;
        }
        //Tính tổng phân số có chung tử số thì truyền sô 0, tính tổng phân số có chung mẫu số thì chuyền số 1
        public PhanSo TinhTongCacPhanSo_TuMau(int x, int dk)
        {
            DanhSachPhanSo danhSach = TimPhanSo_TuMau(x, dk);
            PhanSo kq = new PhanSo();
            foreach (var phanSo in danhSach.ds)
            {
                kq = PhanSo.TinhTong(kq, phanSo);
            }
            kq.ToiGianPhanSo();
            return kq;
        }
        #endregion
        #region Xóa phân số
        public void XoaPhanSoTaiViTri(int index)
        {
            ds.RemoveAt(index);
        }
        public void XoaPhanSoDauTien()
        {
            XoaPhanSoTaiViTri(0);
        }
        public void XoaPhanSoCuoiCung()
        {
            XoaPhanSoTaiViTri(ds.Count - 1);
        }
        //Nếu tìm thấy phân sô thì trả về true, không tìm thấy thì trả về False
        public bool XoaTatCaPhanSoX(PhanSo x)
        {
            List<int> vt = TimViTriCuaPhanSoX(x);
            if (vt.Count == 0)
                return false;
            ds.RemoveAll(phanSo => (phanSo.tu == x.tu && phanSo.mau == x.mau));
            return true;
        }
        //Nếu xóa phân số cùng tử số thì truyền số 0, xóa phân số cùng mẫu số thì truyền số 1
        public bool XoaTatCaPhanSoCung_TuMau(int x, int dk)
        {
            List<int> vt = TimViTriPhanSo_TuMau(x, dk);
            if (vt.Count == 0)
                return false;
            if (dk == 0)
                ds.RemoveAll(phanSo => phanSo.tu == x);
            else
                ds.RemoveAll(phanSo => phanSo.mau == x);
            return true;
        }
        //Nếu xóa phân số có giá trị giống phân sô đầu tiên thì truyền số 0, xóa phân số có giá trị giống phân số 
        //cuối cùng thì truyền số 1
        public void XoaTatCaPhanSoCoGiaTriGiongPhanSo_DauTienCuoiCung(int dk)
        {
            PhanSo phanSoDau_Cuoi = new PhanSo();
            if (dk == 0)
                phanSoDau_Cuoi = ds.First();
            else
                phanSoDau_Cuoi = ds.Last();
            ds.RemoveAll(phanSo => phanSo.TinhGiaTri().Equals(phanSoDau_Cuoi.TinhGiaTri()));
        }
        //Nếu xóa phân số có giá trị lớn nhất thì truyền số 1, xóa phân số có giá trị nhỏ nhất thì truyền số 0
        public void XoaTatCaPhanSoCoGiaTriLonNhat_NhoNhat(int dk)
        {
            PhanSo phanSoMau = TimPhanSoCoMin_Max(dk);
            ds.RemoveAll(phanSo => phanSo.TinhGiaTri().Equals(phanSoMau.TinhGiaTri()));
        }
        //Nếu xóa phân số âm thì truyền số 0, nếu xóa phân số dương thì truyền số 1
        public void XoaTatCaPhanSoAm_Duong(int dk)
        {
            if (dk == 0)
                ds.RemoveAll(phanSo => phanSo.TinhGiaTri() < 0);
            else
                ds.RemoveAll(phanSo => phanSo.TinhGiaTri() >= 0);
        }
        #endregion
        #region Thêm phân số
        public bool ThemPhanSoTaiViTri(PhanSo phanSo, int index)
        {
            if (0 <= index && index <= ds.Count)
            {
                ds.Insert(index, phanSo);
                return true;
            }
            return false;

        }
        public bool ThemPhanSoTaiViTriDauTien(PhanSo phanSo)
        {
            return ThemPhanSoTaiViTri(phanSo, 0);
        }
        #endregion
        #region Sắp xếp phân số
        public void SapXepDanhSachPhanSoTheoChieuTang()
        {
            PhanSo[] tempList = ThuVienDungChung.SapXepPhanSo(ds, KieuSapXep.SapXepTang);
            ds = tempList.ToList();
        }
        public void SapXepDanhSachPhanSoTheoChieuGiam()
        {
            PhanSo[] tempList = ThuVienDungChung.SapXepPhanSo(ds, KieuSapXep.SapXepGiam);
            ds = tempList.ToList();
        }
        #endregion
    }
}
