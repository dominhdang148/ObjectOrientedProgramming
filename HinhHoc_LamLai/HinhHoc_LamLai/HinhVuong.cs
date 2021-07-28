using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc_LamLai
{
	class HinhVuong : HinhHoc
	{
		private double canh;
		public double edge
		{
			get { return canh; }
			set { canh = value; }
		}
		public HinhVuong()
		{ }
		public HinhVuong(double a)
		{
			canh = a;
		}
		public override double tinhDT()
		{
			return canh * canh;
		}
		public override double tinhCV()
		{
			return canh * 4;
		}
		public override string ToString()
		{
			string str;
			str = "Hinh vuong canh " + canh + " co chu vi " + tinhCV() + " va dien tich " + tinhDT();
			return str;
		}
	}
}
