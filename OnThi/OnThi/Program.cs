using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
	enum Menu
	{
		ThoatChuongTrinh = 0,
		NhapDuLieu,
		XuatDuLieu,
		XuatNhanVienBanThoiGianLamViecItNhat,
		TimThangTraLuongBTGThapNhat,
		TimThangCoSoNhanVienLamViecBTGItNhat,
		TimThangKhongCoNhanVienLamViec,
		TimThangCoNhieuNhanVienCoCungNgaySinhNhat,
		TimDanhSachNhanVienHopDongCoCungNgaySinhNhat,
		SapXepNhanVien,
		ThuongThem3GioChoNhanVienLamBTGTrongThang5,
		LuuDuLieu
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			List<int> dsThangKQ = new List<int>();
			DanhSachNhanVien a = new DanhSachNhanVien();
			DanhSachNhanVien kq = new DanhSachNhanVien();
			int month = 0;
			int choose = 1;
			while (true)
			{
				Console.Clear();
				Console.WriteLine("================================ QUAN LY NHAN VIEN ================================");
				Console.WriteLine("{0}. Thoat chuong trinh", (int)Menu.ThoatChuongTrinh);
				Console.WriteLine("{0}. Nhap du lieu tu file", (int)Menu.NhapDuLieu);
				Console.WriteLine("{0}. Xem danh sach hien hanh", (int)Menu.XuatDuLieu);
				Console.WriteLine("{0}. Tim nhan vien ban thoi gian co so gio lam viec it nhat trong 1 thang", (int)Menu.XuatNhanVienBanThoiGianLamViecItNhat);
				Console.WriteLine("{0}. Tim thang tra luong cho nhan vien ban thoi gian thap nhat", (int)Menu.TimThangTraLuongBTGThapNhat);
				Console.WriteLine("{0}. Tim thang co so nhan vien ban thoi gian lam viec it nhat", (int)Menu.TimThangCoSoNhanVienLamViecBTGItNhat);
				Console.WriteLine("{0}. Tim thang khong co nhan vien ban thoi gian lam viec", (int)Menu.TimThangKhongCoNhanVienLamViec);
				Console.WriteLine("{0}. Tim thang co nhieu nhan vien cung ngay sinh nhat nhat", (int)Menu.TimThangCoNhieuNhanVienCoCungNgaySinhNhat);
				Console.WriteLine("{0}. Tim danh sach nhan vien hop dong co cung ngay sinh nhat", (int)Menu.TimDanhSachNhanVienHopDongCoCungNgaySinhNhat);
				Console.WriteLine("{0}. Sap xep danh sach nhan vien", (int)Menu.SapXepNhanVien);
				Console.WriteLine("{0}. Thuong them 3 gio lam viec cho nhan vien ban thoi gian lam viec trong thang 5", (int)Menu.ThuongThem3GioChoNhanVienLamBTGTrongThang5);
				Console.WriteLine("{0}. Ghi danh sach ra file", (int)Menu.LuuDuLieu);
				Console.WriteLine("===================================================================================");
				Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
				Menu menu = (Menu)int.Parse(Console.ReadLine());
				Console.Clear();
				switch (menu)
				{
					case Menu.ThoatChuongTrinh:
						return;
					case Menu.NhapDuLieu:
						a.NhapTuFile();
						Console.WriteLine("Da nhap thanh cong!");
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.XuatDuLieu:
						Console.WriteLine("Danh sach nhan vien hien hanh:");
						Console.Write(a);
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.XuatNhanVienBanThoiGianLamViecItNhat:
						Console.Write("Xin hay nhap thang can tim: ");
						month = int.Parse(Console.ReadLine());
						kq = a.TimNhanVienBanThoiGianCoGioLamViecItNhatTrongMotThang(month);
						Console.Clear();
						Console.WriteLine("Danh sach nhan vien ban thoi gian lam viec it nhat trong thang {0} la:", month);
						Console.WriteLine(kq);
						Console.WriteLine("Danh sach nhan vien hien hanh: ");
						Console.WriteLine(a);
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.TimThangTraLuongBTGThapNhat:
						dsThangKQ = a.TimThangTraLuongBanThoiGianThapNhat();
						dsThangKQ.Sort();
						Console.WriteLine("Thang tra luong ban thoi gian thap nhat cho nhan vien ban thoi gian la:	");
						foreach (var thang in dsThangKQ)
						{
							Console.Write(thang + "\t");
						}
						Console.WriteLine();
						Console.WriteLine("Danh sach nhan vien hien hanh");
						Console.WriteLine(a);
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.TimThangCoSoNhanVienLamViecBTGItNhat:
						dsThangKQ = a.TimThangCoItNhanVienBanThoiGianLamViecNhat();
						dsThangKQ.Sort();
						Console.WriteLine("Thang co it nhan vien ban thoi gian lam viec nhat la: ");
						foreach (var thang in dsThangKQ)
						{
							Console.Write(thang + "\t");
						}
						Console.WriteLine();
						Console.WriteLine("Danh sach nhan vien hien hanh");
						Console.WriteLine(a);
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.TimThangKhongCoNhanVienLamViec:
						dsThangKQ = a.TimThangKhongCoNhanVienBanThoiGianLamViec();
						dsThangKQ.Sort();
						Console.WriteLine("Thang khong co nhan vien ban thoi gian lam viec la: ");
						foreach (var thang in dsThangKQ)
						{
							Console.Write(thang + "\t");
						}
						Console.WriteLine();
						Console.WriteLine("Danh sach nhan vien hien hanh: ");
						Console.WriteLine(a);
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.TimThangCoNhieuNhanVienCoCungNgaySinhNhat:
						dsThangKQ = a.TimThangCoNhieuNhanVienCungNgaySinhLamViecNhat();
						dsThangKQ.Sort();
						Console.WriteLine("Thang co nhieu nhan vien cung ngay sinh nhat lam viec nhat la: ");
						foreach (var thang in dsThangKQ)
						{
							Console.Write(thang + "\t");
						}
						Console.WriteLine();
						Console.WriteLine("Danh sach nhan vien hien hanh: ");
						Console.WriteLine(a);
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.TimDanhSachNhanVienHopDongCoCungNgaySinhNhat:
						kq = a.TimDanhSachNhanVienHopDongCoCungNgaySinh();
						Console.WriteLine("Danh sach nhan vien hop dong co cung ngay sinh la: ");
						Console.WriteLine(kq);
						Console.WriteLine("Danh sach nhan vien hien hanh: ");
						Console.WriteLine(a);
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.SapXepNhanVien:
						choose = 1;
						while (choose > 0)
						{
							Console.Clear();
							Console.WriteLine("====================== KIEU SAP XEP ======================");
							Console.WriteLine("{0}. Thoat", (int)KieuSapXep.Thoat);
							Console.WriteLine("{0}. Sap xep theo ho", (int)KieuSapXep.TheoHo);
							Console.WriteLine("{0}. Sap xep theo ho lot", (int)KieuSapXep.TheoTenLot);
							Console.WriteLine("{0}. Sap xep theo ten", (int)KieuSapXep.TheoTen);
							Console.WriteLine("==========================================================");
							Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
							KieuSapXep sort = (KieuSapXep)int.Parse(Console.ReadLine());
							Console.Clear();
							switch (sort)
							{
								case KieuSapXep.Thoat:
									choose = 0;
									Console.WriteLine("Thoat chuc nang");
									Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
									break;
								case KieuSapXep.TheoHo:
									a.SapXepNhanVienTheoHo();
									Console.WriteLine("Da sap xep thanh cong! Danh Sach nhan vien sau khi sap xep: ");
									Console.WriteLine(a);
									Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
									break;
								case KieuSapXep.TheoTenLot:
									a.SapXepNhanVienTheoTenLot();
									Console.WriteLine("Da sap xep thanh cong! Danh sach nhan vien sau khi sap xep: ");
									Console.WriteLine(a);
									Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
									break;
								case KieuSapXep.TheoTen:
									a.SapXepNhanVienTheoTen();
									Console.WriteLine("Da sap xep thanh cong! Danh sach nhan vien sau khi sap xep: ");
									Console.WriteLine(a);
									Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
									break;
								default:
									break;
							}
							Console.ReadKey();
						}
						break;
					case Menu.ThuongThem3GioChoNhanVienLamBTGTrongThang5:
						a.ThuongThemGioChoNhanVien();
						Console.WriteLine("Da thuong them 3 gio lam viec cho nhan vien lam viec trong thang 5!");
						Console.WriteLine("Danh sach nhan vien hien hanh: ");
						Console.WriteLine(a);
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					case Menu.LuuDuLieu:
						a.GhiFile("D:NhanVienKQ.txt");
						Console.WriteLine("Da ghi thanh cong! Xin hay vao o dia D de kiem tra (ten file: NhanVienKQ.txt).");
						Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
						break;
					default:
						break;
				}
				Console.ReadKey();
			}
		}
	}
}
