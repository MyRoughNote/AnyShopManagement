using AnyShopManagement.Models;
namespace AnyShopManagement.Interface
{
    public interface IValidate
    {
        bool Validate(AuthenticateRequest request);
        AuthenticateRequest GetAuthenticate(AuthenticateRequest request);
        AuthenticateRequest ResetPassword(AuthenticateRequest request);
    }
}
