namespace TaskRunner.ValidationRules
{
    public class NameValidation : ITaskValidation
    {
        public ValidationReturn Execute(ClientModel clientModel)
        {
            var status = new ValidationReturn() { Valid = true };


            if (clientModel.ClientName?.Length == 0)
            {
                status.Valid = false;
                status.ErrorMessage = "Client Name must contain a valid value";
            }
            return status;
        }
    }
}
