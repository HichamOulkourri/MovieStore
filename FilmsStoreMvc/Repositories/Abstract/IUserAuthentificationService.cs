using FilmsStoreMvc.Models.DTO;

namespace FilmsStoreMvc.Repositories.Abstract
{
    public interface IUserAuthentificationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
        //Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
