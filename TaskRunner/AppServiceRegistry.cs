using Lamar;
using TaskRunner.ValidationRules;

namespace TaskRunner
{
    public class AppServiceRegistry : ServiceRegistry
    {
        public AppServiceRegistry()
        {
           Scan(x =>
                {
                    x.Assembly(typeof(Program).Assembly);
                    x.AddAllTypesOf<ITaskValidation>().NameBy(type => type.Name.ToLower());
                    x.AddAllTypesOf<IFantasySeries>().NameBy(type => type.Name.ToLower());
                    x.WithDefaultConventions();

                });
        }
    }
}
