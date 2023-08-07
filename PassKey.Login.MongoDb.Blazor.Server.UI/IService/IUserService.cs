using PassKey.Login.MongoDb.Blazor.Server.UI.Data;

namespace PassKey.Login.MongoDb.Blazor.Server.UI.IService
{
    public interface IUserService
    {
        void SaveOrUpdate(Users user);

        Users GetUser(string uniqueIdentifier);

        Users GetUserByPhone(string phoneNumber);

        List<Users> GetUsers();

        List<Users> GetUsersByGroupID(string groupId);

        string Delete(string userId);
    }
}
