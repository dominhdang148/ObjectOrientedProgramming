using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{

	class DanhSachNhanVien
	{
		List<NhanVien> ds = new List<NhanVien>();
		#region Nhập xuất dữ liệu
		public void ThemNV(NhanVien n)
		{
			ds.Add(n);
		}
		public void ThemDsNV(List<NhanVien> n)
		{
			ds.AddRange(n);
		}
		public void NhapTuFile()
		{
			string path = "D:NV.txt";
			StreamReader sr = new StreamReader(path);
			string str = "";
			NhanVien n = new NhanVien();
			while ((str = sr.ReadLine()) != null)
			{
				string[] line = str.Split('_');
				switch (line[0])
				{
					case "HD":
						n = new NhanVienHopDong(line[1]);
						break;
					case "LT":
						n = new NhanVienBanThoiGian(line[1]);
						break;
				}
				ds.Add(n);
			}
			sr.Close();
		}
		public override string ToString()
		{
			string str = "====================================================================================\n";
			str += "{0} {1} {2} {3} {4} {5}\r\n";
			str = string.Format(str, "Ho Va Ten".PadRight(20), "Ngay Sinh".PadRight(15), "Nhan Vien".PadRight(13), "Thang LV".PadRight(12)
				, "Ngay/Gio".PadRight(10), "Luong".PadRight(10));
			str += "====================================================================================\n";
			foreach (var nv in ds)
			{
				str += nv.ToString();
			}
			str += "====================================================================================\n";
			return str;
		}
		#endregion
		#region Cáu 2
		public int TimSoGioLamViecItNhatTheoThang(int thang)
		{
			int min = int.MaxValue;
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian && nv.thang == thang && ((NhanVienBanThoiGian)nv).gioLV < min)
				{
					min = ((NhanVienBanThoiGian)nv).gioLV;
				}
			}
			return min;
		}
		public DanhSachNhanVien TimNhanVienBanThoiGianCoGioLamViecItNhatTrongMotThang(int month)
		{
			DanhSachNhanVien kq = new DanhSachNhanVien();
			int min = TimSoGioLamViecItNhatTheoThang(month);
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian && nv.thang == month && ((NhanVienBanThoiGian)nv).gioLV == min)
				{
					kq.ThemNV(nv);
				}
			}
			return kq;
		}
		#endregion
		#region Câu 3
		public float TimLuongBanThoiGianTraThapNhat()
		{
			float min = float.MaxValue;
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian && nv.TinhLuong() < min)
					min = nv.TinhLuong();
			}
			return min;
		}
		public List<int> TimThangTraLuongBanThoiGianThapNhat()
		{
			List<int> kq = new List<int>();
			float min = TimLuongBanThoiGianTraThapNhat();
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian && nv.TinhLuong() == min)
				{
					if (!kq.Contains(nv.thang))
						kq.Add(nv.thang);
				}
			}
			return kq;
		}
		#endregion
		#region Câu 4
		public int DemSoNhanVienBanThoiGianTrongThang(int thang)
		{
			int count = 0;
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian && nv.thang == thang)
					count++;
			}
			return count;
		}
		public int TimSoNhanVienBanThoiGianThapNhatTrongThang()
		{
			int min = int.MaxValue;
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian)
				{

					int count = DemSoNhanVienBanThoiGianTrongThang(nv.thang);
					if (count < min)
						min = count;
				}
			}
			return min;
		}
		public List<int> TimThangCoItNhanVienBanThoiGianLamViecNhat()
		{
			List<int> kq = new List<int>();
			int min = TimSoNhanVienBanThoiGianThapNhatTrongThang();
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian && DemSoNhanVienBanThoiGianTrongThang(nv.thang) == min && !kq.Contains(nv.thang))
					kq.Add(nv.thang);
			}
			return kq;
		}
		#endregion
		#region Câu 5
		public List<int> TimThangLamViecCuaNhanVienBanThoiGian()
		{
			List<int> kq = new List<int>();
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian && !kq.Contains(nv.thang))
					kq.Add(nv.thang);
			}
			return kq;
		}
		public List<int> TimThangKhongCoNhanVienBanThoiGianLamViec()
		{
			List<int> kq = new List<int>();
			List<int> thang = TimThangLamViecCuaNhanVienBanThoiGian();
			for (int i = 1; i <= 12; i++)
			{
				if (!thang.Contains(i))
					kq.Add(i);
			}
			return kq;
		}
		#endregion
		#region Câu 6
		public int DemSoLuongNhanVienCungNgaySinhNhatTheoThang(int day, int month, int thangLV)
		{
			int count = 0;
			foreach (var nv in ds)
			{
				if (nv.thang == thangLV && nv.ngaySinh.Day == day && nv.ngaySinh.Month == month)
					count++;
			}
			return count;
		}
		public int TimSoNhanVienCungNgaySinhNhatNhatTheoThang()
		{
			int max = -1;
			foreach (var nv in ds)
			{
				int count = DemSoLuongNhanVienCungNgaySinhNhatTheoThang(nv.ngaySinh.Day, nv.ngaySinh.Month, nv.thang);
				if (max < count)
					max = count;
			}
			return max;
		}
		public List<int> TimThangCoNhieuNhanVienCungNgaySinhLamViecNhat()
		{
			List<int> kq = new List<int>();
			int max = TimSoNhanVienCungNgaySinhNhatNhatTheoThang();
			int count = 0;
			foreach (var nv in ds)
			{
				count = DemSoLuongNhanVienCungNgaySinhNhatTheoThang(nv.ngaySinh.Day, nv.ngaySinh.Month, nv.thang);
				if (count == max && !kq.Contains(nv.thang))
					kq.Add(nv.thang);
			}
			return kq;
		}
		#endregion
		#region Câu 7
		public List<NhanVien> TimNhanVienHopDongCoNgaySinh(int day, int month)
		{
			List<NhanVien> kq = new List<NhanVien>();
			foreach (var nv in ds)
			{
				if (nv is NhanVienHopDong && nv.ngaySinh.Day == day && nv.ngaySinh.Month == month)
					kq.Add(nv);
			}
			return kq;
		}
		public bool KTTonTaiDay(List<NhanVien> nv, List<NhanVien> nguon)
		{
			foreach (var n in nv)
			{
				if (!nguon.Contains(n))
					return false;
			}
			return true;
		}
		public DanhSachNhanVien TimDanhSachNhanVienHopDongCoCungNgaySinh()
		{
			DanhSachNhanVien kq = new DanhSachNhanVien();
			List<NhanVien> nvns = new List<NhanVien>();
			foreach (var nv in ds)
			{
				nvns = TimNhanVienHopDongCoNgaySinh(nv.ngaySinh.Day, nv.ngaySinh.Month);
				if (nvns.Count > 1 && !KTTonTaiDay(nvns, kq.ds))
					kq.ThemDsNV(nvns);
			}
			return kq;
		}
		#endregion
		#region Câu 8
		public void SapXepNhanVienTheoHo()
		{
			NhanVien[] temp = ThuVienDungChung.SapXepNhanVien(ds, KieuSapXep.TheoHo);
			ds = temp.ToList();
		}
		public void SapXepNhanVienTheoTenLot()
		{
			NhanVien[] temp = ThuVienDungChung.SapXepNhanVien(ds, KieuSapXep.TheoTenLot);
			ds = temp.ToList();
		}
		public void SapXepNhanVienTheoTen()
		{
			NhanVien[] temp = ThuVienDungChung.SapXepNhanVien(ds, KieuSapXep.TheoTen);
			ds = temp.ToList();
		}
		#endregion
		#region Câu 9
		public void ThuongThemGioChoNhanVien()
		{
			foreach (var nv in ds)
			{
				if (nv is NhanVienBanThoiGian && nv.thang == 5)
					((NhanVienBanThoiGian)nv).gioLV += 3;
			}
		}
		public void GhiFile(string path)
		{
			StreamWriter sw = new StreamWriter(path);
			sw.WriteLine(this);
			sw.Flush();
			sw.Close();
		}
		#endregion
	}
}
