using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DL.Contracts
{
    public interface IValidation<TObject>
    {
        bool Validate(TObject objectToValidate, out IList<string> errors);
    }
}
