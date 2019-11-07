using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DL.Contracts
{
    public interface IValidator<TObject>
    {
        bool IsValid(TObject objectToValidate, out IList<string> messages);
    }
}
