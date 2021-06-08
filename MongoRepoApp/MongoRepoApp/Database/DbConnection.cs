using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Configuration;

namespace MongoRepoApp.Database
{
    public static class DbConnection
    {
        public static string ConnectionString = "mongodb+srv://mongo:Admin1234@mongodbcluster.qhwid.mongodb.net/test";
        public static string DBName = "Inventory";
    }
}
