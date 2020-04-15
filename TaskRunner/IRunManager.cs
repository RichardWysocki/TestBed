using System.Collections.Generic;

namespace TaskRunner
{
    public interface IRunManager
    {
        IEnumerable<ITaskRun> TaskRuns { get; }
        //ITaskRun TaskRuns { get; }
        void Run();
    }
}