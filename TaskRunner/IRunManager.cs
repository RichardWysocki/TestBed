using System.Collections.Generic;
using TaskRunner.ValidationRules;

namespace TaskRunner
{
    public interface IRunManager
    {
        IEnumerable<ITaskValidation> TaskRuns { get; }
        //ITaskRun TaskRuns { get; }
        void Run();
    }
}