using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanableItem book = new Book();
            ILoanableItem audioBook = new AudioBook();
            ILoanableItem comic = new Comic();

            Loan loanWithInLibrary = new LoanWithInLibrary();
            loanWithInLibrary.Borrower = "Carlos Soliz";
            loanWithInLibrary.BorrowDetails = "Date: 05/05/2021";

            loanWithInLibrary.LoanableItem = book;
            loanWithInLibrary.LoanItem();

            loanWithInLibrary.LoanableItem = audioBook;
            loanWithInLibrary.LoanItem();

            loanWithInLibrary.LoanableItem = comic;
            loanWithInLibrary.LoanItem();

            TakeOutLoan takeOutLoan = new TakeOutLoan();
            takeOutLoan.Borrower = "Sarah Fernandez";
            takeOutLoan.BorrowDetails = "Date: 05/05/2021";
            takeOutLoan.ReturnDate = "07/04/2021";
            takeOutLoan.BorrowerAddress = "Av. America # 1354";

            takeOutLoan.LoanableItem = comic;
            takeOutLoan.LoanItem();

        }
    }
}
