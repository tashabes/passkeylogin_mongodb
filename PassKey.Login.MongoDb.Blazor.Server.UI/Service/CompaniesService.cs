﻿using MongoDB.Driver;
using PassKey.Login.MongoDb.Blazor.Server.UI.Data;
using PassKey.Login.MongoDb.Blazor.Server.UI.IService;

namespace PassKey.Login.MongoDb.Blazor.Server.UI.Service
{
    public class CompaniesService : ICompaniesService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<Companies> _companyTable = null;

        public CompaniesService()
        {
            _mongoClient = new MongoClient("mongodb://passkeydemo:EATgFnoPVE0Z8yvhOmxxAeaIQqSrZo15vH82SW4VVww5CziwapruXawT7hYewXVNR9HEk5Pk4qGLACDbqvEYzw==@passkeydemo.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@passkeydemo@");
            _database = _mongoClient.GetDatabase("PasskeyLogin");
            _companyTable = _database.GetCollection<Companies>("Companies");
        }
        public string Delete(string companyId)
        {
            _companyTable.DeleteOne(x => x.Id == companyId);
            return "Deleted";

        }



        public List<Companies> GetCompanies()
        {
            return _companyTable.Find(FilterDefinition<Companies>.Empty).ToList();
        }

        public Companies GetCompany(string id)
        {
            return _companyTable.Find(x => x.Id == id).FirstOrDefault();
        }

        public void SaveOrUpdate(Companies company)
        {
            var studentObj = _companyTable.Find(x => x.Id == company.Id).FirstOrDefault();
            if (studentObj == null)
            {
                _companyTable.InsertOne(company);
            }
            else
            {
                _companyTable.ReplaceOne(x => x.Id == company.Id, company);
            }
        }

    }
}