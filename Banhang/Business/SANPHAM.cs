//==============================================
// Author: AutoNetCoder @ 2015
// Create date: 8/17/2015 9:07:40 AM
// Project: BanHang_Kietbntps
// Description: Auto code by AutoNetCoder
// Website: http://.www.softviet.net
//==============================================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Banhang.Entities;
using Banhang.DAL;
namespace Banhang.Business
{
	public class BSANPHAM
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = DataAccseL.ExecuteData(CommandType.StoredProcedure, "SANPHAM_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = DataAccseL.ExecuteData(CommandType.StoredProcedure, "SANPHAM_SelectTop", pr);
			return all;
		}
		public static ESANPHAM SelectByID(string MASP)
		{
			ESANPHAM OSANPHAM = new ESANPHAM();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MASP", MASP);
			IDataReader idr = DataAccseL.ExecuteReader(CommandType.StoredProcedure, "SANPHAM_SelectByID", pr);
			if (idr.Read())
				OSANPHAM = GetOneSANPHAM(idr);
			idr.Close();
			idr.Dispose();
			return OSANPHAM;
		}
		public static bool TestByID(string MASP)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MASP",MASP);
			pr[0].Direction = ParameterDirection.Output;
			DataAccseL.ExecuteNonQuery(CommandType.StoredProcedure,"SANPHAM_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = DataAccseL.ExecuteData(CommandType.StoredProcedure, "SANPHAM_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(ESANPHAM OSANPHAM)
		{
			SqlParameter[] pr = new SqlParameter[5];
			pr[0] = new SqlParameter(@"MASP", OSANPHAM.MASP);
			pr[1] = new SqlParameter(@"TENSP", OSANPHAM.TENSP);
			pr[2] = new SqlParameter(@"MAL", OSANPHAM.MAL);
			pr[3] = new SqlParameter(@"DONGIA", OSANPHAM.DONGIA);
			pr[4] = new SqlParameter(@"MOTA", OSANPHAM.MOTA);
			DataAccseL.ExecuteNonQuery(CommandType.StoredProcedure, "SANPHAM_Insert", pr);		}
		public static void Update(ESANPHAM OSANPHAM)
		{
			SqlParameter[] pr = new SqlParameter[5];
			pr[0] = new SqlParameter(@"MASP", OSANPHAM.MASP);
			pr[1] = new SqlParameter(@"TENSP", OSANPHAM.TENSP);
			pr[2] = new SqlParameter(@"MAL", OSANPHAM.MAL);
			pr[3] = new SqlParameter(@"DONGIA", OSANPHAM.DONGIA);
			pr[4] = new SqlParameter(@"MOTA", OSANPHAM.MOTA);
			DataAccseL.ExecuteNonQuery(CommandType.StoredProcedure, "SANPHAM_Update", pr);		}
		public static void Delete(string MASP)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MASP", MASP);
			DataAccseL.ExecuteNonQuery(CommandType.StoredProcedure, "SANPHAM_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static ESANPHAM GetOneSANPHAM(IDataReader idr)
		{
			ESANPHAM OSANPHAM = new ESANPHAM();
				if (idr["MASP"] != DBNull.Value)
					OSANPHAM.MASP = (string)idr["MASP"];
				if (idr["TENSP"] != DBNull.Value)
					OSANPHAM.TENSP = (string)idr["TENSP"];
				if (idr["MAL"] != DBNull.Value)
					OSANPHAM.MAL = (string)idr["MAL"];
				if (idr["DONGIA"] != DBNull.Value)
					OSANPHAM.DONGIA = (float)idr["DONGIA"];
				if (idr["MOTA"] != DBNull.Value)
					OSANPHAM.MOTA = (string)idr["MOTA"];
			return OSANPHAM;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<ESANPHAM> ListAll()
		{
		List<ESANPHAM> list = new List<ESANPHAM>();
			IDataReader idr = DataAccseL.ExecuteReader(CommandType.StoredProcedure, "SANPHAM_SelectAll", null);
			while (idr.Read())
				list.Add(GetOneSANPHAM(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<ESANPHAM> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<ESANPHAM> list = new List<ESANPHAM>();
			IDataReader idr = DataAccseL.ExecuteReader(CommandType.StoredProcedure, "SANPHAM_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOneSANPHAM(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<ESANPHAM> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<ESANPHAM> list = new List<ESANPHAM>();
			IDataReader idr = DataAccseL.ExecuteReader(CommandType.StoredProcedure, "SANPHAM_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOneSANPHAM(idr));
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