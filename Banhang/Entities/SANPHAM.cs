//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 8/17/2015 9:07:40 AM
// Project: BanHang_Kietbntps
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Text;
using Banhang.Business;
namespace Banhang.Entities 
{
	public class ESANPHAM
	{
		public ESANPHAM()
		{
		}
		public ESANPHAM(string vMASP)
		{
			ESANPHAM OSANPHAM = BSANPHAM.SelectByID(vMASP);
			this.MASP = OSANPHAM.MASP;
			this.TENSP = OSANPHAM.TENSP;
			this.MAL = OSANPHAM.MAL;
			this.DONGIA = OSANPHAM.DONGIA;
			this.MOTA = OSANPHAM.MOTA;
		}
		public ESANPHAM(string vMASP, string vTENSP, string vMAL, float vDONGIA, string vMOTA)
		{
			this.MASP = vMASP;
			this.TENSP = vTENSP;
			this.MAL = vMAL;
			this.DONGIA = vDONGIA;
			this.MOTA = vMOTA;
		}
		public string MASP
		{ get;set; }
		public string TENSP
		{ get;set; }
		public string MAL
		{ get;set; }
		public float DONGIA
		{ get;set; }
		public string MOTA
		{ get;set; }
	}
}