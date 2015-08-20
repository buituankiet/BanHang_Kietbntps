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
	public class BKHACHHANG
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "KHACHHANG_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "KHACHHANG_SelectTop", pr);
			return all;
		}
		public static EKHACHHANG SelectByID(string MAKH)
		{
			EKHACHHANG OKHACHHANG = new EKHACHHANG();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MAKH", MAKH);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "KHACHHANG_SelectByID", pr);
			if (idr.Read())
				OKHACHHANG = GetOneKHACHHANG(idr);
			idr.Close();
			idr.Dispose();
			return OKHACHHANG;
		}
		public static bool TestByID(string MAKH)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MAKH",MAKH);
			pr[0].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"KHACHHANG_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "KHACHHANG_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EKHACHHANG OKHACHHANG)
		{
			SqlParameter[] pr = new SqlParameter[5];
			pr[0] = new SqlParameter(@"MAKH", OKHACHHANG.MAKH);
			pr[1] = new SqlParameter(@"TENK", OKHACHHANG.TENK);
			pr[2] = new SqlParameter(@"GIOITINH", OKHACHHANG.GIOITINH);
			pr[3] = new SqlParameter(@"SDT", OKHACHHANG.SDT);
			pr[4] = new SqlParameter(@"DIACHI", OKHACHHANG.DIACHI);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "KHACHHANG_Insert", pr);		}
		public static void Update(EKHACHHANG OKHACHHANG)
		{
			SqlParameter[] pr = new SqlParameter[5];
			pr[0] = new SqlParameter(@"MAKH", OKHACHHANG.MAKH);
			pr[1] = new SqlParameter(@"TENK", OKHACHHANG.TENK);
			pr[2] = new SqlParameter(@"GIOITINH", OKHACHHANG.GIOITINH);
			pr[3] = new SqlParameter(@"SDT", OKHACHHANG.SDT);
			pr[4] = new SqlParameter(@"DIACHI", OKHACHHANG.DIACHI);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "KHACHHANG_Update", pr);		}
		public static void Delete(string MAKH)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"MAKH", MAKH);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "KHACHHANG_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EKHACHHANG GetOneKHACHHANG(IDataReader idr)
		{
			EKHACHHANG OKHACHHANG = new EKHACHHANG();
				if (idr["MAKH"] != DBNull.Value)
					OKHACHHANG.MAKH = (string)idr["MAKH"];
				if (idr["TENK"] != DBNull.Value)
					OKHACHHANG.TENK = (string)idr["TENK"];
				if (idr["GIOITINH"] != DBNull.Value)
					OKHACHHANG.GIOITINH = (string)idr["GIOITINH"];
				if (idr["SDT"] != DBNull.Value)
					OKHACHHANG.SDT = (string)idr["SDT"];
				if (idr["DIACHI"] != DBNull.Value)
					OKHACHHANG.DIACHI = (string)idr["DIACHI"];
			return OKHACHHANG;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EKHACHHANG> ListAll()
		{
		List<EKHACHHANG> list = new List<EKHACHHANG>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "KHACHHANG_SelectAll", null);
			while (idr.Read())
				list.Add(GetOneKHACHHANG(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EKHACHHANG> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EKHACHHANG> list = new List<EKHACHHANG>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "KHACHHANG_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOneKHACHHANG(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EKHACHHANG> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EKHACHHANG> list = new List<EKHACHHANG>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "KHACHHANG_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOneKHACHHANG(idr));
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