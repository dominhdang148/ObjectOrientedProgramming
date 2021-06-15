using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_NangCap
{
	enum XoaHinh
	{
		Thoat = 0,
		XoaHinhCoDTLonNhat,
		XoaHinhCoDTNhoNhat,
		XoaHinhCoCVLonNhat,
		XoaHinhCoCVNhoNhat
	}
	enum KieuSapXep
	{
		Thoat = 0,
		SapXepTheoChieuTangDienTich,
		SapXepTheoChieuGiamDienTich,
		SapXepTheoChieuTangChuVi,
		SapXepTheoChieuGiamChuVi
	}
	enum KieuHinh
	{
		Thoat = 0,
		HinhVuong,
		HinhTron,
		HinhChuNhat
	}
	enum Menu
	{
		Thoat = 0,
		NhapFile,
		XuatDanhSach,
		TimHinhCoDienTich,
		TimHinhCoChuVi,
		TimHinhCoDienTichLonNhatNhoNhat,
		TimHinhCoChuViLonNhatNhoNhat,
		DemSoLuongHinh,
		TimHinhCoCanhLonNhatNhoNhat,
		TongChuViHinh,
		TongDienTichHinh,
		SapXepDanhSach,
		TimHinhCoDienTichLonNhatNhoNhatTrongDanhSach,
		TimHinhCoChuViLonNhatNhoNhatTrongDanhSach,
		HienThiDanhSachHinhTheo,
		XoaHinhRaKhoiDanhSach,
		TongChuViDienTich,
		GhiRiengDanhSachHinhHoc
	}
	class MenuClass
	{
		public static void XuatMenu()
		{
			Console.Clear();
			Console.WriteLine("========================== QUAN LY HINH HOC - V2 ==========================");
			Console.WriteLine("{0}. Thoat chuong trinh", (int)Menu.Thoat);
			Console.WriteLine("{0}. Nhap du lieu tu file", (int)Menu.NhapFile);
			Console.WriteLine("{0}. Xem danh sach hien hanh", (int)Menu.XuatDanhSach);
			Console.WriteLine("{0}. Tim hinh co dien tich", (int)Menu.TimHinhCoDienTich);
			Console.WriteLine("{0}. Tim hinh co chu vi", (int)Menu.TimHinhCoChuVi);
			Console.WriteLine("{0}. Tim hinh co dien tich lon nhat, nho nhat", (int)Menu.TimHinhCoDienTichLonNhatNhoNhat);
			Console.WriteLine("{0}. Tim hinh co chu vi lon nhat, nho nhat", (int)Menu.TimHinhCoChuViLonNhatNhoNhat);
			Console.WriteLine("{0}. Dem so luong hinh", (int)Menu.DemSoLuongHinh);
			Console.WriteLine("{0}. Tim hinh co canh/ban kinh lon nhat nho nhat", (int)Menu.TimHinhCoCanhLonNhatNhoNhat);
			Console.WriteLine("{0}. Tinh tong chu vi cac hinh", (int)Menu.TongChuViHinh);
			Console.WriteLine("{0}. Tinh tong dien tich cac hinh", (int)Menu.TongDienTichHinh);
			Console.WriteLine("{0}. Sap xep danh sach hinh ", (int)Menu.SapXepDanhSach);
			Console.WriteLine("{0}. Tim hinh co dien tich lon nhat/nho nhat trong danh sach", (int)Menu.TimHinhCoDienTichLonNhatNhoNhatTrongDanhSach);
			Console.WriteLine("{0}. Tim hinh co chu vi lon nhat/nho nhat trong danh sach", (int)Menu.TimHinhCoChuViLonNhatNhoNhatTrongDanhSach);
			Console.WriteLine("{0}. Hien thi danh sach hinh theo", (int)Menu.HienThiDanhSachHinhTheo);
			Console.WriteLine("{0}. Xoa hinh ra khoi danh sach", (int)Menu.XoaHinhRaKhoiDanhSach);
			Console.WriteLine("{0}. Tinh tong chu vi, dien tich tat ca cac hinh trong danh sach", (int)Menu.TongChuViDienTich);
			Console.WriteLine("{0}. Ghi danh sach cac hinh ra file rieng", (int)Menu.GhiRiengDanhSachHinhHoc);
			Console.WriteLine("===========================================================================");
		}
		public static Menu ChonMenu()
		{
			XuatMenu();
			Console.Write("Nhap 1 so de chon chuc nang tuong ung: ");
			Menu menu = (Menu)int.Parse(Console.ReadLine());
			return menu;
		}
		public static void XuLyMenu(DanhSachHinhHoc ds, Menu menu)
		{
			int count = 0;
			float x = 0;
			int choose = 1;
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			Console.Clear();
			choose = 1;
			switch (menu)
			{
				#region Case 0
				case Menu.Thoat:
					return;
				#endregion
				#region Case 1
				case Menu.NhapFile:
					ds.NhapTuFile();
					Console.WriteLine("Danh sach cac hinh sau khi nhap: ");
					Console.WriteLine("==========================================================================");
					Console.WriteLine(ds);
					ds.ToString();
					Console.ReadKey();
					break;
				#endregion
				#region Case 2
				case Menu.XuatDanhSach:
					Console.WriteLine(ds);
					ds.ToString();
					Console.ReadKey();
					break;
				#endregion
				#region Case 3
				case Menu.TimHinhCoDienTich:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== DANH SACH HINH ====================");
						Console.WriteLine("{0} Thoat chuc nang", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("========================================================");
						Console.Write("Xin hay nhap 1 so de chon kieu hinh: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								Console.Write("Xin hay nhap dien tich can tim: ");
								x = float.Parse(Console.ReadLine());
								kq = ds.TimHinhVuongCoDienTich(x);
								Console.WriteLine("Danh sach hinh vuong co dien tich " + x + " la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								Console.Write("Xin hay nhap dien tich can tim: ");
								x = float.Parse(Console.ReadLine());
								kq = ds.TimHinhTronCoDienTich(x);
								Console.WriteLine("Danh sach hinh tron co dien tich " + x + " la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								Console.Write("Xin hay nhap dien tich can tim: ");
								x = float.Parse(Console.ReadLine());
								kq = ds.TimHinhChuNhatCoDienTich(x);
								Console.WriteLine("Danh sach hinh chu nhat co dien tich " + x + " la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 4
				case Menu.TimHinhCoChuVi:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== DANH SACH HINH ====================");
						Console.WriteLine("{0} Thoat chuc nang", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("========================================================");
						Console.Write("Xin hay nhap 1 so de chon kieu hinh: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								Console.Write("Xin hay nhap chu vi can tim: ");
								x = float.Parse(Console.ReadLine());
								kq = ds.TimHinhVuongCoChuVi(x);
								Console.WriteLine("Danh sach hinh vuong co chu vi " + x + " la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								Console.Write("Xin hay nhap chu vi can tim: ");
								x = float.Parse(Console.ReadLine());
								kq = ds.TimHinhTronCoChuVi(x);
								Console.WriteLine("Danh sach hinh tron co chu vi " + x + " la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								Console.Write("Xin hay nhap chu vi can tim: ");
								x = float.Parse(Console.ReadLine());
								kq = ds.TimHinhChuNhatCoChuVi(x);
								Console.WriteLine("Danh sach hinh chu nhat co chu vi " + x + " la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 5
				case Menu.TimHinhCoDienTichLonNhatNhoNhat:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== DANH SACH HINH ====================");
						Console.WriteLine("{0} Thoat chuc nang", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("========================================================");
						Console.Write("Xin hay nhap 1 so de chon kieu hinh: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								kq = ds.TimHinhVuongCoDienTichLonNhat();
								Console.WriteLine("Danh sach hinh vuong co dien tich lon nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhVuongCoDienTichNhoNhat();
								Console.WriteLine("Danh sach hinh vuong co dien tich nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh:");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								kq = ds.TimHinhTronCoDienTichLonNhat();
								Console.WriteLine("Danh sach hinh tron co dien tich lon nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhTronCoDienTichNhoNhat();
								Console.WriteLine("Danh sach hinh tron co dien tich nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								kq = ds.TimHinhChuNhatCoDienTichLonNhat();
								Console.WriteLine("Danh sach hinh chu nhat co dien tich lon nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhChuNhatCoDienTichNhoNhat();
								Console.WriteLine("Danh sach hinh chu nhat co dien tich nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 6
				case Menu.TimHinhCoChuViLonNhatNhoNhat:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== DANH SACH HINH ====================");
						Console.WriteLine("{0} Thoat chuc nang", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("========================================================");
						Console.Write("Xin hay nhap 1 so de chon kieu hinh: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								kq = ds.TimHinhVuongCoChuViLonNhat();
								Console.WriteLine("Danh sach hinh vuong co chu vi lon nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhVuongCoChuViNhoNhat();
								Console.WriteLine("Danh sach hinh vuong co chu vi nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh:");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								kq = ds.TimHinhTronCoChuViLonNhat();
								Console.WriteLine("Danh sach hinh tron co chu vi lon nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhTronCoChuViNhoNhat();
								Console.WriteLine("Danh sach hinh tron co chu vi nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								kq = ds.TimHinhChuNhatCoChuViLonNhat();
								Console.WriteLine("Danh sach hinh chu nhat co chu vi lon nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhChuNhatCoChuViNhoNhat();
								Console.WriteLine("Danh sach hinh chu nhat co chu vi nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 7
				case Menu.DemSoLuongHinh:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== DANH SACH HINH ====================");
						Console.WriteLine("{0} Thoat chuc nang", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("========================================================");
						Console.Write("Xin hay nhap 1 so de chon kieu hinh: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								count = ds.DemSoLuongHinh<HinhVuong>();
								Console.WriteLine("Co tat ca {0} hinh vuong trong danh sach", count);
								Console.WriteLine("Danh sach hinh hien hanh:");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								count = ds.DemSoLuongHinh<HinhTron>();
								Console.WriteLine("Co tat ca {0} hinh tron trong danh sach", count);
								Console.WriteLine("Danh sach hinh hien hanh ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								count = ds.DemSoLuongHinh<HinhChuNhat>();
								Console.WriteLine("Co tat ca {0} hinh chu nhat trong danh sach", count);
								Console.WriteLine("Danh sach hinh hien hanh: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 8
				case Menu.TimHinhCoCanhLonNhatNhoNhat:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== DANH SACH HINH ====================");
						Console.WriteLine("{0} Thoat chuc nang", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("========================================================");
						Console.Write("Xin hay nhap 1 so de chon kieu hinh: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								kq = ds.TimHinhVuongCoCanhLonNhat();
								Console.WriteLine("Danh sach hinh vuong co canh lon nhat la:");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhVuongCoCanhNhoNhat();
								Console.WriteLine("Danh sach hinh vuong co canh nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh:");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								kq = ds.TimHinhTronCoBanKinhLonNhat();
								Console.WriteLine("Danh sach hinh tron co ban kinh lon nhat la:");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhTronCoBanKinhNhoNhat();
								Console.WriteLine("Danh sach  hinh tron co ban kinh nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								kq = ds.TimHinhChuNhatCoChieuDaiLonNhat();
								Console.WriteLine("Danh sach hinh chu nhat co chieu dai lon nhat la:");
								Console.WriteLine(kq);
								kq.ToString();
								kq = ds.TimHinhChuNhatCoChieuRongNhoNhat();
								Console.WriteLine("Danh sach  hinh chu nhat co chieu rong nho nhat la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.WriteLine("Danh sach hinh hien hanh: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 9
				case Menu.TongChuViHinh:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== DANH SACH HINH ====================");
						Console.WriteLine("{0} Thoat chuc nang", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("========================================================");
						Console.Write("Xin hay nhap 1 so de chon kieu hinh: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								x = ds.TinhTongChuVi<HinhVuong>();
								Console.WriteLine("Tong chu vi cua tat ca hinh vuong trong danh sach la " + x);
								Console.WriteLine("Danh sach hinh hien hanh:");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								x = ds.TinhTongChuVi<HinhTron>();
								Console.WriteLine("Tong chu vi cua tat ca hinh tron trong danh sach la " + x);
								Console.WriteLine("Danh sach hinh hien hanh ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								x = ds.TinhTongChuVi<HinhChuNhat>();
								Console.WriteLine("Tong chu vi cua tat ca hinh chu nhat trong danh sach la " + x);
								Console.WriteLine("Danh sach hinh hien hanh: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 10
				case Menu.TongDienTichHinh:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== DANH SACH HINH ====================");
						Console.WriteLine("{0} Thoat chuc nang", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("========================================================");
						Console.Write("Xin hay nhap 1 so de chon kieu hinh: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								x = ds.TinhTongDienTich<HinhVuong>();
								Console.WriteLine("Tong dien tich cua tat ca hinh vuong trong danh sach la " + x);
								Console.WriteLine("Danh sach hinh hien hanh:");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								x = ds.TinhTongDienTich<HinhTron>();
								Console.WriteLine("Tong dien tich cua tat ca hinh tron trong danh sach la " + x);
								Console.WriteLine("Danh sach hinh hien hanh ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								x = ds.TinhTongDienTich<HinhChuNhat>();
								Console.WriteLine("Tong dien tich cua tat ca hinh chu nhat trong danh sach la " + x);
								Console.WriteLine("Danh sach hinh hien hanh: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 11
				case Menu.SapXepDanhSach:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== KIEU SAP XEP ====================");
						Console.WriteLine("{0}. Thoat chuc nang", (int)KieuSapXep.Thoat);
						Console.WriteLine("{0}. Sap xep theo chieu tang cua dien tich", (int)KieuSapXep.SapXepTheoChieuTangDienTich);
						Console.WriteLine("{0}. Sap xep theo chieu giam cua dien tich", (int)KieuSapXep.SapXepTheoChieuGiamDienTich);
						Console.WriteLine("{0}. Sap xep theo chieu tang cua chu vi", (int)KieuSapXep.SapXepTheoChieuTangChuVi);
						Console.WriteLine("{0}. Sap xep theo chieu giam cua chu vi", (int)KieuSapXep.SapXepTheoChieuGiamChuVi);
						Console.WriteLine("======================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuSapXep sortType = (KieuSapXep)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (sortType)
						{
							case KieuSapXep.Thoat:
								choose = 0;
								break;
							case KieuSapXep.SapXepTheoChieuTangDienTich:
								ds.SapXepTheoChieuTangDienTich();
								Console.WriteLine("Danh sach sau khi sap xep: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuSapXep.SapXepTheoChieuGiamDienTich:
								ds.SapXepTheoChieuGiamDienTich();
								Console.WriteLine("Danh sach sau khi sap xep: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuSapXep.SapXepTheoChieuTangChuVi:
								ds.SapXepTheoChieuTangChuVi();
								Console.WriteLine("Danh sach sau khi sap xep: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case KieuSapXep.SapXepTheoChieuGiamChuVi:
								ds.SapXepTheoChieuGiamChuVi();
								Console.WriteLine("Danh sach sau khi sap xep: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 12
				case Menu.TimHinhCoDienTichLonNhatNhoNhatTrongDanhSach:
					kq = ds.TimHinhCoDienTichLonNhat();
					Console.WriteLine("Danh sach hinh co dien tich lon nhat la: ");
					Console.WriteLine(kq);
					kq.ToString();
					kq = ds.TimHinhCoDienTichNhoNhat();
					Console.WriteLine("Danh sach hinh co dien tich nho nhat la: ");
					Console.WriteLine(kq);
					kq.ToString();
					Console.WriteLine("Danh sach sau khi sap xep: ");
					Console.WriteLine(ds);
					ds.ToString();
					Console.ReadKey();
					break;
				#endregion
				#region Case 13
				case Menu.TimHinhCoChuViLonNhatNhoNhatTrongDanhSach:
					kq = ds.TimHinhCoChuViLonNhat();
					Console.WriteLine("Danh sach hinh co chu vi lon nhat la: ");
					Console.WriteLine(kq);
					kq.ToString();
					kq = ds.TimHinhCoChuViNhoNhat();
					Console.WriteLine("Danh sach hinh co chu vi nho nhat la: ");
					Console.WriteLine(kq);
					kq.ToString();
					Console.WriteLine("Danh sach sau khi sap xep: ");
					Console.WriteLine(ds);
					ds.ToString();
					Console.ReadKey();
					break;
				#endregion
				#region Case 14
				case Menu.HienThiDanhSachHinhTheo:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("==================== KIEU HIEN THI ====================");
						Console.WriteLine("{0}. Thoat chuc nang", (int)KieuSapXep.Thoat);
						Console.WriteLine("{0}. Hien thi theo chieu tang cua dien tich", (int)KieuSapXep.SapXepTheoChieuTangDienTich);
						Console.WriteLine("{0}. Hien thi theo chieu giam cua dien tich", (int)KieuSapXep.SapXepTheoChieuGiamDienTich);
						Console.WriteLine("{0}. Hien thi theo chieu tang cua chu vi", (int)KieuSapXep.SapXepTheoChieuTangChuVi);
						Console.WriteLine("{0}. Hien thi theo chieu giam cua chu vi", (int)KieuSapXep.SapXepTheoChieuGiamChuVi);
						Console.WriteLine("=======================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuSapXep sortType = (KieuSapXep)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (sortType)
						{
							case KieuSapXep.Thoat:
								choose = 0;
								break;
							case KieuSapXep.SapXepTheoChieuTangDienTich:
								kq = ds.HienThiDanhSachHinhTheoChieuTangDienTich();
								Console.WriteLine("Danh sach hinh theo chieu tang cua dien tich la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							case KieuSapXep.SapXepTheoChieuGiamDienTich:
								kq = ds.HienThiDanhSachHinhTheoChieuGiamDienTich();
								Console.WriteLine("Danh sach hinh theo chieu giam cua dien tich la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							case KieuSapXep.SapXepTheoChieuTangChuVi:
								kq = ds.HienThiDanhSachHinhTheoChieuTangChuVi();
								Console.WriteLine("Danh sach hinh theo chieu tang cua chu vi la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							case KieuSapXep.SapXepTheoChieuGiamChuVi:
								kq = ds.HienThiDanhSachHinhTheoChieuGiamChuVi();
								Console.WriteLine("Danh sach hinh theo chieu giam cua chu vi la: ");
								Console.WriteLine(kq);
								kq.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 15
				case Menu.XoaHinhRaKhoiDanhSach:
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("================ XOA HINH RA KHOI DANH SACH ================");
						Console.WriteLine("{0}. Thoat chuc nang", (int)XoaHinh.Thoat);
						Console.WriteLine("{0}. Xoa hinh co dien tich lon nhat", (int)XoaHinh.XoaHinhCoDTLonNhat);
						Console.WriteLine("{0}. Xoa hinh co dien tich nho nhat", (int)XoaHinh.XoaHinhCoDTNhoNhat);
						Console.WriteLine("{0}. Xoa hinh co chu vi lon nhat", (int)XoaHinh.XoaHinhCoCVLonNhat);
						Console.WriteLine("{0}. Xoa hinh co chu vi nho nhat", (int)XoaHinh.XoaHinhCoCVNhoNhat);
						Console.WriteLine("============================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						XoaHinh del = (XoaHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (del)
						{
							case XoaHinh.Thoat:
								choose = 0;
								break;
							case XoaHinh.XoaHinhCoDTLonNhat:
								ds.XoaHinhCoDienTichLonNhat();
								Console.WriteLine("Xoa thanh cong! Danh sach sau khi xoa: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case XoaHinh.XoaHinhCoDTNhoNhat:
								ds.XoaHinhCoDienTichNhoNhat();
								Console.WriteLine("Xoa thanh cong! Danh sach sau khi xoa: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case XoaHinh.XoaHinhCoCVLonNhat:
								ds.XoaHinhCoChuViLonNhat();
								Console.WriteLine("Xoa thanh cong! Danh sach sau khi xoa: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							case XoaHinh.XoaHinhCoCVNhoNhat:
								ds.XoaHinhCoChuViNhoNhat();
								Console.WriteLine("Xoa thanh cong! Danh sach sau khi xoa: ");
								Console.WriteLine(ds);
								ds.ToString();
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 16
				case Menu.TongChuViDienTich:
					Console.WriteLine(ds);
					x = ds.TinhTongDienTich<HinhHoc>();
					Console.WriteLine("Tong dien tich cua tat ca cac hinh trong danh sach la: " + x);
					Console.WriteLine("==================================================================");
					x = ds.TinhTongChuVi<HinhHoc>();
					Console.WriteLine("Tong chu vi cua tat ca cac hinh trong danh sach la: " + x);
					Console.ReadKey();
					break;
				#endregion
				#region Case 17
				case Menu.GhiRiengDanhSachHinhHoc:
					ds.GhiDanhSach<HinhVuong>("D:\\DanhSachHinhHoc\\HinhVuong.txt");
					ds.GhiDanhSach<HinhTron>("D:\\DanhSachHinhHoc\\HinhTron.txt");
					ds.GhiDanhSach<HinhChuNhat>("D:\\DanhSachHinhHoc\\HinhChuNhat.txt");
					Console.WriteLine("Da ghi xong!. Xin hay vao folder DanhSachHinhHoc trong o dia D de xem ket qua!");
					Console.ReadKey();
					break;
				#endregion
				default:
					break;
			}
		}
	}
}
