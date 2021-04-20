using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public abstract class Loan
    {
        public ILoanableItem LoanableItem { get; set; }
        public string Borrower { get; set; }
        public string BorrowDetails { get; set; }
        public abstract void LoanItem();
    }
}
