using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_NangCap
{
	class DanhSachHinhHoc
	{
		List<HinhHoc> DanhSach = new List<HinhHoc>();
		#region Nhập Xuất Dữ Liệu
		public void ThemHinh(HinhHoc hh)
		{
			DanhSach.Add(hh);
		}
		public void NhapTuFile()
		{
			HinhHoc hh = new HinhHoc();
			string path = "D:HinhHoc.txt";
			StreamReader sr = new StreamReader(path);
			string s = "";
			while ((s = sr.ReadLine()) != null)
			{
				string[] line = s.Split(' ');
				switch (line[0])
				{
					case "HV":
						hh = new HinhVuong(float.Parse(line[1]));
						break;
					case "HCN":
						hh = new HinhChuNhat(float.Parse(line[1]), float.Parse(line[2]));
						break;
					case "HT":
						hh = new HinhTron(float.Parse(line[1]));
						break;
				}
				ThemHinh(hh);
			}
			sr.Close();
		}
		public override string ToString()
		{
			string s = "DANH SACH HINH HOC\n==========================================================================\n";
			foreach (var hh in DanhSach)
			{
				s += hh + "\n";
			}
			s += "==========================================================================\n";
			return s;
		}
		#endregion
		#region Hình Vuông
		public DanhSachHinhHoc TimHinhVuong()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhVuong)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhVuongCoDienTich(float x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhVuong && hh.DT==x)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhVuongCoChuVi(float x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhVuong && hh.CV == x)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhVuongCoDienTichLonNhat()
		{
			return TimHinhVuongCoDienTich(TimDTMax<HinhVuong>());
		}
		public DanhSachHinhHoc TimHinhVuongCoDienTichNhoNhat()
		{
			return TimHinhVuongCoDienTich(TimDTMin<HinhVuong>());
		}
		public DanhSachHinhHoc TimHinhVuongCoChuViLonNhat()
		{
			return TimHinhVuongCoChuVi(TimCVMax<HinhVuong>());
		}
		public DanhSachHinhHoc TimHinhVuongCoChuViNhoNhat()
		{
			return TimHinhVuongCoChuVi(TimCVMin<HinhVuong>());
		}
		public float TimCanhHVLonNhat()
		{
			float max = -1;
			foreach(var hh in DanhSach)
			{
				if (hh is HinhVuong && ((HinhVuong)hh).canh > max)
					max = ((HinhVuong)hh).canh;
			}
			return max;
		}
		public float TimCanhHVNhoNhat()
		{
			float min = float.MaxValue;
			foreach (var hh in DanhSach)
			{
				if (hh is HinhVuong && ((HinhVuong)hh).canh < min)
					min = ((HinhVuong)hh).canh;
			}
			return min;
		}
		public DanhSachHinhHoc TimHinhVuongCoCanhLonNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max = TimCanhHVLonNhat();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhVuong && ((HinhVuong)hh).canh == max)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhVuongCoCanhNhoNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min = TimCanhHVNhoNhat();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhVuong && ((HinhVuong)hh).canh == min)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		#endregion
		#region Hình Tròn
		public DanhSachHinhHoc TimHinhTron()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhTron)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhTronCoDienTich(float x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhTron && hh.DT == x)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhTronCoChuVi(float x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhTron && hh.CV == x)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhTronCoDienTichLonNhat()
		{
			return TimHinhTronCoDienTich(TimDTMax<HinhTron>());
		}
		public DanhSachHinhHoc TimHinhTronCoDienTichNhoNhat()
		{
			return TimHinhTronCoDienTich(TimDTMin<HinhTron>());
		}
		public DanhSachHinhHoc TimHinhTronCoChuViLonNhat()
		{
			return TimHinhTronCoChuVi(TimCVMax<HinhTron>());
		}
		public DanhSachHinhHoc TimHinhTronCoChuViNhoNhat()
		{
			return TimHinhTronCoChuVi(TimCVMin<HinhTron>());
		}
		public float TimBanKinhLonNhat()
		{
			float max = -1;
			foreach (var hh in DanhSach)
			{
				if (hh is HinhTron && ((HinhTron)hh).banKinh > max)
					max = ((HinhTron)hh).banKinh;
			}
			return max;
		}
		public float TimBanKinhNhoNhat()
		{
			float min=float.MaxValue;
			foreach (var hh in DanhSach)
			{
				if (hh is HinhTron && ((HinhTron)hh).banKinh < min)
					min = ((HinhTron)hh).banKinh;
			}
			return min;
		}
		public DanhSachHinhHoc TimHinhTronCoBanKinhLonNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max = TimBanKinhLonNhat();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhTron && ((HinhTron)hh).banKinh == max)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhTronCoBanKinhNhoNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min= TimBanKinhNhoNhat();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhTron && ((HinhTron)hh).banKinh == min)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		#endregion
		#region HÌnh Chữ Nhật
		public DanhSachHinhHoc TimHinhChuNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhChuNhat)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhChuNhatCoDienTich(float x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhChuNhat && hh.DT == x)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhChuNhatCoChuVi(float x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhChuNhat && hh.CV == x)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhChuNhatCoDienTichLonNhat()
		{
			return TimHinhChuNhatCoDienTich(TimDTMax<HinhChuNhat>());
		}
		public DanhSachHinhHoc TimHinhChuNhatCoDienTichNhoNhat()
		{
			return TimHinhChuNhatCoDienTich(TimDTMin<HinhChuNhat>());
		}
		public DanhSachHinhHoc TimHinhChuNhatCoChuViLonNhat()
		{
			return TimHinhChuNhatCoChuVi(TimCVMax<HinhChuNhat>());
		}
		public DanhSachHinhHoc TimHinhChuNhatCoChuViNhoNhat()
		{
			return TimHinhChuNhatCoChuVi(TimCVMin<HinhChuNhat>());
		}
		public float TimChieuDaiLonNhat()
		{
			float m = -1;
			foreach (var hh in DanhSach)
			{
				if (hh is HinhChuNhat && ((HinhChuNhat)hh).chieuDai > m)
					m = ((HinhChuNhat)hh).chieuDai;
			}
			return m;
		}
		public float TimChieuRongNhoNhat()
		{
			float m = float.MaxValue;
			foreach (var hh in DanhSach)
			{
				if (hh is HinhChuNhat && ((HinhChuNhat)hh).chieuDai < m)
					m = ((HinhChuNhat)hh).chieuRong;
			}
			return m;
		}
		public DanhSachHinhHoc TimHinhChuNhatCoChieuDaiLonNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float m = TimChieuDaiLonNhat();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhChuNhat && ((HinhChuNhat)hh).chieuDai == m)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhChuNhatCoChieuRongNhoNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float m = TimChieuRongNhoNhat();
			foreach (var hh in DanhSach)
			{
				if (hh is HinhChuNhat && ((HinhChuNhat)hh).chieuRong == m)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		#endregion
		#region Generic
		public float TimDTMax<T>()
		{
			float max = -1;
			foreach (var hh in DanhSach)
			{
				if (hh is T && hh.DT > max)
					max = hh.DT;
			}
			return max;
		}
		public float TimDTMin<T>()
		{
			float min = float.MaxValue;
			foreach (var hh in DanhSach)
			{
				if (hh is T && hh.DT < min)
					min = hh.DT;
			}
			return min;
		}
		public float TimCVMax<T>()
		{
			float max = -1;
			foreach (var hh in DanhSach)
			{
				if (hh is T && hh.CV > max)
					max = hh.CV;
			}
			return max;
		}
		public float TimCVMin<T>()
		{
			float min = float.MaxValue;	
			foreach (var hh in DanhSach)
			{
				if (hh is T && hh.CV < min)
					min = hh.CV;
			}
			return min;
		}
		public float TinhTongChuVi<Hinh>()
		{
			float sum = 0;
			foreach (var hh in DanhSach)
			{
				if (hh is Hinh)
					sum += hh.CV;
			}
			return sum;
		}
		public float TinhTongDienTich<Hinh>()
		{
			float sum = 0;
			foreach (var hh in DanhSach)
			{
				if (hh is Hinh)
					sum += hh.DT;
			}
			return sum;
		}
		public int DemSoLuongHinh<hinh>()
		{
			int count = 0;
			foreach (var hh in DanhSach)
			{
				if (hh is hinh)
				{
					count++;
				}

			}
			return count;
		}
		public void GhiDanhSach<Hinh>(string path)
		{
			StreamWriter sw = new StreamWriter(path);
			sw.WriteLine("============================ DANH SACH HINH HOC ============================");
			foreach (var hh in DanhSach)
			{
				if (hh is Hinh)
					sw.WriteLine(hh);
			}
			sw.WriteLine("============================================================================");
			sw.Flush();
			sw.Close();
		}
		#endregion
		#region Non-Generic
		public void SapXepTheoChieuTangDienTich()
		{
			HinhHoc[] temp = ThuVienDungChung.SapXepDanhSach(DanhSach, KieuSapXep.SapXepTheoChieuTangDienTich);
			DanhSach = temp.ToList();
		}
		public void SapXepTheoChieuGiamDienTich()
		{
			HinhHoc[] temp = ThuVienDungChung.SapXepDanhSach(DanhSach, KieuSapXep.SapXepTheoChieuGiamDienTich);
			DanhSach = temp.ToList();
		}
		public void SapXepTheoChieuTangChuVi()
		{
			HinhHoc[] temp = ThuVienDungChung.SapXepDanhSach(DanhSach, KieuSapXep.SapXepTheoChieuTangChuVi);
			DanhSach = temp.ToList();
		}
		public void SapXepTheoChieuGiamChuVi()
		{
			HinhHoc[] temp = ThuVienDungChung.SapXepDanhSach(DanhSach, KieuSapXep.SapXepTheoChieuGiamChuVi);
			DanhSach = temp.ToList();
		}
		public DanhSachHinhHoc TimHinhCoDienTichLonNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max = TimDTMax<HinhHoc>();
			foreach (var hh in DanhSach)
			{
				if (hh.DT == max)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhCoDienTichNhoNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min = TimDTMin<HinhHoc>();
			foreach (var hh in DanhSach)
			{
				if (hh.DT == min)
					kq.ThemHinh(hh);
			}
			return kq; 
		}
		public DanhSachHinhHoc TimHinhCoChuViLonNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float max = TimCVMax<HinhHoc>();
			foreach (var hh in DanhSach)
			{
				if (hh.CV == max)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhCoChuViNhoNhat()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			float min = TimCVMin<HinhHoc>();
			foreach (var hh in DanhSach)
			{
				if (hh.CV == min)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc HienThiDanhSachHinhTheoChieuTangDienTich()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			HinhHoc[] temp = ThuVienDungChung.SapXepDanhSach(DanhSach, KieuSapXep.SapXepTheoChieuTangDienTich);
			kq.DanhSach = temp.ToList();
			return kq;
		}
		public DanhSachHinhHoc HienThiDanhSachHinhTheoChieuGiamDienTich()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			HinhHoc[] temp = ThuVienDungChung.SapXepDanhSach(DanhSach, KieuSapXep.SapXepTheoChieuGiamDienTich);
			kq.DanhSach = temp.ToList();
			return kq;
		}
		public DanhSachHinhHoc HienThiDanhSachHinhTheoChieuTangChuVi()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			HinhHoc[] temp = ThuVienDungChung.SapXepDanhSach(DanhSach, KieuSapXep.SapXepTheoChieuTangChuVi);
			kq.DanhSach = temp.ToList();
			return kq;
		}
		public DanhSachHinhHoc HienThiDanhSachHinhTheoChieuGiamChuVi()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			HinhHoc[] temp = ThuVienDungChung.SapXepDanhSach(DanhSach, KieuSapXep.SapXepTheoChieuGiamChuVi);
			kq.DanhSach = temp.ToList();
			return kq;
		}
		public void XoaHinhCoDienTich(float dt)
		{
			DanhSach.RemoveAll(x => x.DT.Equals(dt));
		}
		public void XoaHinhCoChuVi(float cv)
		{
			DanhSach.RemoveAll(x => x.CV.Equals(cv));
		}
		public void XoaHinhCoDienTichLonNhat()
		{
			XoaHinhCoDienTich(TimDTMax<HinhHoc>());
		}
		public void XoaHinhCoDienTichNhoNhat()
		{
			XoaHinhCoDienTich(TimDTMin<HinhHoc>());
		}
		public void XoaHinhCoChuViLonNhat()
		{
			XoaHinhCoChuVi(TimCVMax<HinhHoc>());
		}
		public void XoaHinhCoChuViNhoNhat()
		{
			XoaHinhCoChuVi(TimCVMin<HinhHoc>());
		}

		#endregion
	}
}
