﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRunner
{
    class AddressValidation : ITaskRun
    {
        public ValidationReturn Execute(ClientModel clientModel)
        {
            var status = new ValidationReturn() { Valid = true };


            if (clientModel.City?.Length == 0  || clientModel.State?.Length == 0|| clientModel.Zip?.Length == 0|| clientModel.Address1?.Length == 0)
            {
                status.Valid = false;
                status.ErrorMessage = "Client Address must be valid.";
            }
            return status;
        }
    }
}
