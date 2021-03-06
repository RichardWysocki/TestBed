﻿using System;
using System.Collections.Generic;
using System.Linq;
using TaskRunner.ValidationRules;

namespace TaskRunner
{
    public class RunManager : IRunManager
    {
        //public RunManager(ITaskRun taskRuns)
        public RunManager(IEnumerable<ITaskValidation> taskRuns)
        {
            TaskRuns = taskRuns;
        }

        public IEnumerable<ITaskValidation> TaskRuns { get; }
        //public ITaskRun TaskRuns { get; }

        public void Run()
        {
            //var tasks = new List<ITaskRun>() { new NameValidation(), new AddressValidation() };
            var tasks = TaskRuns;
            //var tasks = new List<ITaskRun>();
            //tasks.Add(TaskRuns);
            

            var newModel = new ClientModel { ClientName = "RichardWysocki", Address1 = "1234 Smith Street", City = null, State = "", Zip = "" };

            var responselist = new List<ValidationReturn>();
            foreach (var item in tasks)
            {
                Console.WriteLine($"This is the Type: {item.GetType()}");
                responselist.Add(item.Execute(newModel));
            }

            foreach (var item in responselist.Where(c => c.Valid == false))
            {
                Console.WriteLine($"Message: {item.ErrorMessage}");
            }

        }


    }
}