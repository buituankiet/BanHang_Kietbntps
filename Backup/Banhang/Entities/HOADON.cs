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
	public class EHOADON
	{
		public EHOADON()
		{
		}
		public EHOADON(string vSOHOADON)
		{
			EHOADON OHOADON = BHOADON.SelectByID(vSOHOADON);
			this.SOHOADON = OHOADON.SOHOADON;
			this.NGAYHOADON = OHOADON.NGAYHOADON;
			this.MAKH = OHOADON.MAKH;
			this.NHANVIEN = OHOADON.NHANVIEN;
			this.GHICHU = OHOADON.GHICHU;
		}
		public EHOADON(string vSOHOADON, DateTime vNGAYHOADON, string vMAKH, string vNHANVIEN, string vGHICHU)
		{
			this.SOHOADON = vSOHOADON;
			this.NGAYHOADON = vNGAYHOADON;
			this.MAKH = vMAKH;
			this.NHANVIEN = vNHANVIEN;
			this.GHICHU = vGHICHU;
		}
		public string SOHOADON
		{ get;set; }
		public DateTime NGAYHOADON
		{ get;set; }
		public string MAKH
		{ get;set; }
		public string NHANVIEN
		{ get;set; }
		public string GHICHU
		{ get;set; }
	}
}