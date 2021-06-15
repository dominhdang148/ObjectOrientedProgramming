	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_NangCap
{
	class HinhTron : HinhHoc
	{
		public float banKinh;
		public HinhTron()
		{

		}
		public HinhTron(float bk)
		{
			banKinh = bk;
			CV = (float)Math.Round(2 * Math.PI * banKinh, 2);
			DT = (float)Math.Round(Math.PI * banKinh * banKinh, 2);
		}
		public override float TinhCV()
		{
			return (float)Math.Round(2 * Math.PI * banKinh, 2);
		}
		public override float TinhDT()
		{
			return (float)Math.Round(Math.PI * banKinh * banKinh, 2);
		}
		public override string ToString()
		{
			return "Hinh tron ban kinh " + banKinh + " co chu vi " + CV + " va dien tich " + DT;
		}
	}
}
