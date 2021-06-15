using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_NangCap
{
	class HinhHoc:IHinhHoc
	{
		float chuVi;
		float dienTich;
		public float CV
		{
			get { return chuVi; }
			set { chuVi = value; }
		}
		public float DT
		{
			get { return dienTich; }
			set { dienTich = value; }
		}
		public virtual float TinhDT()
		{
			return 0;
		}
		public virtual float TinhCV()
		{
			return 0;
		}
	}
}
