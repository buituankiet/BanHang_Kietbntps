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
	public class BHOADON
	{
//---------------------------------------------------------------------------------------------------------//
		public static DataTable SelectAll()
		{
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "HOADON_SelectAll", null);
			return all;
		}
		public static DataTable SelectTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "HOADON_SelectTop", pr);
			return all;
		}
		public static EHOADON SelectByID(string SOHOADON)
		{
			EHOADON OHOADON = new EHOADON();
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"SOHOADON", SOHOADON);
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "HOADON_SelectByID", pr);
			if (idr.Read())
				OHOADON = GetOneHOADON(idr);
			idr.Close();
			idr.Dispose();
			return OHOADON;
		}
		public static bool TestByID(string SOHOADON)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"SOHOADON",SOHOADON);
			pr[0].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"HOADON_TestByID", pr);
			return Convert.ToBoolean(pr[0].Value);
		}
		public static DataTable SelectPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "HOADON_SelectPage", pr);
			RowCount = Convert.ToInt32(pr[2].Value);
			return all;
		}
//---------------------------------------------------------------------------------------------------------//
		public static void Insert(EHOADON OHOADON)
		{
			SqlParameter[] pr = new SqlParameter[5];
			pr[0] = new SqlParameter(@"SOHOADON", OHOADON.SOHOADON);
			pr[1] = new SqlParameter(@"NGAYHOADON", OHOADON.NGAYHOADON);
			pr[2] = new SqlParameter(@"MAKH", OHOADON.MAKH);
			pr[3] = new SqlParameter(@"NHANVIEN", OHOADON.NHANVIEN);
			pr[4] = new SqlParameter(@"GHICHU", OHOADON.GHICHU);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "HOADON_Insert", pr);		}
		public static void Update(EHOADON OHOADON)
		{
			SqlParameter[] pr = new SqlParameter[5];
			pr[0] = new SqlParameter(@"SOHOADON", OHOADON.SOHOADON);
			pr[1] = new SqlParameter(@"NGAYHOADON", OHOADON.NGAYHOADON);
			pr[2] = new SqlParameter(@"MAKH", OHOADON.MAKH);
			pr[3] = new SqlParameter(@"NHANVIEN", OHOADON.NHANVIEN);
			pr[4] = new SqlParameter(@"GHICHU", OHOADON.GHICHU);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "HOADON_Update", pr);		}
		public static void Delete(string SOHOADON)
		{
			SqlParameter[] pr = new SqlParameter[1];
			pr[0] = new SqlParameter(@"SOHOADON", SOHOADON);
			SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "HOADON_Delete", pr);		}
//---------------------------------------------------------------------------------------------------------//
		 private static EHOADON GetOneHOADON(IDataReader idr)
		{
			EHOADON OHOADON = new EHOADON();
				if (idr["SOHOADON"] != DBNull.Value)
					OHOADON.SOHOADON = (string)idr["SOHOADON"];
				if (idr["NGAYHOADON"] != DBNull.Value)
					OHOADON.NGAYHOADON = (DateTime)idr["NGAYHOADON"];
				if (idr["MAKH"] != DBNull.Value)
					OHOADON.MAKH = (string)idr["MAKH"];
				if (idr["NHANVIEN"] != DBNull.Value)
					OHOADON.NHANVIEN = (string)idr["NHANVIEN"];
				if (idr["GHICHU"] != DBNull.Value)
					OHOADON.GHICHU = (string)idr["GHICHU"];
			return OHOADON;
		}
//---------------------------------------------------------------------------------------------------------//
		public static List<EHOADON> ListAll()
		{
		List<EHOADON> list = new List<EHOADON>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "HOADON_SelectAll", null);
			while (idr.Read())
				list.Add(GetOneHOADON(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EHOADON> ListTop(string Top ,string Where,string Order)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"Top", Top);
			pr[1] = new SqlParameter(@"Where", Where);
			pr[2] = new SqlParameter(@"Order", Order);
			List<EHOADON> list = new List<EHOADON>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "HOADON_SelectTop", pr);
			while (idr.Read())
				list.Add(GetOneHOADON(idr));
			if (idr.IsClosed == false)
			{
				idr.Close();
				idr.Dispose();
			}
			return list;
		}
		public static List<EHOADON> ListPage(int CurrentPage, int PageSize, out int RowCount)
		{
			SqlParameter[] pr = new SqlParameter[3];
			pr[0] = new SqlParameter(@"CurrentPage", CurrentPage);
			pr[1] = new SqlParameter(@"PageSize", PageSize);
			pr[2] = new SqlParameter(@"RowCount", SqlDbType.Int);
			pr[2].Direction = ParameterDirection.Output;
			List<EHOADON> list = new List<EHOADON>();
			IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "HOADON_SelectPage", pr);
			while (idr.Read())
				list.Add(GetOneHOADON(idr));
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