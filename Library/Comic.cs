using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Comic : ILoanableItem
    {
        public void LoanItem(string borrower, string details)
        {
            Console.WriteLine("-------------- ITEM LOANED ------------\n* Item: Comic\n* Borrower: {0}\n* Details:\n  - {1}\n", borrower, details);
        }
    }
}
