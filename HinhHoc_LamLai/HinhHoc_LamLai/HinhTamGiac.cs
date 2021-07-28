using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc_LamLai
{
	class HinhTamGiac : HinhHoc
	{
		private double canhA;
		private double canhB;
		private double canhC;
		public double edgeA
		{
			get { return canhA; }
			set { canhA = value; }
		}
		public double edgeB
		{
			get { return canhB; }
			set { canhB = value; }
		}
		public double edgeC
		{
			get { return canhC; }
			set { canhC = value; }
		}
		public HinhTamGiac() { }
		public HinhTamGiac(double a, double b, double c)
		{
			canhA = a;
			canhB = b;
			canhC = c;
		}
		public double TimCanhLonNhat()
		{
			double max = canhA;
			if (max < canhB)
				max = canhB;
			else
				if (max < canhC)
				max = canhC;
			return max;
		}
		public double TimCanhNhoNhat()
		{
			double min = canhA;
			if (min > canhB)
				min = canhB;
			else
				if (min > canhC)
				min = canhC;
			return min;
		}
		public static bool KTraTamGiac(double a, double b, double c)
		{
			if ((a < b + c) && (b < a + c) && (c < b + a))
				return true;
			return false;
		}
		public override double tinhCV()
		{
			return canhA + canhB + canhC;
		}
		public override double tinhDT()
		{
			double p = tinhCV() / 2;
			return Math.Round(Math.Sqrt(p * (p - canhA) * (p - canhB) * (p - canhC)),2);
		}
		public override string ToString()
		{
			return "Hinh tam giac canh a " + canhA + ", canh b " + canhB + ", canh c " + canhC + " co chu vi " + tinhCV() + " va dien tich " + tinhDT();
		}
	}
}
