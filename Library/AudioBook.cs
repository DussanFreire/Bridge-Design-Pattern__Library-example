using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class AudioBook : ILoanableItem
    {
        public void LoanItem(string borrower, string details)
        {
            Console.WriteLine("-------------- ITEM LOANED ------------\n* Item: AudioBook\n* Borrower: {0}\n* Details:\n  - {1}\n", borrower, details);
        }
    }
}
