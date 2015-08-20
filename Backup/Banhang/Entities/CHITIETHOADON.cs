//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 8/17/2015 9:07:41 AM
// Project: BanHang_Kietbntps
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Text;
using Banhang.Business;
namespace Banhang.Entities 
{
	public class ECHITIETHOADON
	{
		public ECHITIETHOADON()
		{
		}
		public ECHITIETHOADON(string vSOHOADON, string vMASP)
		{
			ECHITIETHOADON OCHITIETHOADON = BCHITIETHOADON.SelectByID(vSOHOADON, MASP);
			this.SOHOADON = OCHITIETHOADON.SOHOADON;
			this.MASP = OCHITIETHOADON.MASP;
			this.SOLUONG = OCHITIETHOADON.SOLUONG;
			this.CHIETKHAU = OCHITIETHOADON.CHIETKHAU;
		}
		public ECHITIETHOADON(string vSOHOADON, string vMASP, int vSOLUONG, float vCHIETKHAU)
		{
			this.SOHOADON = vSOHOADON;
			this.MASP = vMASP;
			this.SOLUONG = vSOLUONG;
			this.CHIETKHAU = vCHIETKHAU;
		}
		public string SOHOADON
		{ get;set; }
		public string MASP
		{ get;set; }
		public int SOLUONG
		{ get;set; }
		public float CHIETKHAU
		{ get;set; }
	}
}