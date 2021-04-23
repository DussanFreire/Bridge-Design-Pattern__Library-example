using System;

namespace Library
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ILoanableItem book = new Book();
            ILoanableItem audioBook = new AudioBook();
            ILoanableItem comic = new Comic();

            LoanItem loanWithInLibrary = new LoanWithInLibrary();
            loanWithInLibrary.Borrower = "Carlos Soliz";
            loanWithInLibrary.BorrowDetails = "Date: 05/05/2021";

            loanWithInLibrary.LoanableItem = book;
            loanWithInLibrary.Loan();

            loanWithInLibrary.LoanableItem = audioBook;
            loanWithInLibrary.Loan();

            loanWithInLibrary.LoanableItem = comic;
            loanWithInLibrary.Loan();

            TakeOutLoan takeOutLoan = new TakeOutLoan();
            takeOutLoan.Borrower = "Sarah Fernandez";
            takeOutLoan.BorrowDetails = "Date: 05/05/2021";
            takeOutLoan.ReturnDate = "07/06/2021";
            takeOutLoan.BorrowerAddress = "Av. America # 1354";

            takeOutLoan.LoanableItem = comic;
            takeOutLoan.Loan();

            Console.ReadKey();
        }
    }
}
