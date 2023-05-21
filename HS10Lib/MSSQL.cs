using HS10Lib.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS10Lib
{
    public class MSSQL
    {
        private static MSSQL instance;

        public static MSSQL Instance
        {
            get
            {
                if (instance == null)
                    instance = new MSSQL();
                return instance;
            }
        }

        private SqlConnection sqlCon => new SqlConnection(ConfigurationManager.ConnectionStrings["MsSqlConnection"].ConnectionString);

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

    }
}
