using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_NangCap
{
	class HinhChuNhat : HinhHoc
	{
		public float chieuDai;
		public float chieuRong;
		public HinhChuNhat()
		{

		}
		public HinhChuNhat(float a, float b)
		{
			if (a > b)
			{
				chieuDai = a;
				chieuRong = b;
			}
			else
			{
				chieuDai = b;
				chieuRong = a;
			}
			CV = (float)Math.Round((chieuDai + chieuRong) * 2, 1);
			DT= (float)Math.Round(chieuDai * chieuRong, 1);
		}
		public override float TinhCV()
		{

			return (float)Math.Round((chieuDai + chieuRong) * 2, 1);
		}
		public override float TinhDT()
		{

			return (float)Math.Round(chieuDai * chieuRong, 1);
		}
		public override string ToString()
		{
			return "Hinh chu nhat chieu dai " + chieuDai
				+ " va chieu rong " + chieuRong + " co chu vi " + CV + " va dien tich " + DT;
		}
	}
}
