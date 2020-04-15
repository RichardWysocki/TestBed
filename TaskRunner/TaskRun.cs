using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRunner
{
    public class TaskRunX : ITaskRun
    {
        public ValidationReturn Execute(ClientModel clientModel)
        {
            return new ValidationReturn();
        }
    }
}
