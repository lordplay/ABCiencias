using ABCiencias.Models.User;

namespace ABCiencias.Models.Servicos.Users
{
    public interface IUserService
    {
        UserDTO Autentica(UserDTO user);
    }
}