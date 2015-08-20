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
using System.Configuration;
using System.Web;
namespace AppCode.Connection
{
	public static class ConnectionString
	{
   		// Connect string for application
		private static string strconnection = @"Data Source=DESKTOP-G718EVO;Database=BanHang_Kietbntps;integrated Security=SSPI";
		// Connect string for website
		//private static string strconnection =  ConfigurationManager.ConnectionStrings["AutoNetCoderConnectionString"].ToString();
		public static string Text
		{
			get { return strconnection; }
			set { strconnection = value; }
		}
	}
}