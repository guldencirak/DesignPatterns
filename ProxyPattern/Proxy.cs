﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Proxy:Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();

            _realSubject.Request();
        }
    }
}
