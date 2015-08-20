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
	public class BLOAISANPHAM
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "LOAISANPHAM_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "LOAISANPHAM_SelectTop", pr);
			return all;
		}
		public static ELOAISANPHAM SelectByID(string MAL)
		{
			ELOAISANPHAM OLOAISANPHAM = new ELOAISANPHAM();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MAL", MAL);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAISANPHAM_SelectByID", pr);
			if (idr.Read())
				OLOAISANPHAM = GetOneLOAISANPHAM(idr);
			idr.Close();
			idr.Dispose();
			return OLOAISANPHAM;
		}
		public static bool TestByID(string MAL)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MAL",MAL);
			pr[0].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"LOAISANPHAM_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "LOAISANPHAM_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(ELOAISANPHAM OLOAISANPHAM)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"MAL", OLOAISANPHAM.MAL);
			pr[1] = new SqlParameter(@"TENL", OLOAISANPHAM.TENL);
			pr[2] = new SqlParameter(@"MOTA", OLOAISANPHAM.MOTA);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LOAISANPHAM_Insert", pr);		}
		public static void Update(ELOAISANPHAM OLOAISANPHAM)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"MAL", OLOAISANPHAM.MAL);
			pr[1] = new SqlParameter(@"TENL", OLOAISANPHAM.TENL);
			pr[2] = new SqlParameter(@"MOTA", OLOAISANPHAM.MOTA);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LOAISANPHAM_Update", pr);		}
		public static void Delete(string MAL)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MAL", MAL);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LOAISANPHAM_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static ELOAISANPHAM GetOneLOAISANPHAM(IDataReader idr)
		{
			ELOAISANPHAM OLOAISANPHAM = new ELOAISANPHAM();
				if (idr["MAL"] != DBNull.Value)
					OLOAISANPHAM.MAL = (string)idr["MAL"];
				if (idr["TENL"] != DBNull.Value)
					OLOAISANPHAM.TENL = (string)idr["TENL"];
				if (idr["MOTA"] != DBNull.Value)
					OLOAISANPHAM.MOTA = (string)idr["MOTA"];
			return OLOAISANPHAM;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<ELOAISANPHAM> ListAll()
		{
		List<ELOAISANPHAM> list = new List<ELOAISANPHAM>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAISANPHAM_SelectAll", null);
			while (idr.Read())
				list.Add(GetOneLOAISANPHAM(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<ELOAISANPHAM> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<ELOAISANPHAM> list = new List<ELOAISANPHAM>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAISANPHAM_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOneLOAISANPHAM(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<ELOAISANPHAM> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<ELOAISANPHAM> list = new List<ELOAISANPHAM>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAISANPHAM_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOneLOAISANPHAM(idr));
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