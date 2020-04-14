using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRunner
{
    class NameValidation : ITaskRun
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
