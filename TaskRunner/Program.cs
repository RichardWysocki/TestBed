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

            //setup our DI
            var container = new Container(x =>
            {
                // Using StructureMap style registrations
                //x.Scan(x =>
                //{
                //    x.Assembly(typeof(Program).Assembly);
                //    x.WithDefaultConventions();

                //});
                x.Scan(x =>
                {
                    x.Assembly(typeof(Program).Assembly);
                    x.AddAllTypesOf<ITaskValidation>().NameBy(type => type.Name.ToLower());
                    x.AddAllTypesOf<IFantasySeries>().NameBy(type => type.Name.ToLower());
                    x.WithDefaultConventions();
                });
                //x.For<IEnumerable<ITaskRun>>().Add(x => x.GetServices<ITaskRun>());
                //x.For<ITaskRun>().Add<NameValidation>();
                //x.For<ITaskRun>().Add<AddressValidation>();


                //x.For<ITaskRun>().Add(y => y.)


            });
            


            var response = container.GetAllInstances<ITaskValidation>();
            Console.WriteLine("Hello World!");

            var bar = container.GetService<IRunManager>();
            bar.Run();

            //var x = new RunManager();
            //x.Run();
            Console.WriteLine("Hello World!");
         }
    }
}
