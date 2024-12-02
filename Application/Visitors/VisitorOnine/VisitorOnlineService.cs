﻿using Application.Interfaces.Contexts;
using Domain.Visitors;
using MongoDB.Driver;

namespace Application.Visitors.VisitorOnine
{
    public class VisitorOnlineService : IVisitorOnlineService
    {
        private readonly IMongoDBContext <OnlineVisitor>    mongoDbContext; 
        private readonly IMongoCollection  <OnlineVisitor>  mongoCollection;
        public VisitorOnlineService(IMongoDBContext<OnlineVisitor> mongoDbContext)
        {
           this.mongoDbContext = mongoDbContext;
            mongoCollection = mongoDbContext.GetCollection(); 
        }

        public void ConnectUser(string ClientId)
        {
            var exist=  mongoCollection.AsQueryable()
              .FirstOrDefault(p=> p.ClientId == ClientId);
            if (exist == null)
            {
                mongoCollection.InsertOne(new OnlineVisitor
                {
                    ClientId = ClientId,
                    Time = DateTime.Now,
                });
            }
          
        }

        public void DisConnectUser(string ClientId)
        {
            mongoCollection.FindOneAndDelete(p=> p.ClientId == ClientId);   
        }

        public int GetCount()
        {
            return mongoCollection.AsQueryable().Count(); 
        }
    }
}
