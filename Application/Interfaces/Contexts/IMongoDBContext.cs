﻿using Domain.Visitors;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Contexts
{
    public interface IMongoDBContext <T>
    {
        public IMongoCollection<T> GetCollection();
    }
}
