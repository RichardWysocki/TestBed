using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRunner
{
    public interface ITaskRun
    {
        public ValidationReturn Execute(ClientModel clientModel);
    }
}
