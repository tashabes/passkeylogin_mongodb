using PassKey.Login.MongoDb.Blazor.Server.UI.Data;

namespace PassKey.Login.MongoDb.Blazor.Server.UI.IService
{
    public interface ICompaniesService
    {
        void SaveOrUpdate(Companies company);

        Companies GetCompany(string id);

        List<Companies> GetCompanies();

        string Delete(string companyId);
    }
}