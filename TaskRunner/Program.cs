using System;
using System.Collections.Generic;
using Lamar;
using Microsoft.Extensions.DependencyInjection;
using TaskRunner.ValidationRules;

namespace TaskRunner
{
    class Program
    {
        static void Main(string[] args)
        {


            var registry = new ServiceRegistry();
            registry.IncludeRegistry<AppServiceRegistry>();

            //setup our DI
            var container = new Container(registry);

            //var container = new Container(x =>
            //{

            //    x.IncludeRegistry<AppServiceRegistry>();
            //    x.Scan(x =>
            //    {
            //        x.Assembly(typeof(Program).Assembly);
            //        x.AddAllTypesOf<ITaskValidation>().NameBy(type => type.Name.ToLower());
            //        x.AddAllTypesOf<IFantasySeries>().NameBy(type => type.Name.ToLower());
            //        x.WithDefaultConventions();

            //    });
            //    ////x.For<IEnumerable<ITaskRun>>().Add(x => x.GetServices<ITaskRun>());
            //    ////x.For<ITaskRun>().Add<NameValidation>();
            //    ////x.For<ITaskRun>().Add<AddressValidation>();


            //    ////x.For<ITaskRun>().Add(y => y.)


            //});


            Console.WriteLine(container.WhatDidIScan());

            var response = container.GetAllInstances<ITaskValidation>();
            Console.WriteLine("Hello World!");

            var runManager = container.GetService<IRunManager>();
            runManager.Run();

            Console.WriteLine("Hello World!");
         }
    }
}
