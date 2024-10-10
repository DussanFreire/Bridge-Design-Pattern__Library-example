# Library System Using the Bridge Pattern 📕📗📘👓

### Introduction:
This project demonstrates the implementation of the structural design pattern “Bridge.” The pattern was applied to a library system that handles loanable items and their corresponding loan types. The items available for loan fall into three categories: books, comics, and audiobooks. There are also two types of loans: in-library loans and external loans.

For in-library loans, the system only requires the name of the person borrowing the item and a brief description of the loan. However, for external loans, additional information is required, such as the borrower’s address, name, and the return date of the item.

### Implementation: 
To achieve this, a bridge was developed between the ILoanItem interface, which represents loanable items (comic, book, or audiobook), and LoanItem, which defines the loan type (in-library or external).

### Class Diagram:<div style="text-align:center"><img src="https://github.com/DussanFreire/Library/blob/main/Images/Diagrama%20de%20clases%20loan.png" /></div>
### Sequence Diagram:<div style="text-align:center"><img src="https://github.com/DussanFreire/Library/blob/main/Images/sequence%20diagram%20bridge.png" /></div>
