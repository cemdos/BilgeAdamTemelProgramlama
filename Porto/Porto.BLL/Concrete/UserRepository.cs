using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Porto.BLL.Interfaces;
using Porto.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoredProcedureEFCore;
using Porto.MODEL.ViewModel;
using Porto.BLL.Common;

namespace Porto.BLL.Concrete
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public BaseResponseModel<UserViewModel>? Login(string userName, string password)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("Username", userName);
            parameters.Add("Password", password);
            var response = ExecProcModel<UserViewModel>("sp_Login", parameters);
            if (response.IsSuccess && response.Model == null)
            {
                response.IsSuccess = false;
                response.ResponseMessage = "Kullanıcı adı yada şifre hatalıdır.";
                response.ResponseType = ResponseType.ValidationError;
            }
            return response;
        }
    }
}
