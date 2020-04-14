using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskRunner
{
    public class RunManager : IRunManager
    {
        public RunManager(IEnumerable<ITaskRun> taskRuns)
        {
            TaskRuns = taskRuns;
        }

        public IEnumerable<ITaskRun> TaskRuns { get; }

        public void Run()
        {
            //var tasks = new List<ITaskRun>() { new NameValidation(), new AddressValidation() };
            var tasks = TaskRuns;

            var newModel = new ClientModel { ClientName = "RichardWysocki", Address1 = "1234 Smith Street", City = null, State = "", Zip = "" };

            var responselist = new List<ValidationReturn>();
            foreach (var item in tasks)
            {
                responselist.Add(item.Execute(newModel));
            }

            foreach (var item in responselist.Where(c => c.Valid == false))
            {
                Console.WriteLine($"Message: {item.ErrorMessage}");
            }

        }


    }
}