﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServet_http
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpServer server = new HttpServer("http://localhost:8888/");
            server.Start();
        }
    }
}
