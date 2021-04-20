using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public interface ILoanableItem
    {
        void LoanItem(string borrower, string details);
    }
}
