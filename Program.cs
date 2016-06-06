//# Copyright 2016, BSD-style copyright and disclaimer apply
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGenerator
{
    class Program
    {
        // <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string[] arr2 = {"http://localhost:9000/", Environment.GetEnvironmentVariable("base")};
            Console.WriteLine(arr2[1]);
            Proxy.SimpleListenerExample(arr2);
        }
    }
}
