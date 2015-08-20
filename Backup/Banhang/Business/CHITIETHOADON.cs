//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 8/17/2015 9:07:41 AM
// Project: BanHang_Kietbntps
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Banhang.Entities;
using Banhang.DataAccess;
namespace Banhang.Business
{
	public class BCHITIETHOADON
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "CHITIETHOADON_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "CHITIETHOADON_SelectTop", pr);
			return all;
		}
		public static ECHITIETHOADON SelectByID(string SOHOADON, string MASP)
		{
			ECHITIETHOADON OCHITIETHOADON = new ECHITIETHOADON();
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"SOHOADON", SOHOADON);
			pr[1] = new SqlParameter(@"MASP", MASP);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "CHITIETHOADON_SelectByID", pr);
			if (idr.Read())
				OCHITIETHOADON = GetOneCHITIETHOADON(idr);
			idr.Close();
			idr.Dispose();
			return OCHITIETHOADON;
		}
		public static bool TestByID(string SOHOADON, string MASP)
		{
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"SOHOADON",SOHOADON);
			pr[1] = new SqlParameter(@"MASP",MASP);
			pr[1].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"CHITIETHOADON_TestByID", pr);
			return Convert.ToBoolean(pr[1].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "CHITIETHOADON_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(ECHITIETHOADON OCHITIETHOADON)
		{
			SqlParameter[] pr = new SqlParameter[4];
			pr[0] = new SqlParameter(@"SOHOADON", OCHITIETHOADON.SOHOADON);
			pr[1] = new SqlParameter(@"MASP", OCHITIETHOADON.MASP);
			pr[2] = new SqlParameter(@"SOLUONG", OCHITIETHOADON.SOLUONG);
			pr[3] = new SqlParameter(@"CHIETKHAU", OCHITIETHOADON.CHIETKHAU);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "CHITIETHOADON_Insert", pr);		}
		public static void Update(ECHITIETHOADON OCHITIETHOADON)
		{
			SqlParameter[] pr = new SqlParameter[4];
			pr[0] = new SqlParameter(@"SOHOADON", OCHITIETHOADON.SOHOADON);
			pr[1] = new SqlParameter(@"MASP", OCHITIETHOADON.MASP);
			pr[2] = new SqlParameter(@"SOLUONG", OCHITIETHOADON.SOLUONG);
			pr[3] = new SqlParameter(@"CHIETKHAU", OCHITIETHOADON.CHIETKHAU);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "CHITIETHOADON_Update", pr);		}
		public static void Delete(string SOHOADON, string MASP)
		{
			SqlParameter[] pr = new SqlParameter[2];
			pr[0] = new SqlParameter(@"SOHOADON", SOHOADON);
			pr[1] = new SqlParameter(@"MASP", MASP);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "CHITIETHOADON_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static ECHITIETHOADON GetOneCHITIETHOADON(IDataReader idr)
		{
			ECHITIETHOADON OCHITIETHOADON = new ECHITIETHOADON();
				if (idr["SOHOADON"] != DBNull.Value)
					OCHITIETHOADON.SOHOADON = (string)idr["SOHOADON"];
				if (idr["MASP"] != DBNull.Value)
					OCHITIETHOADON.MASP = (string)idr["MASP"];
				if (idr["SOLUONG"] != DBNull.Value)
					OCHITIETHOADON.SOLUONG = (int)idr["SOLUONG"];
				if (idr["CHIETKHAU"] != DBNull.Value)
					OCHITIETHOADON.CHIETKHAU = (float)idr["CHIETKHAU"];
			return OCHITIETHOADON;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<ECHITIETHOADON> ListAll()
		{
		List<ECHITIETHOADON> list = new List<ECHITIETHOADON>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "CHITIETHOADON_SelectAll", null);
			while (idr.Read())
				list.Add(GetOneCHITIETHOADON(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<ECHITIETHOADON> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<ECHITIETHOADON> list = new List<ECHITIETHOADON>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "CHITIETHOADON_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOneCHITIETHOADON(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<ECHITIETHOADON> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<ECHITIETHOADON> list = new List<ECHITIETHOADON>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "CHITIETHOADON_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOneCHITIETHOADON(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			RowCount = Convert.ToInt32(pr[2].Value);
			return list;
		}
	}
}