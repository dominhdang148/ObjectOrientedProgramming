using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc_LamLai
{
	enum Menu
	{
		ThoatChuongTrinh = 0,
		NhapFile,
		XuatDanhSach,
		TimTatCaHinhV_T_CN_TGCoDienTichX,
		TimTatCaHinhV_T_CN_TGCoChuViX,
		TimTatCaHinhV_T_CN_TGCoChuViMax_Min,
		TimTatCaHinhV_T_CN_TGCoDienTichMax_Min,
		TimHinhV_T_CN_TGCoCanhNhoNhat_LonNhat,
		TinhTongDienTich_ChuViHinhV_T_CN_TG,
		DemSoLuongHinhV_T_CN_TG,
		SapXepDanhSachHinh,
		TimHinhCoDienTichLonNhat_NhoNhat,
		TimHinhCoChuViLonNhat_NhoNhat,
		HienThiDanhSachHinhTheo,
		XoaHinh,
		ThemHinhVaoViTriX,
		TinhTongDienTich_ChuViCacHinh,
		GhiDanhSachCacHinhXuongFile
	}
	enum KieuHinh
	{
		Thoat = 0,
		HinhVuong,
		HinhTron,
		HinhChuNhat,
		HinhTamGiac
	}
	enum KieuSapXep
	{
		Thoat = 0,
		TangTheoDienTich,
		TangTheoChuVi,
		GiamTheoDienTich,
		GiamTheoChuVi
	}
	enum XoaHinh
	{
		Thoat = 0,
		XoaHinhCoDienTichLonNhat,
		XoaHinhCoDienTichNhoNhat,
		XoaHinhCoChuViLonNhat,
		XoaHinhCoChuViNhoNhat,
		XoaHinhTaiViTriX
	}
	class MenuClass
	{
		private static void XuatMenu()
		{
			Console.Clear();
			Console.WriteLine("================================ QUAN LY HINH HOC ================================");
			Console.WriteLine("{0}. Thoat chuong trinh", (int)Menu.ThoatChuongTrinh);
			Console.WriteLine("{0}. Nhap du lieu tu file", (int)Menu.NhapFile);
			Console.WriteLine("{0}. Xem danh sach hien hanh", (int)Menu.XuatDanhSach);
			Console.WriteLine("{0}. Tim tat ca hinh vuong/tron/chu nhat/tam giac co dien tich x", (int)Menu.TimTatCaHinhV_T_CN_TGCoDienTichX);
			Console.WriteLine("{0}. Tim tat ca hinh vuong/tron/chu nhat/tam giac co chu vi x", (int)Menu.TimTatCaHinhV_T_CN_TGCoChuViX);
			Console.WriteLine("{0}. Tim tat ca hinh vuong/tron/chu nhat/tam giac co chu vi lon nhat/nho nhat", (int)Menu.TimTatCaHinhV_T_CN_TGCoChuViMax_Min);
			Console.WriteLine("{0}. Tim tat ca hinh vuong/tron/chu nhat/tam giac co dien tich lon nhat/nho nhat", (int)Menu.TimTatCaHinhV_T_CN_TGCoDienTichMax_Min);
			Console.WriteLine("{0}. TIm tat ca hinh vuong/tron/chu nhat/tam giac co canh lon nhat/nho nhat", (int)Menu.TimHinhV_T_CN_TGCoCanhNhoNhat_LonNhat);
			Console.WriteLine("{0}. Tinh tong dien tich/chu vi cua hinh vuong/tron/chu nhat/tam giac", (int)Menu.TinhTongDienTich_ChuViHinhV_T_CN_TG);
			Console.WriteLine("{0}. Dem so luong hinh vuong/tron/chu nhat", (int)Menu.DemSoLuongHinhV_T_CN_TG);
			Console.WriteLine("{0}. Sap xep danh sach hinh", (int)Menu.SapXepDanhSachHinh);
			Console.WriteLine("{0}. Tim hinh co dien tich lon nhat nho nhat", (int)Menu.TimHinhCoDienTichLonNhat_NhoNhat);
			Console.WriteLine("{0}. Tim hinh co chu vi lon nhat nho nhat", (int)Menu.TimHinhCoChuViLonNhat_NhoNhat);
			Console.WriteLine("{0}. Hien thi danh sach hinh theo", (int)Menu.HienThiDanhSachHinhTheo);
			Console.WriteLine("{0}. Xoa hinh ra khoi danh sach", (int)Menu.XoaHinh);
			Console.WriteLine("{0}. Them hinh vao vi tri", (int)Menu.ThemHinhVaoViTriX);
			Console.WriteLine("{0}. Tinh tong chu vi dien tich tat ca cac hinh trong danh sach", (int)Menu.TinhTongDienTich_ChuViCacHinh);
			Console.WriteLine("{0}. Ghi danh sach hinh hoc xuong file",(int)Menu.GhiDanhSachCacHinhXuongFile);
			Console.WriteLine("==================================================================================");
		}
		public static Menu ChonMenu()
		{
			Menu menu = new Menu();
			XuatMenu();
			Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
			menu = (Menu)int.Parse(Console.ReadLine());
			return menu;
		}
		public static void XuLyMenu(DanhSachHinhHoc ds, Menu menu)
		{
			double x = 0;
			int choose = 1;
			DanhSachHinhHoc kq = new DanhSachHinhHoc();
			Console.Clear();
			int index = 0;
			switch (menu)
			{
				case Menu.ThoatChuongTrinh:
					break;
				#region Case 1
				case Menu.NhapFile:
					ds.NhapTuFile("D:HinhHoc.txt");
					Console.WriteLine("Da nhap file thanh cong!");
					Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
					Console.ReadKey();
					break;
				#endregion
				#region Case 2
				case Menu.XuatDanhSach:
					Console.WriteLine(ds);
					Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
					Console.ReadKey();
					break;
				#endregion
				#region Case 3
				case Menu.TimTatCaHinhV_T_CN_TGCoDienTichX:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("======================= KIEU HINH =======================");
						Console.WriteLine("{0}. Thoat", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("{0}. Hinh tam giac", (int)KieuHinh.HinhTamGiac);
						Console.WriteLine("=========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								Console.Write("Xin hay nhap dien tich cua hinh vuong: ");
								x = double.Parse(Console.ReadLine());
								kq = ds.TimHinhCoDienTich<HinhVuong>(x);
								Console.WriteLine("Danh sach hinh vuong co dien tich {0} la: ", x);
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								Console.Write("Xin hay nhap dien tich cua hinh tron: ");
								x = double.Parse(Console.ReadLine());
								kq = ds.TimHinhCoDienTich<HinhTron>(x);
								Console.WriteLine("Danh sach hinh tron co dien tich {0} la: ", x);
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								Console.Write("Xin hay nhap dien tich cua hinh chu nhat: ");
								x = double.Parse(Console.ReadLine());
								kq = ds.TimHinhCoDienTich<HinhChuNhat>(x);
								Console.WriteLine("Danh sach hinh chu nhat co dien tich {0} la: ", x);
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTamGiac:
								Console.Write("Xin hay nhap dien tich cua hinh tam giac: ");
								x = double.Parse(Console.ReadLine());
								kq = ds.TimHinhCoDienTich<HinhTamGiac>(x);
								Console.WriteLine("Danh sach hinh tam giac co dien tich {0} la: ", x);
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 4
				case Menu.TimTatCaHinhV_T_CN_TGCoChuViX:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("======================= KIEU HINH =======================");
						Console.WriteLine("{0}. Thoat", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("{0}. Hinh tam giac", (int)KieuHinh.HinhTamGiac);
						Console.WriteLine("=========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								Console.Write("Xin hay nhap chu vi cua hinh vuong: ");
								x = double.Parse(Console.ReadLine());
								kq = ds.TimHinhCoChuVi<HinhVuong>(x);
								Console.WriteLine("Danh sach hinh vuong co chu vi {0} la: ", x);
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								Console.Write("Xin hay nhap chu vi cua hinh tron: ");
								x = double.Parse(Console.ReadLine());
								kq = ds.TimHinhCoChuVi<HinhTron>(x);
								Console.WriteLine("Danh sach hinh tron co chu vi {0} la: ", x);
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								Console.Write("Xin hay nhap chu vi cua hinh chu nhat: ");
								x = double.Parse(Console.ReadLine());
								kq = ds.TimHinhCoChuVi<HinhChuNhat>(x);
								Console.WriteLine("Danh sach hinh chu nhat co chu vi {0} la: ", x);
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTamGiac:
								Console.Write("Xin hay nhap chu vi cua hinh tam giac: ");
								x = double.Parse(Console.ReadLine());
								kq = ds.TimHinhCoChuVi<HinhTamGiac>(x);
								Console.WriteLine("Danh sach hinh tam giac co chu vi {0} la: ", x);
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 5
				case Menu.TimTatCaHinhV_T_CN_TGCoChuViMax_Min:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("======================= KIEU HINH =======================");
						Console.WriteLine("{0}. Thoat", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("{0}. Hinh tam giac", (int)KieuHinh.HinhTamGiac);
						Console.WriteLine("=========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								kq = ds.TimHinhCoChuViLonNhat<HinhVuong>();
								Console.WriteLine("Danh sach hinh vuong co chu vi lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhCoChuViNhoNhat<HinhVuong>();
								Console.WriteLine("Danh sach hinh vuong co chu vi nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								kq = ds.TimHinhCoChuViLonNhat<HinhTron>();
								Console.WriteLine("Danh sach hinh tron co chu vi lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhCoChuViNhoNhat<HinhTron>();
								Console.WriteLine("Danh sach hinh tron co chu vi nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh:");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								kq = ds.TimHinhCoChuViLonNhat<HinhChuNhat>();
								Console.WriteLine("Danh sach hinh chu nhat co chu vi lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhCoChuViNhoNhat<HinhChuNhat>();
								Console.WriteLine("Danh sach hinh chu nhat co chu vi nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTamGiac:
								kq = ds.TimHinhCoChuViLonNhat<HinhTamGiac>();
								Console.WriteLine("Danh sach hinh tam giac co chu vi lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhCoChuViNhoNhat<HinhTamGiac>();
								Console.WriteLine("Danh sach hinh tam giac co chu vi nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 6
				case Menu.TimTatCaHinhV_T_CN_TGCoDienTichMax_Min:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("======================= KIEU HINH =======================");
						Console.WriteLine("{0}. Thoat", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("{0}. Hinh tam giac", (int)KieuHinh.HinhTamGiac);
						Console.WriteLine("=========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								kq = ds.TimHinhCoDienTichLonNhat<HinhVuong>();
								Console.WriteLine("Danh sach hinh vuong co dien tich lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhCoDienTichNhoNhat<HinhVuong>();
								Console.WriteLine("Danh sach hinh vuong co dien tich nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								kq = ds.TimHinhCoDienTichLonNhat<HinhTron>();
								Console.WriteLine("Danh sach hinh tron co dien tich lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhCoDienTichNhoNhat<HinhTron>();
								Console.WriteLine("Danh sach hinh tron co dien tich nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh:");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								kq = ds.TimHinhCoDienTichLonNhat<HinhChuNhat>();
								Console.WriteLine("Danh sach hinh chu nhat co dien tich lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhCoDienTichNhoNhat<HinhChuNhat>();
								Console.WriteLine("Danh sach hinh chu nhat co dien tich nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTamGiac:
								kq = ds.TimHinhCoDienTichLonNhat<HinhTamGiac>();
								Console.WriteLine("Danh sach hinh tam giac co dien tich lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhCoDienTichNhoNhat<HinhTamGiac>();
								Console.WriteLine("Danh sach hinh tam giac co dien tich nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 7
				case Menu.TimHinhV_T_CN_TGCoCanhNhoNhat_LonNhat:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("======================= KIEU HINH =======================");
						Console.WriteLine("{0}. Thoat", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("{0}. Hinh tam giac", (int)KieuHinh.HinhTamGiac);
						Console.WriteLine("=========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								kq = ds.TimHinhVuongCoCanhLonNhat();
								Console.WriteLine("Danh sach hinh vuong co canh lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimnHinhVuongCoCanhNhoNhat();
								Console.WriteLine("Danh sach hinh vuong co canh nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								kq = ds.TimHinhTronCoBanKinhLonNhat();
								Console.WriteLine("Danh sach hinh tron co ban kinh lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimHinhTronCoBanKinhNhoNhat();
								Console.WriteLine("Danh sach hinh tron co ban kinh nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh:");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								kq = ds.TimHinhChuNhatCoChieuDaiLonNhat();
								Console.WriteLine("Danh sach hinh chu nhat co chieu dai lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimhinhChuNhatCoChieuRongNhoNhat();
								Console.WriteLine("Danh sach hinh chu nhat co chieu rong nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTamGiac:
								kq = ds.TimHinhTamGiacCoCanhLonNhat();
								Console.WriteLine("Danh sach hinh tam giac co canh lon nhat la: ");
								Console.WriteLine(kq);
								kq = ds.TimHinhTamGiacCoCanhNhoNhat();
								Console.WriteLine("Danh sach hinh tam giac co canh nho nhat la: ");
								Console.WriteLine(kq);
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 8
				case Menu.TinhTongDienTich_ChuViHinhV_T_CN_TG:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("======================= KIEU HINH =======================");
						Console.WriteLine("{0}. Thoat", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("{0}. Hinh tam giac", (int)KieuHinh.HinhTamGiac);
						Console.WriteLine("=========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								Console.WriteLine("Tong dien tich tat ca hinh vuong trong danh sach la: " + ds.TinhTongDienTichCacHinh<HinhVuong>());
								Console.WriteLine("Tong chu vi tat ca hinh vuong trong danh sach la: " + ds.TinhTongChuViCacHinh<HinhVuong>());
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								Console.WriteLine("Tong dien tich tat ca hinh tron trong danh sach la: " + ds.TinhTongDienTichCacHinh<HinhTron>());
								Console.WriteLine("Tong chu vi tat ca hinh tron trong danh sach la: " + ds.TinhTongChuViCacHinh<HinhTron>());
								Console.WriteLine("Danh sach hinh hoc hien hanh:");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								Console.WriteLine("Tong dien tich tat ca hinh chu nhat trong danh sach la: " + ds.TinhTongDienTichCacHinh<HinhChuNhat>());
								Console.WriteLine("Tong chu vi tat ca hinh chu nhat trong danh sach la: " + ds.TinhTongChuViCacHinh<HinhChuNhat>());
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTamGiac:
								Console.WriteLine("Tong dien tich tat ca hinh tam giac trong danh sach la: " + ds.TinhTongDienTichCacHinh<HinhTamGiac>());
								Console.WriteLine("Tong chu vi tat ca hinh tam giac trong danh sach la: " + ds.TinhTongChuViCacHinh<HinhTamGiac>());
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 9
				case Menu.DemSoLuongHinhV_T_CN_TG:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("======================= KIEU HINH =======================");
						Console.WriteLine("{0}. Thoat", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("{0}. Hinh tam giac", (int)KieuHinh.HinhTamGiac);
						Console.WriteLine("=========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								Console.WriteLine("So luong hinh vuong trong danh sach la: " + ds.DemSoLuongHinh<HinhVuong>());
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								Console.WriteLine("So luong hinh tron trong danh sach la: " + ds.DemSoLuongHinh<HinhTron>());
								Console.WriteLine("Danh sach hinh hoc hien hanh:");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								Console.WriteLine("So luong hinh chu nhat trong danh sach la: " + ds.DemSoLuongHinh<HinhChuNhat>());
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTamGiac:
								Console.WriteLine("So luong hinh tam giac trong danh sach la: " + ds.DemSoLuongHinh<HinhTamGiac>());
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 10
				case Menu.SapXepDanhSachHinh:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("====================== KIEU SAP XEP ======================");
						Console.WriteLine("{0}. Thoat", (int)KieuSapXep.Thoat);
						Console.WriteLine("{0}. Sap xep theo chieu tang dien tich", (int)KieuSapXep.TangTheoDienTich);
						Console.WriteLine("{0}. Sap xep theo chieu tang chu vi", (int)KieuSapXep.TangTheoChuVi);
						Console.WriteLine("{0}. Sap xep theo chieu giam dien tich", (int)KieuSapXep.GiamTheoDienTich);
						Console.WriteLine("{0}. Sap xep theo chieu giam chu vi", (int)KieuSapXep.GiamTheoChuVi);
						Console.WriteLine("==========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuSapXep sort = (KieuSapXep)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (sort)
						{
							case KieuSapXep.Thoat:
								choose = 0;
								break;
							case KieuSapXep.TangTheoDienTich:
								ds.SapXepTheoChieuTangDienTich();
								Console.WriteLine("Da sap xep thanh cong! Danh sach hinh hoc sau khi sap xep: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuSapXep.TangTheoChuVi:
								ds.SapXepTheoChieuTangChuVi();
								Console.WriteLine("Da sap xep thanh cong! Danh sach hinh hoc sau khi sap xep: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuSapXep.GiamTheoDienTich:
								ds.SapXepTheoChieuGiamDienTich();
								Console.WriteLine("Da sap xep thanh cong! Danh sach hinh hoc sau khi sap xep: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuSapXep.GiamTheoChuVi:
								ds.SapXepTheoChieuGiamChuVi();
								Console.WriteLine("Da sap xep thanh cong! Danh sach hinh hoc sau khi sap xep: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 11
				case Menu.TimHinhCoDienTichLonNhat_NhoNhat:
					kq = ds.TimHinhCoDienTich<HinhHoc>(ds.TimDTMaxCua<HinhHoc>());
					Console.WriteLine("Danh sach hinh co dien tich lon nhat la: ");
					Console.WriteLine(kq);
					kq = ds.TimHinhCoDienTich<HinhHoc>(ds.TimDTMinCua<HinhHoc>());
					Console.WriteLine("Danh sach hinh co dien tich nho nhat la: ");
					Console.WriteLine(kq);
					Console.WriteLine("Danh sach hinh hoc hien hanh: ");
					Console.WriteLine(ds);
					Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
					Console.ReadKey();
					break;
				#endregion
				#region Case 12
				case Menu.TimHinhCoChuViLonNhat_NhoNhat:
					kq = ds.TimHinhCoChuVi<HinhHoc>(ds.TimCVMaxCua<HinhHoc>());
					Console.WriteLine("Danh sach hinh co chu vi lon nhat la: ");
					Console.WriteLine(kq);
					kq = ds.TimHinhCoChuVi<HinhHoc>(ds.TimCVMinCua<HinhHoc>());
					Console.WriteLine("Danh sach hinh co chu vi nho nhat la: ");
					Console.WriteLine(kq);
					Console.WriteLine("Danh sach hinh hoc hien hanh: ");
					Console.WriteLine(ds);
					Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
					Console.ReadKey();
					break;
				#endregion
				#region Case 13
				case Menu.HienThiDanhSachHinhTheo:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("====================== KIEU SAP XEP ======================");
						Console.WriteLine("{0}. Thoat", (int)KieuSapXep.Thoat);
						Console.WriteLine("{0}. Sap xep theo chieu tang dien tich", (int)KieuSapXep.TangTheoDienTich);
						Console.WriteLine("{0}. Sap xep theo chieu tang chu vi", (int)KieuSapXep.TangTheoChuVi);
						Console.WriteLine("{0}. Sap xep theo chieu giam dien tich", (int)KieuSapXep.GiamTheoDienTich);
						Console.WriteLine("{0}. Sap xep theo chieu giam chu vi", (int)KieuSapXep.GiamTheoChuVi);
						Console.WriteLine("==========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuSapXep sort = (KieuSapXep)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (sort)
						{
							case KieuSapXep.Thoat:
								choose = 0;
								break;
							case KieuSapXep.TangTheoDienTich:
								kq = ds.HienThiDanhSachTheoChieuTangDienTich();
								Console.WriteLine("Danh sach hinh hoc theo chieu tang dien tich la:	");
								Console.WriteLine(kq);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuSapXep.TangTheoChuVi:
								kq = ds.HienThiDanhSachTheoChieuTangChuVi();
								Console.WriteLine("Danh sach hinh hoc theo chieu tang chu vi la:	");
								Console.WriteLine(kq);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuSapXep.GiamTheoDienTich:
								kq = ds.HienThiDanhSachTheoChieuGiamDienTich();
								Console.WriteLine("Danh sach hinh hoc theo chieu giam dien tich la:	");
								Console.WriteLine(kq);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuSapXep.GiamTheoChuVi:
								kq = ds.HienThiDanhSachTheoChieuGiamChuVi();
								Console.WriteLine("Danh sach hinh hoc theo chieu giam chu vi la:	");
								Console.WriteLine(kq);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 14
				case Menu.XoaHinh:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("================ XOA HINH ================");
						Console.WriteLine("{0}. Thoat", (int)XoaHinh.Thoat);
						Console.WriteLine("{0}. Xoa hinh co dien tich lon nhat", (int)XoaHinh.XoaHinhCoDienTichLonNhat);
						Console.WriteLine("{0}. Xoa hinh co dien tich nho nhat", (int)XoaHinh.XoaHinhCoDienTichNhoNhat);
						Console.WriteLine("{0}. Xoa hinh co chu vi lon nhat", (int)XoaHinh.XoaHinhCoChuViLonNhat);
						Console.WriteLine("{0}. Xoa hinh co chu vi nho nhat", (int)XoaHinh.XoaHinhCoChuViNhoNhat);
						Console.WriteLine("{0}. Xoa hinh tai vi tri", (int)XoaHinh.XoaHinhTaiViTriX);
						Console.WriteLine("==========================================");
						Console.Write("Nhap 1 so de chon chuc nang tuong ung: ");
						XoaHinh del = (XoaHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (del)
						{
							case XoaHinh.Thoat:
								choose = 0;
								break;
							case XoaHinh.XoaHinhCoDienTichLonNhat:
								ds.XoaHinhCoDienTichLonNhat();
								Console.WriteLine("Xoa thanh cong! Danh sach hinh hoc sau khi xoa: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case XoaHinh.XoaHinhCoDienTichNhoNhat:
								ds.XoaHinhCoDienTichNhoNhat();
								Console.WriteLine("Xoa thanh cong! Danh sach hinh hoc sau khi xoa: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case XoaHinh.XoaHinhCoChuViLonNhat:
								ds.XoaHinhCoChuViLonNhat();
								Console.WriteLine("Xoa thanh cong! Danh sach hinh hoc sau khi xoa: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case XoaHinh.XoaHinhCoChuViNhoNhat:
								ds.XoaHinhCoChuViNhoNhat();
								Console.WriteLine("Xoa thanh cong! Danh sach hinh hoc sau khi xoa: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case XoaHinh.XoaHinhTaiViTriX:
								Console.WriteLine(ds);
								Console.Write("Xin hay nhap vi tri cua hinh can xoa: ");
								index = int.Parse(Console.ReadLine());
								Console.Clear();
								if (ds.XoaHinhTaiViTri(index - 1))
								{
									Console.WriteLine("Xoa thanh cong! Danh sach hinh hoc sau khi xoa: ");
									Console.WriteLine(ds);
									Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
									Console.ReadKey();
								}
								else
								{
									Console.WriteLine("Xoa khong thanh cong! Danh sach hinh hoc hien hanh: ");
									Console.WriteLine(ds);
									Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
									Console.ReadKey();
								}
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 15
				case Menu.ThemHinhVaoViTriX:
					choose = 1;
					while (choose > 0)
					{
						Console.Clear();
						Console.WriteLine("======================= KIEU HINH =======================");
						Console.WriteLine("{0}. Thoat", (int)KieuHinh.Thoat);
						Console.WriteLine("{0}. Hinh vuong", (int)KieuHinh.HinhVuong);
						Console.WriteLine("{0}. Hinh tron", (int)KieuHinh.HinhTron);
						Console.WriteLine("{0}. Hinh chu nhat", (int)KieuHinh.HinhChuNhat);
						Console.WriteLine("{0}. Hinh tam giac", (int)KieuHinh.HinhTamGiac);
						Console.WriteLine("=========================================================");
						Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
						KieuHinh kh = (KieuHinh)int.Parse(Console.ReadLine());
						Console.Clear();
						switch (kh)
						{
							case KieuHinh.Thoat:
								choose = 0;
								break;
							case KieuHinh.HinhVuong:
								Console.WriteLine("Tao hinh vuong");
								Console.WriteLine(ds);
								HinhVuong hv = new HinhVuong();
								Console.Write("Xin hay nhap do dai canh cua hinh vuong: ");
								hv.edge = double.Parse(Console.ReadLine());
								Console.Write("Xin hay nhap vi tri cua hinh vuong: ");
								index = int.Parse(Console.ReadLine());
								Console.Clear();
								if (ds.ThemHinhVaoViTri(hv, index - 1))
									Console.WriteLine("Them hinh thanh cong!");
								else
									Console.WriteLine("Them hinh khong thanh cong!");
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTron:
								Console.WriteLine("Tao Hinh tron");
								Console.WriteLine(ds);
								HinhTron ht = new HinhTron();
								Console.Write("Xin hay nhap do dai ban kinh cua hinh tron: ");
								ht.radius = double.Parse(Console.ReadLine());
								Console.Write("Xin hay nhap vi tri cua hinh tron: ");
								index = int.Parse(Console.ReadLine());
								Console.Clear();
								if (ds.ThemHinhVaoViTri(ht, index - 1))
									Console.WriteLine("Them hinh thanh cong!");
								else
									Console.WriteLine("Them hinh khong thanh cong!");
								Console.WriteLine("Danh sach hinh hoc hien hanh:");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhChuNhat:
								Console.WriteLine("Tao hinh chu nhat");
								Console.WriteLine(ds);
								Console.Write("Xin hay nhap do dai canh a cua hinh chu nhat: ");
								double a = double.Parse(Console.ReadLine());
								Console.WriteLine("Xin hay nhap do dai canh b cua hinh chu nhat: ");
								double b = double.Parse(Console.ReadLine());
								HinhChuNhat hcn = new HinhChuNhat(a, b);
								Console.Write("Xin hay nhap vi tri cua hinh chu nhat: ");
								index = int.Parse(Console.ReadLine());
								Console.Clear();
								if (ds.ThemHinhVaoViTri(hcn, index - 1))
									Console.WriteLine("Them hinh thanh cong!");
								else
									Console.WriteLine("Them hinh khong thanh cong!");

								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							case KieuHinh.HinhTamGiac:
								Console.WriteLine("Tao hinh tam giac");
								Console.WriteLine(ds);
								HinhTamGiac htg = new HinhTamGiac();
								Console.Write("Xin hay nhap do dai canh a cua hinh tam giac: ");
								htg.edgeA = double.Parse(Console.ReadLine());
								Console.Write("Xin hay nhap do dai canh b cua hinh tam giac: ");
								htg.edgeB = double.Parse(Console.ReadLine());
								Console.Write("Xin hay nhap do dai canh c cua hinh tam giac: ");
								htg.edgeC = double.Parse(Console.ReadLine());
								Console.Write("Xin hay nhap vi tri cua hinh tam giac: ");
								index = int.Parse(Console.ReadLine());
								Console.Clear();
								if (!HinhTamGiac.KTraTamGiac(htg.edgeA, htg.edgeB, htg.edgeC))
									Console.WriteLine("Them hinh khong thanh cong!");
								else
								{
									if (ds.ThemHinhVaoViTri(htg, index))
										Console.WriteLine("Them hinh thanh cong!");
									else
										Console.WriteLine("Them hinh khong thanh cong!");
								}
								Console.WriteLine("Danh sach hinh hoc hien hanh: ");
								Console.WriteLine(ds);
								Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
								Console.ReadKey();
								break;
							default:
								break;
						}
					}
					break;
				#endregion
				#region Case 16
				case Menu.TinhTongDienTich_ChuViCacHinh:
					Console.WriteLine("Tong dien tich cua tat ca cac hinh trong danh sach la: " + ds.TinhTongDienTichCacHinh<HinhHoc>());
					Console.WriteLine("Tong chu vi cua tat ca cac hinh trong danh sach la: " + ds.TinhTongChuViCacHinh<HinhHoc>());
					Console.WriteLine("Danh sach hinh hoc hien hanh: ");
					Console.WriteLine(ds);
					Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
					Console.ReadKey();
					break;
				#endregion
				#region Case 17
				case Menu.GhiDanhSachCacHinhXuongFile:
					ds.GhiDanhSachRaFile<HinhVuong>("D:DanhSachHinhHoc\\hinhvuong.txt");
					ds.GhiDanhSachRaFile<HinhTron>("D:DanhSachHinhHoc\\hinhtron.txt");
					ds.GhiDanhSachRaFile<HinhChuNhat>("D:DanhSachHinhHoc\\hinhchunhat.txt");
					ds.GhiDanhSachRaFile<HinhTamGiac>("D:DanhSachHinhHoc\\hinhtamgiac.txt");
					Console.WriteLine("Da ghi thanh cong! Xin hay kiem tra folder D:DanhSachHinhHoc!");
					Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
					Console.ReadKey();
					break;
				#endregion
				default:
					break;
			}
		}
	}
}
