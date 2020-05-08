namespace TaskRunner.ValidationRules
{
    public class TaskValidationRun : ITaskValidation
    {
        public ValidationReturn Execute(ClientModel clientModel)
        {
            return new ValidationReturn();
        }
    }
}
