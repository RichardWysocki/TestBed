namespace TaskRunner.ValidationRules
{
    public interface ITaskValidation
    {
        public ValidationReturn Execute(ClientModel clientModel);
    }
}
