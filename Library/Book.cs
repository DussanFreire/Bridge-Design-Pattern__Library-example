using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book : ILoanableItem
    {
        public void LoanItem(string borrower, string details)
        {
            Console.WriteLine("-------------- ITEM LOANED ------------\n* Item: Book\n* Borrower: {0}\n* Details:\n  - {1}\n", borrower, details);
        }
    }
}
