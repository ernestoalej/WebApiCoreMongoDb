using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreMongoDb.Models
{
    
    public class Context 
    {
        private readonly IMongoDatabase db;

        public Context()
        {
            db = new MongoClient("mongodb://localhost:27017").GetDatabase("WebAPICoreMongoDb");
        }


        public IMongoCollection<Post> Posts
        {
            get
            {
                return db.GetCollection<Post>("Posts");
            }
        }


    }
}
