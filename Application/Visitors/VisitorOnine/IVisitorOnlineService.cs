﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Visitors.VisitorOnine
{
    public interface IVisitorOnlineService
    {
        void ConnectUser(string ClientId);
        void DisConnectUser(string ClientId);
        int GetCount ();    
    }
}
