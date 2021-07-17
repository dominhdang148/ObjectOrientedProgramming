using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
	enum KieuSapXep
	{
		Thoat = 0,
		TheoHo,
		TheoTenLot,
		TheoTen
	}
	class ThuVienDungChung
	{
		private static int KiemTraDieuKien(NhanVien a, NhanVien b, KieuSapXep k)
		{
			if (k == KieuSapXep.TheoHo)
			{
				string[] strA = a.hoTen.Split(' ');
				string[] strB = b.hoTen.Split(' ');
				return strA[0].CompareTo(strB[0]);
			}
			if(k==KieuSapXep.TheoTenLot)
			{
				string strA = a.hoTen.Substring(a.hoTen.IndexOf(' ') + 1, (a.hoTen.LastIndexOf(' ') - (a.hoTen.IndexOf(' ') + 1)));
				string strB = b.hoTen.Substring(b.hoTen.IndexOf(' ') + 1, (b.hoTen.LastIndexOf(' ') - (b.hoTen.IndexOf(' ') + 1)));
				strA.Trim();
				strB.Trim();
				return strA.CompareTo(strB);
			}
			if (k == KieuSapXep.TheoTen)
			{
				return a.hoTen.Substring(a.hoTen.LastIndexOf(' ')).CompareTo(b.hoTen.Substring(b.hoTen.LastIndexOf(' ')));
			}
			return -1; 
		}
		private static void Swap<Type>(ref Type a, ref Type b)
		{
			Type temp = a;
			a = b;
			b = temp;
		}
		public static NhanVien[] SapXepNhanVien(List<NhanVien> ds,KieuSapXep k )
		{
			NhanVien[] Temp = ds.ToArray();
			int length = ds.Count;
			Partition(Temp, 0, length - 1, k);
			return Temp;

		}
		private static void Partition(NhanVien []a, int l, int r, KieuSapXep k)
		{
			int i = l;
			int j = r;
			NhanVien x = new NhanVien();
			x = a[(l + r) / 2];
			do
			{
				while (KiemTraDieuKien(a[i], x, k) == -1)
					i++;
				while (KiemTraDieuKien(a[j], x, k) == 1)
					j--;
				if(i<=j)
				{
					Swap<NhanVien>(ref a[i], ref a[j]);
					i++;
					j--;
				}
			} while (i<=j);
			if (l < j)
				Partition(a, l, j, k);
			if (i < r)
				Partition(a, i, r, k);
		}
	}
}
