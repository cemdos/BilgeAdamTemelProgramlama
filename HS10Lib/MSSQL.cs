using HS10Lib.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HS10Lib
{
    public class MSSQL
    {
        private static MSSQL instance;
        private SqlConnection sqlCon { get; }

        public static MSSQL Instance
        {
            get
            {
                if (instance == null)
                    instance = new MSSQL();
                return instance;
            }
        }

        public MSSQL()
        {
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MsSqlConnection"].ConnectionString);
        }


        public ResponseModel FizikselKomutCalistir(string sqlKomutu)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlCon;
                komut.CommandText = sqlKomutu;
                if (sqlCon.State != System.Data.ConnectionState.Open)
                    sqlCon.Open();
                var etkilenenSatirSayisi = komut.ExecuteNonQuery();
                response.affectedRows = etkilenenSatirSayisi;
                response.ResponseMessage = "Kayıt başarılı";
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                response.ResponseCode = Enums.ResponseCodes.DataBaseError;
                response.Stack = ex.StackTrace;
                response.ResponseMessage = ex.Message;
            }
            return response;
        }
        public ResponseModel FizikselKomutCalistir(string sqlKomutu,List<SqlParameter> parametreler)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                SqlCommand komut = new SqlCommand();
                foreach (var parametre in parametreler)
                    komut.Parameters.Add(parametre);

                komut.Connection = sqlCon;
                komut.CommandText = sqlKomutu;

                if (sqlCon.State != System.Data.ConnectionState.Open)
                    sqlCon.Open();
                var etkilenenSatirSayisi = komut.ExecuteNonQuery();
                response.affectedRows = etkilenenSatirSayisi;
                response.ResponseMessage = "Kayıt başarılı";
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                response.ResponseCode = Enums.ResponseCodes.DataBaseError;
                response.Stack = ex.StackTrace;
                response.ResponseMessage = ex.Message;
            }
            return response;
        }

        public ResponseListModel<TData> SelectKomutu<TData>(string sqlKomutu)  where TData : class
        {
            ResponseListModel<TData> response = new ResponseListModel<TData>();
            try
            {
                DataTable tablo = new DataTable();
                SqlDataAdapter adaptor = new SqlDataAdapter(sqlKomutu, sqlCon);
                adaptor.Fill(tablo);
                var list = ConvertDataTable<TData>(tablo);
                response.ListModel = list;
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                response.ResponseCode = Enums.ResponseCodes.DataBaseError;
                response.Stack = ex.StackTrace;
                response.ResponseMessage = ex.Message;
            }
            return response;
        }
        public ResponseListModel<TData> SelectKomutu<TData>(string sqlKomutu, List<SqlParameter> parametreler) where TData : class
        {
            ResponseListModel<TData> response = new ResponseListModel<TData>();
            try
            {
                DataTable tablo = new DataTable();
                SqlDataAdapter adaptor = new SqlDataAdapter();
                adaptor.SelectCommand = new SqlCommand();
                adaptor.SelectCommand.Connection = sqlCon;
                adaptor.SelectCommand.CommandText = sqlKomutu;
                foreach (var parametre in parametreler)
                    adaptor.SelectCommand.Parameters.Add(parametre);

                adaptor.Fill(tablo);
                var list = ConvertDataTable<TData>(tablo);
                response.ListModel = list;
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                response.ResponseCode = Enums.ResponseCodes.DataBaseError;
                response.Stack = ex.StackTrace;
                response.ResponseMessage = ex.Message;
            }
            return response;
        }



        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

    }
}
