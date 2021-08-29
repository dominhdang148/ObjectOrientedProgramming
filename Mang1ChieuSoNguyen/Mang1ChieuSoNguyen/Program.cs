using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
	class Program
	{
		static int[] a = new int[100];
		static int length = 0;
		static void Main(string[] args)
		{
			NhapNgauNhien(a, ref length);
			Console.WriteLine("Mang vua nhap: ");
			Xuat(a, length);

			//Console.Write("\nNhap phan tu can xoa: ");
			//int x = int.Parse(Console.ReadLine());
			//XoaPhanTuDauTien(x);
			//Console.WriteLine("Mang sau khi xoa: ");
			//Xuat();

			//Console.Write("\nNhap phan tu can xoa: ");
			//int x = int.Parse(Console.ReadLine());
			//XoaPhanTuCuoiCung(x);
			//Console.WriteLine("Mang sau khi xoa: ");
			//Xuat(); 

			//int sum = Tong();
			//Console.WriteLine("\nTong cac phan tu trong mang la: " + sum);

			//int max = TimPhanTuLonNhat();
			//Console.WriteLine("\nPhan tu lon nhat cua mang la: " + max);

			//int min = TimPhanTuNhoNhat();
			//Console.Write("\nPhan tu nho nhat cua mang: "+min);

			//Console.WriteLine("\nMang gom tat ca cac so am la: ");
			//int lengthkq = 0;
			//int[] kq = TimTatCaSoAm(ref lengthkq);
			//Xuat(kq, lengthkq);

			//Console.WriteLine("\nMang gom tat ca cac so duong la: ");
			//int lengthkq = 0;
			//int[] kq = TimTatCaSoDuong(ref lengthkq);
			//Xuat(kq, lengthkq);

			//Console.WriteLine("\nMang gom tat ca cac so chan la: ");
			//int lengthkq = 0;
			//int[] kq =TimTatCaSoChan(ref lengthkq);
			//Xuat(kq, lengthkq);

			//Console.WriteLine("\nMang gom tat ca cac so le la: ");
			//int lengthkq = 0;
			//int[] kq = TimTatCaSoLe(ref lengthkq);
			//Xuat(kq, lengthkq);

			//Console.WriteLine("\nMang gom tat ca cac so nguyen to la: ");
			//int lengthkq = 0;
			//int[] kq = TimTatCaSoNguyenTo(ref lengthkq);
			//Xuat(kq, lengthkq);

			//Console.WriteLine("\nMang gom cac phan tu xuat hien nhieu nhat la: ");
			//int lengthkq = 0;
			//int[] kq = TimPhanTuXuatHienNhieuNhat(ref lengthkq);
			//Xuat(kq, lengthkq);

			//Console.WriteLine("\nMang gom cac phan tu xuat hien it nhat la: ");
			//int lengthkq = 0;
			//int[] kq = TimPhanTuXuatHienItNhat(ref lengthkq);
			//Xuat(kq, lengthkq);

			//Console.Write("\nXin hay nhap so can so sanh: ");
			//int x = int.Parse(Console.ReadLine());
			//Console.WriteLine("Mang gom cac phan tu lon hon so {0} la: ", x);
			//int lengthkq = 0;
			//int[] kq = TimTatCaPhanTuLonHon(ref lengthkq, x);
			//Xuat(kq, lengthkq);

			//Console.Write("\nXin hay nhap so can so sanh: ");
			//int x = int.Parse(Console.ReadLine());
			//Console.WriteLine("Mang gom cac phan tu nho hon so {0} la: ", x);
			//int lengthkq = 0;
			//int[] kq = TimTatCaPhanTuNhoHon(ref lengthkq, x);
			//Xuat(kq, lengthkq);

			//Console.Write("\nXin hay nhap so can dem: ");
			//int x = int.Parse(Console.ReadLine());
			//int kq = DemSoLaXuatHienCuaPhanTu(x);
			//Console.WriteLine("Phan tu {0} xuat hien {1} lan!", x, kq);

			//int kq = DemSoDuong();
			//Console.WriteLine("\nSo so duong trong mang la: " + kq);

			//int kq = DemSoAm();
			//Console.WriteLine("\nSo so am trong mang la: " + kq);

			//int kq = DemSoNguyenTo();
			//Console.WriteLine("\nSo so nguyen to trong mang la: " + kq);

			//int kq = DemSoChan();
			//Console.WriteLine("\nSo so chan trong mang la: " + kq);

			//int kq = DemSoLe();
			//Console.WriteLine("\nSo so le trong mang la: " + kq);

			//Console.Write("\nNhap phan tu can kiem tra: ");
			//int x = int.Parse(Console.ReadLine());
			//if (KiemTra(x) == true)
			//	Console.WriteLine("Phan tu {0} ton tai trong mang!", x);
			//else
			//	Console.WriteLine("Phan tu {0} khong ton tai trong mang!", x);

			//SapXepTang();
			//Console.WriteLine("\nMang sau khi sap xep tang dan: ");
			//Xuat(a, length);

			//SapXepGiam();
			//Console.WriteLine("\nMang sau khi sap xep giam dan: ");
			//Xuat(a, length);
			//Console.ReadKey();

			//DaoNguocMang();
			//Console.WriteLine("\nMang sau khi dao nguoc : ");
			//Xuat(a, length);

			//Console.Write("\nXin hay nhap vi tri cua phan tu dau tien: ");
			//int vt = int.Parse(Console.ReadLine());
			//Console.Write("\nXin hay nhap so luong phan tu can xuat: ");
			//int soLuong = int.Parse(Console.ReadLine());
			//int lengthkq = 0;
			//int[] kq = TimTatCaPhanTuViTri(ref lengthkq, vt, soLuong);
			//Console.WriteLine("\nMang gom {0} phan tu bat dau tu vi tri {1} la: ", soLuong, vt);
			//Xuat(kq, lengthkq);

			//Console.Write("\nXin hay nhap phan tu can them: ");
			//int x = int.Parse(Console.ReadLine());
			//Console.Write("\nXin hay nhap vi tri can them: ");
			//int vt = int.Parse(Console.ReadLine());
			//if (ThemPhanTuTaiViTri(x, vt) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri can them!");
			//else
			//{
			//	Console.WriteLine("\nThem phan tu thanh cong! Mang cac phan tu sau khi them: ");
			//	Xuat(a, length);
			//}

			//Console.Write("\nNhap phan tu can them: ");
			//int x = int.Parse(Console.ReadLine());
			//if (ThemPhanTuDauDanhSach(x) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri can them!");
			//else
			//{
			//	Console.WriteLine("\nThem phan tu thanh cong! Mang cac phan tu sau khi them: ");
			//	Xuat(a, length);
			//}

			//Console.Write("\nNhap phan tu can them: ");
			//int x = int.Parse(Console.ReadLine());
			//if (ThemPhanTuCuoiDanhSach(x) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri can them!");
			//else
			//{
			//	Console.WriteLine("\nThem phan tu thanh cong! Mang cac phan tu sau khi them: ");
			//	Xuat(a, length);
			//}

			//Console.WriteLine("\nNhap mang can chen: ");
			//int vt = 0;
			//int[] b = new int[100];
			//int lengthb = 0;
			//NhapNgauNhien(b, ref lengthb);
			//Console.WriteLine(lengthb);
			//Console.WriteLine("\nMang can chen: ");
			//Xuat(b, lengthb);
			//Console.Write("\nXin hay nhap vi tri can chen: ");
			//vt = int.Parse(Console.ReadLine());
			//if (ThemMotMangVaoDanhSachTaiViTri(b, lengthb, vt) == false)
			//{
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri chen.");
			//}
			//else
			//{
			//	Console.WriteLine("\nChen thanh cong! Mang sau khi chen: ");
			//	Xuat(a, length);
			//}

			//Console.WriteLine("\nNhap mang can chen: ");
			//int[] b = new int[100];
			//int lengthb = 0;
			//NhapNgauNhien(b, ref lengthb);
			//Console.WriteLine(lengthb);
			//Console.WriteLine("\nMang can chen: ");
			//Xuat(b, lengthb);
			//if (ThemMotMangVaoDauDanhSach(b, lengthb) == false)
			//{
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri chen.");
			//}
			//else
			//{
			//	Console.WriteLine("\nChen thanh cong! Mang sau khi chen: ");
			//	Xuat(a, length);
			//}

			//Console.WriteLine("\nNhap mang can chen: ");
			//int[] b = new int[100];
			//int lengthb = 0;
			//NhapNgauNhien(b, ref lengthb);
			//Console.WriteLine(lengthb);
			//Console.WriteLine("\nMang can chen: ");
			//Xuat(b, lengthb);
			//if (ThemMotMangVaoCuoiDanhSach(b, lengthb) == false)
			//{
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri chen.");
			//}
			//else
			//{
			//	Console.WriteLine("\nChen thanh cong! Mang sau khi chen: ");
			//	Xuat(a, length);
			//}

			//Console.Write("\nXin hay nhap vi tri can xoa: ");
			//int vt = int.Parse(Console.ReadLine());
			//if (XoaPhanTuDau(vt) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri can xoa!");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//Console.Write("\nXin hay nhap vi tri can xoa: ");
			//int vt = int.Parse(Console.ReadLine());
			//if (XoaPhanTuCuoi(vt) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri can xoa!");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//Console.Write("\nXin hay nhap vi tri can xoa: ");
			//int vt = int.Parse(Console.ReadLine());
			//if (XoaPhanTuTaiViTri(vt) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay vi tri can xoa!");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//Console.Write("\nXin hay nhap phan tu can xoa: ");
			//int x = int.Parse(Console.ReadLine());
			//if (XoaPhanTuDauTien(x) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay phan tu can xoa!");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//Console.WriteLine("\nNhap mang gom cac phan tu can xoa: ");
			//int[] b = new int[100];
			//int lengthb = 0;
			//NhapMang(b, ref lengthb);
			//Console.WriteLine("\nMang gom cac phan tu can xoa:");
			//Xuat(b, lengthb);
			//if (XoaPhanTuCoTrongMang(b, lengthb) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay phan tu can xoa!");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//Console.Write("\nNhap phan tu can xoa: ");
			//int x = int.Parse(Console.ReadLine());
			//if (XoaTatCaPhanTu(x) == false)
			//	Console.WriteLine("\nLoi! Khong tim thay phan tu can xoa!");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//if (XoaTatCaSoAm() == false)
			//	Console.WriteLine("\nMang khong co phan tu am");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//if (XoaTatCaSoDuong() == false)
			//	Console.WriteLine("\nMang khong co phan tu duong");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//if (XoaTatCaSoChan() == false)
			//	Console.WriteLine("\nMang khong co phan tu chan");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//if (XoaTatCaSoLe() == false)
			//	Console.WriteLine("\nMang khong co phan tu le");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//if (XoaTatCaSoNguyenTo() == false)
			//	Console.WriteLine("\nMang khong co phan tu la so nguyen to");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//if (XoaPhanTuTrungNhau() == false)
			//	Console.WriteLine("\nMang khong co phan tu trung nhau");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//if (XoaPhanTuXuatHienNhieuNhat() == false)
			//	Console.WriteLine("\nKhong the xoa duoc!");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}

			//if (XoaPhanTuXuatHienItNhat() == false)
			//	Console.WriteLine("\nKhong the xoa duoc!");
			//else
			//{
			//	Console.WriteLine("\nXoa thanh cong! Mang cac phan tu sau khi xoa: ");
			//	Xuat(a, length);
			//}
			Console.Write("\nXin hay nhap phan tu bi thay the: ");
			int cu = int.Parse(Console.ReadLine());
			Console.Write("\nXin hay nhap phan tu thay the: ");
			int moi = int.Parse(Console.ReadLine());
			if (ThayThePhanTu(cu, moi) == false)
				Console.WriteLine("\nLoi! Khong tim thay phan tu bi thay the!");
			else
			{
				Console.WriteLine("\nThay the thanh cong! Mang sau khi thay the: ");
				Xuat(a, length);
			}
			Console.ReadKey();
		}
		static void NhapMang(int[] mang, ref int n)
		{
			Console.Write("Nhap chieu dai cua mang: ");
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.Write("Phan tu o vi tri {0} :", i);
				mang[i] = int.Parse(Console.ReadLine());
			}

		}
		static void NhapNgauNhien(int[] mang, ref int n)
		{
			Random r = new Random();
			Console.Write("\nXin hay nhap chieu dai cua mang: ");
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < length; i++)
			{
				mang[i] = r.Next(-10, 10);
			}
		}
		static void Xuat(int[] mang, int n)
		{

			for (int i = 0; i < n; i++)
			{
				Console.Write(mang[i] + "\t");
			}
		}
		static int TimViTriDauTien(int x)
		{
			for (int i = 0; i < length; i++)
			{
				if (a[i] == x)
					return i;
			}
			return -1;
		}
		static int TimViTriCuoiCung(int y)
		{
			for (int i = length - 1; i >= 0; i--)
			{
				if (a[i] == y)
					return i;
			}
			return -1;
		}
		static void XoaPhanTuCuoiCung(int y)
		{
			XoaPhanTuTaiViTri(TimViTriCuoiCung(y));
		}
		static int Tong()
		{
			int tong = 0;
			for (int i = 0; i < length; i++)
			{
				tong += a[i];
			}
			return tong;
		}
		static int TimPhanTuLonNhat()
		{
			int max = a[0];
			for (int i = 1; i < length; i++)
			{
				if (a[i] > max)
					max = a[i];
			}
			return max;
		}
		static int TimPhanTuNhoNhat()
		{
			int min = a[0];
			for (int i = 1; i < length; i++)
			{
				if (a[i] < min)
					min = a[i];
			}
			return min;
		}
		static int[] TimTatCaSoAm(ref int lengthkq)
		{
			int[] kq = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] < 0)
				{
					kq[lengthkq] = a[i];
					lengthkq++;
				}
			}
			return kq;
		}
		static int[] TimTatCaSoDuong(ref int lengthkq)
		{
			int[] kq = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] >= 0)
				{
					kq[lengthkq] = a[i];
					lengthkq++;
				}
			}
			return kq;
		}
		static int[] TimTatCaSoChan(ref int lengthkq)
		{
			int[] kq = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] % 2 == 0)
				{
					kq[lengthkq] = a[i];
					lengthkq++;
				}
			}
			return kq;
		}
		static int[] TimTatCaSoLe(ref int lengthkq)
		{
			int[] kq = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] % 2 != 0)
				{
					kq[lengthkq] = a[i];
					lengthkq++;
				}
			}
			return kq;
		}
		static int[] TimTatCaSoNguyenTo(ref int lengthkq)
		{
			int[] kq = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (KTNguyenTo(a[i]))
				{
					kq[lengthkq] = a[i];
					lengthkq++;
				}
			}
			return kq;
		}
		static bool KTNguyenTo(int so)
		{
			if (so <= 1)
				return false;
			for (int i = 2; i <= Math.Sqrt(so); i++)
			{
				if (so % i == 0)
					return false;
			}
			return true;
		}
		static int[] TimPhanTuXuatHienNhieuNhat(ref int lengthkq)
		{
			int[] kq = new int[100];
			int max = DemSoLanXuatHienNhieuNhat();
			for (int i = 0; i < length; i++)
			{
				if (DemSoLanXuatHien(a[i]) == max && KiemTraTonTai(kq, lengthkq, a[i]) != true)
				{
					kq[lengthkq++] = a[i];
				}
			}
			return kq;
		}
		static int DemSoLanXuatHien(int x)
		{
			int dem = 0;
			for (int i = 0; i < length; i++)
			{
				if (a[i] == x)
					dem++;
			}
			return dem;
		}
		static int DemSoLanXuatHienNhieuNhat()
		{
			int max = -1;
			for (int i = 0; i < length; i++)
			{
				if (DemSoLanXuatHien(a[i]) > max)
					max = DemSoLanXuatHien(a[i]);
			}
			return max;
		}
		static bool KiemTraTonTai(int[] kq, int lengthkq, int x)
		{
			for (int i = 0; i < lengthkq; i++)
			{
				if (kq[i] == x)
					return true;
			}
			return false;
		}
		static int DemSoLanXuatHienItNhat()
		{
			int min = 10;
			for (int i = 0; i < length; i++)
			{
				if (DemSoLanXuatHien(a[i]) < min)
					min = DemSoLanXuatHien(a[i]);
			}
			return min;
		}
		static int[] TimPhanTuXuatHienItNhat(ref int lengthkq)
		{
			int[] kq = new int[100];
			int min = DemSoLanXuatHienItNhat();
			for (int i = 0; i < length; i++)
			{
				if (DemSoLanXuatHien(a[i]) == min && KiemTraTonTai(kq, lengthkq, a[i]) != true)
				{
					kq[lengthkq++] = a[i];
				}
			}
			return kq;
		}
		static int[] TimTatCaPhanTuLonHon(ref int lengthkq, int x)
		{
			int[] kq = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] > x)
				{
					kq[lengthkq++] = a[i];
				}
			}
			return kq;
		}
		static int[] TimTatCaPhanTuNhoHon(ref int lengthkq, int x)
		{
			int[] kq = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] < x)
				{
					kq[lengthkq++] = a[i];
				}
			}
			return kq;
		}
		static int DemSoLaXuatHienCuaPhanTu(int x)
		{
			int dem = 0;
			for (int i = 0; i < length; i++)
			{
				if (a[i] == x)
					dem++;
			}
			return dem;
		}
		static int DemSoDuong()
		{
			int dem = 0;
			for (int i = 0; i < length; i++)
			{
				if (a[i] > 0)
					dem++;
			}
			return dem;
		}
		static int DemSoAm()
		{
			int dem = 0;
			for (int i = 0; i < length; i++)
			{
				if (a[i] < 0)
					dem++;
			}
			return dem;
		}
		static int DemSoNguyenTo()
		{
			int dem = 0;
			for (int i = 0; i < length; i++)
			{
				if (KTNguyenTo(a[i]) == true)
					dem++;
			}
			return dem;
		}
		static int DemSoChan()
		{
			int dem = 0;
			for (int i = 0; i < length; i++)
			{
				if (a[i] % 2 == 0)
					dem++;
			}
			return dem;
		}
		static int DemSoLe()
		{
			int dem = 0;
			for (int i = 0; i < length; i++)
			{
				if (a[i] % 2 != 0)
					dem++;
			}
			return dem;
		}
		static bool KiemTra(int x)
		{
			for (int i = 0; i < length; i++)
			{
				if (a[i] == x)
					return true;
			}
			return false;
		}
		static void HoanVi(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
		static void SapXepTang()
		{
			for (int i = 0; i < length - 1; i++)
			{
				for (int j = i + 1; j < length; j++)
				{
					if (a[i] > a[j])
						HoanVi(ref a[i], ref a[j]);
				}
			}
		}
		static void SapXepGiam()
		{
			for (int i = 0; i < length - 1; i++)
			{
				for (int j = i + 1; j < length; j++)
				{
					if (a[i] < a[j])
						HoanVi(ref a[i], ref a[j]);
				}
			}
		}
		static void DaoNguocMang()
		{
			for (int i = 0; i < length / 2; i++)
			{
				HoanVi(ref a[i], ref a[length - 1 - i]);
			}
		}
		static int[] TimTatCaPhanTuViTri(ref int lengthkq, int vt, int soLuong)
		{
			int[] kq = new int[100];
			for (int i = vt; i <= soLuong + 1; i++)
			{
				kq[lengthkq++] = a[i];
			}
			return kq;
		}
		static bool ThemPhanTuTaiViTri(int x, int vt)
		{
			if (vt < 0 || vt >= length)
			{
				return false;
			}
			else
			{
				for (int i = length; i > vt; i--)
				{
					a[i] = a[i - 1];
				}
				length++;
				a[vt] = x;
				return true;
			}
		}
		static bool ThemPhanTuDauDanhSach(int x)
		{
			if (ThemPhanTuTaiViTri(x, 0) == true)
				return true;
			else
				return false;
		}
		static bool ThemPhanTuCuoiDanhSach(int x)
		{
			a[length] = x;
			length++;
			return true;
		}
		static bool ThemMotMangVaoDanhSachTaiViTri(int[] b, int lengthb, int vt)
		{
			if (vt < 0 || vt >= length)
			{
				return false;
			}
			else
			{
				length = length + lengthb;
				for (int i = length - 1; i >= vt + lengthb; i--)
				{
					a[i] = a[i - lengthb];
				}
				for (int i = vt; i < lengthb + vt; i++)
				{
					a[i] = b[i - vt];
				}
				return true;
			}
		}
		static bool ThemMotMangVaoDauDanhSach(int[] b, int lengthb)
		{
			if (ThemMotMangVaoDanhSachTaiViTri(b, lengthb, 0) == true)
				return true;
			else
				return false;
		}
		static bool ThemMotMangVaoCuoiDanhSach(int[] b, int lengthb)
		{
			if (length <= 0)
				return false;
			int tempLength = length;
			length = length + lengthb;
			for (int i = tempLength; i < length; i++)
			{
				a[i] = b[i - tempLength];
			}
			return true;
		}
		static bool XoaPhanTuDau(int vt)
		{
			if (vt < 0 || vt >= length)
			{
				return false;
			}
			for (int i = 0; i <= vt + 1; i++)
			{
				a[i] = a[i + vt + 1];
			}
			length = length - vt - 1;
			return true;
		}
		static bool XoaPhanTuCuoi(int vt)
		{
			if (vt < 0 || vt >= length)
			{
				return false;
			}
			for (int i = length - 1; i >= vt; i--)
			{
				a[i] = 0;
			}
			length = vt;
			return true;
		}
		static bool XoaPhanTuTaiViTri(int vt)
		{
			if (0 <= vt && vt < length)
			{
				for (int i = vt; i < length - 1; i++)
				{
					a[i] = a[i + 1];
				}
				length--;
				return true;
			}
			else
			{
				return false;
			}
		}
		static bool XoaPhanTuDauTien(int x)
		{
			if (KiemTraTonTai(a, length, x) == true)
			{
				XoaPhanTuTaiViTri(TimViTriDauTien(x));
				return true;
			}
			else
			{
				return false;
			}
		}
		static bool XoaPhanTuCoTrongMang(int[] b, int lengthb)
		{
			int temp = length;
			for (int i = 0; i < lengthb; i++)
			{
				while (KiemTraTonTai(a, length, b[i]) == true)
				{
					XoaPhanTuDauTien(b[i]);
				}
			}
			if (temp == length)
				return false;
			else
				return true;
		}
		static bool XoaTatCaPhanTu(int x)
		{
			int temp = length;
			for (int i = 0; i < length; i++)
			{
				if (a[i] == x)
					XoaPhanTuDauTien(a[i]);
			}
			if (temp == length)
				return false;
			else
				return true;
		}
		static bool XoaTatCaSoAm()
		{
			int temp = length;
			for (int i = 0; i < length; i++)
			{
				if (a[i] < 0)
				{
					XoaPhanTuTaiViTri(i);
					i--;
				}
			}
			if (temp == length)
				return false;
			else
				return true;
		}
		static bool XoaTatCaSoDuong()
		{
			int temp = length;
			for (int i = 0; i < length; i++)
			{
				if (a[i] >= 0)
				{
					XoaPhanTuTaiViTri(i);
					i--;
				}
			}
			if (temp == length)
				return false;
			else
				return true;
		}
		static bool XoaTatCaSoChan()
		{
			int temp = length;
			for (int i = 0; i < length; i++)
			{
				if (a[i] % 2 == 0)
				{
					XoaPhanTuTaiViTri(i);
					i--;
				}
			}
			if (temp == length)
				return false;
			else
				return true;
		}
		static bool XoaTatCaSoLe()
		{
			int temp = length;
			for (int i = 0; i < length; i++)
			{
				if (a[i] % 2 != 0)
				{
					XoaPhanTuTaiViTri(i);
					i--;
				}
			}
			if (temp == length)
				return false;
			else
				return true;
		}
		static bool XoaTatCaSoNguyenTo()
		{
			int temp = length;
			for (int i = 0; i < length; i++)
			{
				if (KTNguyenTo(a[i]) == true)
				{
					XoaPhanTuTaiViTri(i);
					i--;
				}
			}
			if (temp == length)
				return false;
			else
				return true;
		}
		static bool XoaPhanTuTrungNhau()
		{
			int[] t = new int[100];
			int lengtht = 0;
			int temp = length;
			for (int i=0;i<length;i++)
			{
				if (DemSoLanXuatHien(a[i])>=2&&KiemTraTonTai(t,lengtht,a[i])!=true)
				{
					t[lengtht] = a[i];
					lengtht++;
				}
			}
			XoaPhanTuCoTrongMang(t, lengtht);
			if (temp == length)
				return false;
			else
				return true;
		}
		static bool XoaPhanTuXuatHienNhieuNhat()
		{
			int temp = length;
			int[] t = new int[100];
			int lengtht = 0;
			t = TimPhanTuXuatHienNhieuNhat(ref lengtht);
			XoaPhanTuCoTrongMang(t, lengtht);
			if (length == temp)
				return false;
			else
				return true;
		}
		static bool XoaPhanTuXuatHienItNhat()
		{
			int temp = length;
			int[] t = new int[100];
			int lengtht = 0;
			t = TimPhanTuXuatHienItNhat(ref lengtht);
			XoaPhanTuCoTrongMang(t, lengtht);
			if (length == temp)
				return false;
			else
				return true;
		}
		static bool ThayThePhanTu(int cu, int moi)
		{
			if (KiemTraTonTai(a, length, cu) == false)
				return false;
			else
			{
				for (int i = 0; i < length; i++)
				{
					if (a[i] == cu)
						a[i] = moi;
				}
				return true;
			}
		}
	}
}

