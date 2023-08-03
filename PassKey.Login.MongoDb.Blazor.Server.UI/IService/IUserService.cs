﻿using PassKey.Login.MongoDb.Blazor.Server.UI.Data;

namespace PassKey.Login.MongoDb.Blazor.Server.UI.IService
{
    public interface IUserService
    {
        void SaveOrUpdate(Users user);

        Users GetUser(string uniqueIdentifier);

        List<Users> GetUsers();

        string Delete(string userId);
    }
}
