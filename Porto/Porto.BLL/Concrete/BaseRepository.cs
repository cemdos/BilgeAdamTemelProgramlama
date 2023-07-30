using Microsoft.EntityFrameworkCore;
using Porto.BLL.Common;
using Porto.BLL.Interfaces;
using Porto.MODEL;
using StoredProcedureEFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        public BaseResponse Add(T model)
        {
            var result = new BaseResponse();
            try
            {
                Database.Context.Set<T>().Add(model);
                Database.Save();
                return result;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ResponseType = ResponseType.DbError;
                result.ResponseMessage = ex.Message;
            }
            return result;
        }

        public BaseResponseModel<T>? Get(int Id)
        {
            var result = new BaseResponseModel<T>();
            try
            {
                result.Model = GetAll().ModelList?.Where(x => x.ID == Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ResponseType = ResponseType.DbError;
                result.ResponseMessage = ex.Message;
            }
            return result;
        }

        public BaseResponseList<T> GetAll()
        {
            var result = new BaseResponseList<T>();
            try
            {
                result.ModelList = Database.Context.Set<T>().Where(x => x.Deleted == false).ToList();
                return result;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ResponseType = ResponseType.DbError;
                result.ResponseMessage = ex.Message;
            }
            return result;
        }

        public BaseResponse Remove(int Id)
        {
            var result = new BaseResponse();
            try
            {
                var removingData = Get(Id)?.Model;
                if (removingData == null)
                    throw new Exception("Silinecek kayıt bulunamadı");

                removingData.DelDate = DateTime.Now;
                removingData.Deleted = true;
                Database.Context.Entry<T>(removingData).State = EntityState.Modified;
                Database.Context.Set<T>().Update(removingData);
                Database.Save();
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ResponseType = ResponseType.DbError;
                result.ResponseMessage = ex.Message;
            }
            return result;
        }

        public BaseResponse Update(T model)
        {
            var result = new BaseResponse();
            try
            {
                model.ModDate = DateTime.Now;
                Database.Context.Entry(model).State = EntityState.Modified;
                Database.Context.Set<T>().Update(model);
                Database.Save();
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ResponseType = ResponseType.DbError;
                result.ResponseMessage = ex.Message;
            }
            return result;
        }

        public BaseResponseList<TViewModel> ExecProc<TViewModel>(string procName, Dictionary<string, dynamic> parameters)
            where TViewModel : class, new()
        {
            BaseResponseList<TViewModel> response = new BaseResponseList<TViewModel>();
            try
            {
                if (Database.Context.Database.CanConnect())
                    Database.Context.Database.CloseConnection();

                var builder = Database.Context.LoadStoredProc(procName);
                foreach (var param in parameters)
                    builder.AddParam(param.Key, param.Value);

                builder.Exec(r => response.ModelList = r.ToList<TViewModel>());

                if (Database.Context.Database.CanConnect())
                    Database.Context.Database.CloseConnection();

                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ResponseType = ResponseType.DbError;
                response.ResponseMessage = ex.Message;
            }
            return response;
        }

        public BaseResponseModel<TViewModel> ExecProcModel<TViewModel>(string procName, Dictionary<string, dynamic> parameters)
           where TViewModel : class, new()
        {
            BaseResponseModel<TViewModel> response = new BaseResponseModel<TViewModel>();
            try
            {
                var result = ExecProc<TViewModel>(procName, parameters);
                response.IsSuccess = result.IsSuccess;
                response.Model = result.ModelList?.FirstOrDefault();
                response.ResponseType = result.ResponseType;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ResponseType = ResponseType.DbError;
                response.ResponseMessage = ex.Message;
            }
            return response;
        }
    }
}
