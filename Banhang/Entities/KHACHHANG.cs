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
	public class EKHACHHANG
	{
		public EKHACHHANG()
		{
		}
		public EKHACHHANG(string vMAKH)
		{
			EKHACHHANG OKHACHHANG = BKHACHHANG.SelectByID(vMAKH);
			this.MAKH = OKHACHHANG.MAKH;
			this.TENK = OKHACHHANG.TENK;
			this.GIOITINH = OKHACHHANG.GIOITINH;
			this.SDT = OKHACHHANG.SDT;
			this.DIACHI = OKHACHHANG.DIACHI;
		}
		public EKHACHHANG(string vMAKH, string vTENK, string vGIOITINH, string vSDT, string vDIACHI)
		{
			this.MAKH = vMAKH;
			this.TENK = vTENK;
			this.GIOITINH = vGIOITINH;
			this.SDT = vSDT;
			this.DIACHI = vDIACHI;
		}
		public string MAKH
		{ get;set; }
		public string TENK
		{ get;set; }
		public string GIOITINH
		{ get;set; }
		public string SDT
		{ get;set; }
		public string DIACHI
		{ get;set; }
	}
}