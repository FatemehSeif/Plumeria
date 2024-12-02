using Application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
using Domain.Visitors;

namespace Presistance.Context.MongoContext
{



    public class MongoDBContext<T> : IMongoDBContext <T>
    {
        private readonly IMongoDatabase db;
        private readonly IMongoCollection<T> mongoCollection;
        public MongoDBContext()
        {
            var Connection = "mongodb://localhost:27017/";
            var databaseName = "VisitorDb";
            try
            {
                Connection = "mongodb://localhost:27017/"; 
                                                               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to MongoDB: {ex.Message}");
              
            }
            var client = new MongoClient(Connection);

    
            db = client.GetDatabase(databaseName);
            mongoCollection = db.GetCollection<T>(typeof(T).Name);
        }

        

        public IMongoCollection<T> GetCollection()
        {
            return mongoCollection;
        }


    }











}