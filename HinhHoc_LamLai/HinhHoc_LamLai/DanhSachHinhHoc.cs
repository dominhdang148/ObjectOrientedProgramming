using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc_LamLai
{
	class DanhSachHinhHoc
	{
		List<HinhHoc> a = new List<HinhHoc>();
		#region Nhập xuất dữ liệu
		public void ThemHinh(HinhHoc h)
		{
			a.Add(h);
		}
		public void NhapTuFile(string path)
		{
			StreamReader sr = new StreamReader(path);
			string line = "";
			HinhHoc hh = new HinhHoc();
			while ((line = sr.ReadLine()) != null)
			{
				string[] str = line.Split(' ');
				switch (str[0])
				{
					case "HV":
						hh = new HinhVuong(double.Parse(str[1]));
						ThemHinh(hh);
						break;
					case "HT":
						hh = new HinhTron(double.Parse(str[1]));
						ThemHinh(hh);
						break;
					case "HCN":
						hh = new HinhChuNhat(double.Parse(str[1]), double.Parse(str[2]));
						ThemHinh(hh);
						break;
					case "HTG":
						double a = double.Parse(str[1]);
						double b = double.Parse(str[2]);
						double c = double.Parse(str[3]);
						if (HinhTamGiac.KTraTamGiac(a, b, c))
						{
							hh = new HinhTamGiac(a, b, c);
							ThemHinh(hh);
						}
						break;
				}
			}
			sr.Close();
		}
		public override string ToString()
		{
			int i = 1;
			string str = "====================================== DANH SACH HINH HOC ======================================\n";
			foreach (var hinh in a)
			{
				str += i + ") " + hinh.ToString() + "\n";
				i++;
			}
			str += "================================================================================================\n";
			return str;
		}
		#endregion
		#region Generic
		public DanhSachHinhHoc TimHinhCoChuVi<Hinh>(double x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in a)
			{
				if (hh is Hinh && hh.tinhCV().Equals(x))
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhCoDienTich<Hinh>(double x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in a)
			{
				if (hh is Hinh && hh.tinhDT().Equals(x))
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public double TimDTMaxCua<Hinh>()
		{
			double max = -1;
			foreach (var hh in a)
			{
				if (hh is Hinh && hh.tinhDT() > max)
					max = hh.tinhDT();
			}
			return max;
		}
		public double TimCVMaxCua<Hinh>()
		{
			double max = -1;
			foreach (var hh in a)
			{
				if (hh is Hinh && hh.tinhCV() > max)
					max = hh.tinhCV();
			}
			return max;
		}
		public double TimDTMinCua<Hinh>()
		{
			double min = double.MaxValue;
			foreach (var hh in a)
			{
				if (hh is Hinh && hh.tinhDT() < min)
					min = hh.tinhDT();
			}
			return min;
		}
		public double TimCVMinCua<Hinh>()
		{
			double min = double.MaxValue;
			foreach (var hh in a)
			{
				if (hh is Hinh && hh.tinhCV() < min)
					min = hh.tinhCV();
			}
			return min;
		}
		public DanhSachHinhHoc TimHinhCoChuViLonNhat<Hinh>()
		{
			return TimHinhCoChuVi<Hinh>(TimCVMaxCua<Hinh>());
		}
		public DanhSachHinhHoc TimhinhCoChuViNhoNhat<Hinh>()
		{
			return TimHinhCoChuVi<Hinh>(TimCVMinCua<Hinh>());
		}
		public DanhSachHinhHoc TimHinhCoDienTichLonNhat<Hinh>()
		{
			return TimHinhCoDienTich<Hinh>(TimDTMaxCua<Hinh>());
		}
		public DanhSachHinhHoc TimhinhCoDienTichNhoNhat<Hinh>()
		{
			return TimHinhCoDienTich<Hinh>(TimDTMinCua<Hinh>());
		}
		public double TinhTongDienTichCacHinh<Hinh>()
		{
			double s = 0;
			foreach (var hh in a)
			{
				if (hh is Hinh)
					s += hh.tinhDT();
			}
			return s;
		}
		public double TinhTongChuViCacHinh<Hinh>()
		{
			double s = 0;
			foreach (var hh in a)
			{
				if (hh is Hinh)
					s += hh.tinhCV();
			}
			return s;
		}
		public int DemSoLuongHinh<Hinh>()
		{
			int count = 0;
			foreach (var hh in a)
			{
				if (hh is Hinh)
					count++;
			}
			return count;
		}
		public void GhiDanhSachRaFile<Hinh>(string path)
		{
			StreamWriter sw = new StreamWriter(path);
			sw.WriteLine("====================================== DANH SACH HINH HOC ======================================");
			foreach (var hh in a)
			{
				if (hh is Hinh)
					sw.WriteLine(hh);
			}
			sw.WriteLine("================================================================================================");
			sw.Flush();
			sw.Close();
		}
		#endregion
		#region Non-Generic
		public DanhSachHinhHoc TimHinhVuongCoCanh(double x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in a)
			{
				if (hh is HinhVuong && ((HinhVuong)hh).edge == x)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhTronCoBanKinh(double x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in a)
			{
				if (hh is HinhTron && ((HinhTron)hh).radius == x)
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhChuNhatCoChieuDaiChieuRong(double x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in a)
			{
				if (hh is HinhChuNhat && (((HinhChuNhat)hh).length == x || ((HinhChuNhat)hh).width == x))
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public DanhSachHinhHoc TimHinhTamGiacCoCanh(double x)
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			foreach (var hh in a)
			{
				if (hh is HinhTamGiac && (((HinhTamGiac)hh).edgeA == x || ((HinhTamGiac)hh).edgeB == x || ((HinhTamGiac)hh).edgeC == x))
					kq.ThemHinh(hh);
			}
			return kq;
		}
		public double TimCanhHinhVuongNhoNhat()
		{
			double min = double.MaxValue;
			foreach (var hh in a)
			{
				if (hh is HinhVuong && ((HinhVuong)hh).edge < min)
					min = ((HinhVuong)hh).edge;
			}
			return min;
		}
		public double TimBanKinhHinhTronNhoNhat()
		{
			double min = double.MaxValue;
			foreach (var hh in a)
			{
				if (hh is HinhTron && ((HinhTron)hh).radius < min)
					min = ((HinhTron)hh).radius;
			}
			return min;
		}
		public double TimChieuRongHinhChuNhatNhoNhat()
		{
			double min = double.MaxValue;
			foreach (var hh in a)
			{
				if (hh is HinhChuNhat && ((HinhChuNhat)hh).width < min)
					min = ((HinhChuNhat)hh).width;
			}
			return min;
		}
		public double TimCanhHinhTamGiacNhoNhat()
		{
			double min = double.MaxValue;
			foreach (var hh in a)
			{
				if (hh is HinhTamGiac && ((HinhTamGiac)hh).TimCanhNhoNhat() < min)
					min = ((HinhTamGiac)hh).TimCanhNhoNhat();
			}
			return min;
		}
		public double TimCanhHinhVuongLonNhat()
		{
			double max = -1;
			foreach (var hh in a)
			{
				if (hh is HinhVuong && ((HinhVuong)hh).edge > max)
					max = ((HinhVuong)hh).edge;
			}
			return max;
		}
		public double TimBanKinhHinhTronLonNhat()
		{
			double max = -1;
			foreach (var hh in a)
			{
				if (hh is HinhTron && ((HinhTron)hh).radius > max)
					max = ((HinhTron)hh).radius;
			}
			return max;
		}
		public double TimChieuDaiHinhChuNhatLonNhat()
		{
			double max = -1;
			foreach (var hh in a)
			{
				if (hh is HinhChuNhat && ((HinhChuNhat)hh).length > max)
					max = ((HinhChuNhat)hh).length;
			}
			return max;
		}
		public double TimCanhHinhTamGiacLonNhat()
		{
			double max = -1;
			foreach (var hh in a)
			{
				if (hh is HinhTamGiac && ((HinhTamGiac)hh).TimCanhLonNhat() > max)
					max = ((HinhTamGiac)hh).TimCanhLonNhat();
			}
			return max;
		}
		public DanhSachHinhHoc TimHinhVuongCoCanhLonNhat()
		{
			//DanhSachHinhHoc kq = new DanhSachHinhHoc();
			//double max = TimCanhHinhVuongLonNhat();
			//foreach (var hh in a)
			//{
			//	if (hh is HinhVuong && ((HinhVuong)hh).edge == max)
			//		kq.ThemHinh(hh);
			//}
			//return kq;
			return TimHinhVuongCoCanh(TimCanhHinhVuongLonNhat());
		}
		public DanhSachHinhHoc TimnHinhVuongCoCanhNhoNhat()
		{
			return TimHinhVuongCoCanh(TimCanhHinhVuongNhoNhat());
		}
		public DanhSachHinhHoc TimHinhTronCoBanKinhLonNhat()
		{
			return TimHinhTronCoBanKinh(TimBanKinhHinhTronLonNhat());
		}
		public DanhSachHinhHoc TimHinhTronCoBanKinhNhoNhat()
		{
			return TimHinhTronCoBanKinh(TimBanKinhHinhTronNhoNhat());
		}
		public DanhSachHinhHoc TimHinhChuNhatCoChieuDaiLonNhat()
		{
			return TimHinhChuNhatCoChieuDaiChieuRong(TimChieuDaiHinhChuNhatLonNhat());
		}
		public DanhSachHinhHoc TimhinhChuNhatCoChieuRongNhoNhat()
		{
			return TimHinhChuNhatCoChieuDaiChieuRong(TimChieuRongHinhChuNhatNhoNhat());
		}
		public DanhSachHinhHoc TimHinhTamGiacCoCanhLonNhat()
		{
			return TimHinhTamGiacCoCanh(TimCanhHinhTamGiacLonNhat());
		}
		public DanhSachHinhHoc TimHinhTamGiacCoCanhNhoNhat()
		{
			return TimHinhTamGiacCoCanh(TimCanhHinhTamGiacNhoNhat());
		}
		public void SapXepTheoChieuTangDienTich()
		{
			HinhHoc[] tempList = ThuVienDungChung.SapXepHinhHoc(a, KieuSapXep.TangTheoDienTich);
			a = tempList.ToList();
		}
		public void SapXepTheoChieuTangChuVi()
		{
			HinhHoc[] tempList = ThuVienDungChung.SapXepHinhHoc(a, KieuSapXep.TangTheoChuVi);
			a = tempList.ToList();
		}
		public void SapXepTheoChieuGiamDienTich()
		{
			HinhHoc[] tempList = ThuVienDungChung.SapXepHinhHoc(a, KieuSapXep.GiamTheoDienTich);
			a = tempList.ToList();
		}
		public void SapXepTheoChieuGiamChuVi()
		{
			HinhHoc[] tempList = ThuVienDungChung.SapXepHinhHoc(a, KieuSapXep.GiamTheoChuVi);
			a = tempList.ToList();
		}
		public DanhSachHinhHoc HienThiDanhSachTheoChieuTangDienTich()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			kq.a = (ThuVienDungChung.SapXepHinhHoc(a, KieuSapXep.TangTheoDienTich)).ToList();
			return kq;
		}
		public DanhSachHinhHoc HienThiDanhSachTheoChieuTangChuVi()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			kq.a = (ThuVienDungChung.SapXepHinhHoc(a, KieuSapXep.TangTheoChuVi)).ToList();
			return kq;
		}
		public DanhSachHinhHoc HienThiDanhSachTheoChieuGiamDienTich()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			kq.a = (ThuVienDungChung.SapXepHinhHoc(a, KieuSapXep.GiamTheoDienTich)).ToList();
			return kq;
		}
		public DanhSachHinhHoc HienThiDanhSachTheoChieuGiamChuVi()
		{
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			kq.a = (ThuVienDungChung.SapXepHinhHoc(a, KieuSapXep.GiamTheoDienTich)).ToList();
			return kq;
		}
		public void XoaHinhCoDienTichLonNhat()
		{
			a.RemoveAll(x => x.tinhDT().Equals(TimDTMaxCua<HinhHoc>()));
		}
		public void XoaHinhCoDienTichNhoNhat()
		{
			a.RemoveAll(x => x.tinhDT().Equals(TimDTMinCua<HinhHoc>()));
		}
		public void XoaHinhCoChuViLonNhat()
		{
			a.RemoveAll(x => x.tinhCV().Equals(TimCVMaxCua<HinhHoc>()));
		}
		public void XoaHinhCoChuViNhoNhat()
		{
			a.RemoveAll(x => x.tinhCV().Equals(TimCVMinCua<HinhHoc>()));
		}
		public bool XoaHinhTaiViTri(int index)
		{
			if (0 <= index && index < a.Count())
			{
				a.RemoveAt(index);
				return true;
			}
			return false;
		}
		public bool ThemHinhVaoViTri(HinhHoc obj, int index)
		{
			if (0 <= index && index <= a.Count)
			{
				a.Insert(index, obj);
				return true;
			}
			return false;
		}
		#endregion
	}
}
