using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class TakeOutLoan : LoanItem
    {
        public string ReturnDate { get; set; }
        public string BorrowerAddress { get;  set; }

        public override void Loan()
        {
            string fullDetails = GetFullDatailInfo();
            LoanableItem.LoanItem(Borrower, fullDetails);
        }

        private string GetFullDatailInfo()
        {
            string fullDetails = string.Format("{0}\n  - Return Date:{1}\n  - Type of Loan: Take-out loan\n  - Borrower Address: {2}", BorrowDetails, ReturnDate, BorrowerAddress);
            return fullDetails;
        }
    }
}
