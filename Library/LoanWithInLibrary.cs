using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class LoanWithInLibrary : LoanItem
    {
        public override void Loan()
        {
            LoanableItem.LoanItem(Borrower, BorrowDetails);
        }
    }
}
