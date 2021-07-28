using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc_LamLai
{
	class ThuVienDungChung
	{
		private static void Swap<T>(ref HinhHoc a, ref HinhHoc b)
		{
			HinhHoc temp = a;
			a = b;
			b = temp;
		}
		private static int KiemTraDieuKien(HinhHoc a, HinhHoc b, KieuSapXep k)
		{
			switch (k)
			{
				case KieuSapXep.Thoat:
					break;
				case KieuSapXep.TangTheoDienTich:
					return a.tinhDT().CompareTo(b.tinhDT());
				case KieuSapXep.TangTheoChuVi:
					return a.tinhCV().CompareTo(b.tinhCV());
				case KieuSapXep.GiamTheoDienTich:
					return -a.tinhDT().CompareTo(b.tinhDT());
				case KieuSapXep.GiamTheoChuVi:
					return -a.tinhCV().CompareTo(b.tinhCV());
				default:
					break;
			}
			return -1;
		}
		private static void Partition(HinhHoc[] ds, int l, int r, KieuSapXep k)
		{
			int i, j;
			HinhHoc x = ds[(l + r) / 2];
			i = l;
			j = r;
			do
			{
				while (KiemTraDieuKien(ds[i], x, k) == -1)
					i++;
				while (KiemTraDieuKien(ds[j], x, k) == 1)
					j--;
				if (i <= j)
				{
					Swap<HinhHoc>(ref ds[i], ref ds[j]);
					i++;
					j--;
				}
			} while (i <= j);
			if (l < j)
				Partition(ds, l, j, k);
			if (i < r)
				Partition(ds, i, r, k);
		}
		public static HinhHoc[] SapXepHinhHoc( List<HinhHoc> ds, KieuSapXep k)
		{
			HinhHoc[] tempList = ds.ToArray();
			#region Bubble Sort
			//for (int i = ds.Count - 1; i >= 0; i--)
			//{
			//	for (int j = 0; j < i; j++)
			//	{
			//		if (KiemTraDieuKien(tempList[j], tempList[j + 1], k) == 1)
			//			Swap<HinhHoc>(ref tempList[j], ref tempList[j + 1]);
			//	}
			//}
			#endregion
			#region QuickSort
			Partition(tempList, 0, ds.Count - 1, k);
			#endregion
			return tempList;
		}
	}
}
