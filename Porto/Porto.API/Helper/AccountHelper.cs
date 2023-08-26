using Porto.MODEL.ViewModel;
using System.IdentityModel.Tokens.Jwt;

namespace Porto.API.Helper
{
    public static class AccountHelper
    {
        public static UserViewModel GetUserInfo(HttpRequest request)
        {
            var responseModel = new UserViewModel();
            string jwtToken = request.Headers["Authorization"].ToString().Remove(0, 7);
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken decodedToken = tokenHandler.ReadJwtToken(jwtToken);
            responseModel.Role = decodedToken.Payload?["Role"].ToString() ?? string.Empty;
            responseModel.ID = int.Parse(decodedToken.Payload?["UserID"].ToString() ?? "0");
            return responseModel;
        }
    }
}
