using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_NangCap
{
	class HinhVuong : HinhHoc
	{
		public float canh;
		public HinhVuong()
		{

		}
		public HinhVuong(float c)
		{

			canh = c;
			DT = (float)Math.Round(canh * canh, 2);
			CV = (float)Math.Round(canh * 4, 2);
		}
		public override float TinhDT()
		{
			DT = (float)Math.Round(canh * canh, 2);
			return DT;
		}
		public override float TinhCV()
		{
			CV = (float)Math.Round(canh * 4, 2);
			return CV;
		}
		public override string ToString()
		{
			return "Hinh vuong canh " + canh + " co chu vi " + CV + " va dien tich " + DT;
		}
	}
}
