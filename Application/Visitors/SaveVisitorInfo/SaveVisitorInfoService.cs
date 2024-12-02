using Application.Interfaces.Contexts;
using Azure.Core;
using Domain.Visitors;
using MongoDB.Driver;

namespace Application.Visitors.SaveVisitorInfo
{
    public class SaveVisitorInfoService : ISaveVisitorInfoService
    {
        private readonly IMongoDBContext<Visitor> _mongoDBContext;
        private readonly IMongoCollection<Visitor> _VisitorMongoCollection;
      
        public SaveVisitorInfoService(IMongoDBContext <Visitor> mongoDBContext)
        {
            _mongoDBContext = mongoDBContext;
            _VisitorMongoCollection = _mongoDBContext.GetCollection();    
        }
        public void Execute(RequestSaveVisitorInfoDto request)
        {

            if (_VisitorMongoCollection != null)
            {
                try
                {
                    _VisitorMongoCollection.InsertOne(new Visitor
                    {
                        Browser = new VisitorVersion
                        {
                            Family = request.Browser.Family,
                            Version = request.Browser.Version
                        },
                        CurrentLink = request.CurrentLink,
                        Device = new Device
                        {
                            Brand = request.Device.Brand,
                            Family = request.Device.Family,
                            IsSpider = (bool)request.Device.IsSpider,
                            Model = request.Device.Model
                        },
                       Ip= request.Ip ,
                        Method = request.Method,
                        OperationSystem = new VisitorVersion
                        {
                            Family = request.OperationSystem.Family,
                            Version = request.OperationSystem.Version

                        },
                        PhysicalPath = request.PhysicalPath,
                        Protocol = request.Protocol,
                        RefferLink = request.RefferLink, 
                        VisitorId = request.VisitorId,  
                        Time = DateTime.Now,    


                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting visitor data into MongoDB: {ex.Message}");
                    // Handle the exception 
                }
            }
            else
            {
                Console.WriteLine("MongoDB collection is null. Cannot save visitor data.");
            }

        }
    }
}


