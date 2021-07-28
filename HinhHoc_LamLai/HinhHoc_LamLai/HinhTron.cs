using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc_LamLai
{
	class HinhTron:HinhHoc
	{
		private double banKinh;
		public double radius
		{
			get { return banKinh; }
			set { banKinh = value; }
		}
		public HinhTron() { }
		public HinhTron(double r)
		{
			banKinh = r;
		}
		public override double tinhCV()
		{
			return Math.Round(2 * Math.PI * banKinh,2);
		}
		public override double tinhDT()
		{
			return Math.Round(Math.PI * banKinh * banKinh,2);
		}
		public override string ToString()
		{
			return "Hinh tron ban kinh " + banKinh + " co chu vi " + tinhCV() + " va dien tich " + tinhDT();
		}
	}
}
