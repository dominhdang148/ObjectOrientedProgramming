using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_NangCap
{

	class ThuVienDungChung
	{
		private static int KiemTraDieuKien(HinhHoc a, HinhHoc b, KieuSapXep k)
		{
			if (k == KieuSapXep.SapXepTheoChieuTangDienTich)
				return a.DT.CompareTo(b.DT);
			if (k == KieuSapXep.SapXepTheoChieuGiamDienTich)
				return -a.DT.CompareTo(b.DT);
			if (k == KieuSapXep.SapXepTheoChieuTangChuVi)
				return a.CV.CompareTo(b.CV);
			if (k == KieuSapXep.SapXepTheoChieuGiamChuVi)
				return -a.CV.CompareTo(b.CV);
			return -1;
		}
		private static void Swap<Type>(ref Type a, ref Type b)
		{
			Type temp = a;
			a = b;
			b = temp;
		}
		public static HinhHoc[] SapXepDanhSach(List<HinhHoc> ds, KieuSapXep k)
		{
			HinhHoc[] dstam = ds.ToArray();
			int length = ds.Count;
			#region Bubble Sort
			//for (int i = length - 1; i > 0; i--)
			//{
			//	for (int j = 0; j < i; j++)
			//	{
			//		if (KiemTraDieuKien(dstam[j], dstam[j + 1], k) == 1)
			//		{
			//			HinhHoc temp = dstam[j];
			//			dstam[j] = dstam[j + 1];
			//			dstam[j + 1] = temp;
			//		}
			//	}
			//}
			#endregion
			#region Selection Sort
			//int csmin = 0;
			//for (int i = 0; i < length - 1; i++)
			//{
			//	for (int j = i; j < length; j++)
			//		if (KiemTraDieuKien(dstam[j], dstam[csmin], k) == -1)
			//			csmin = j;
			//	Swap<HinhHoc>(ref dstam[i], ref dstam[csmin]);
			//}
			#endregion
			#region Interchange Sort
			//for (int i = 0; i < length - 1; i++)
			//{
			//	for (int j = i; j < length; j++)
			//	{
			//		if (KiemTraDieuKien(dstam[i], dstam[j], k) == 1)
			//			Swap<HinhHoc>(ref dstam[i], ref dstam[j]);
			//	}
			//}
			#endregion
			#region QuickSort
			Partition(dstam, 0, length - 1, k);
			#endregion
			return dstam;
		}
		private static void Partition(HinhHoc[] a, int l, int r, KieuSapXep k)
		{
			int i = l;
			int j = r;
			HinhHoc x = new HinhHoc();
			x = a[(l + r) / 2];
			do
			{
				while (KiemTraDieuKien(a[i], x, k) == -1)
					i++;
				while (KiemTraDieuKien(a[j], x, k) == 1)
					j--;
				if (i <= j)
				{
					Swap<HinhHoc>(ref a[i], ref a[j]);
					i++;
					j--;
				}
			} while (i <= j);
			if (l < j)
				Partition(a, l, j, k);
			if (i < r)
				Partition(a, i, r, k);
		}
		
	}
}
