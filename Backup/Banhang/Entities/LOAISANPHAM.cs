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
	public class ELOAISANPHAM
	{
		public ELOAISANPHAM()
		{
		}
		public ELOAISANPHAM(string vMAL)
		{
			ELOAISANPHAM OLOAISANPHAM = BLOAISANPHAM.SelectByID(vMAL);
			this.MAL = OLOAISANPHAM.MAL;
			this.TENL = OLOAISANPHAM.TENL;
			this.MOTA = OLOAISANPHAM.MOTA;
		}
		public ELOAISANPHAM(string vMAL, string vTENL, string vMOTA)
		{
			this.MAL = vMAL;
			this.TENL = vTENL;
			this.MOTA = vMOTA;
		}
		public string MAL
		{ get;set; }
		public string TENL
		{ get;set; }
		public string MOTA
		{ get;set; }
	}
}