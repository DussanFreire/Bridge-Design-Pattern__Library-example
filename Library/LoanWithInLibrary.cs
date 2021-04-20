using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class LoanWithInLibrary : Loan
    {
        public override void LoanItem()
        {
            LoanableItem.LoanItem(Borrower, BorrowDetails);
        }
    }
}
