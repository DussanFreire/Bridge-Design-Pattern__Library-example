# Library System Using the Bridge Pattern 📕📗📘👓

## Introduction:
This project demonstrates the implementation of the structural design pattern “Bridge.” The pattern was applied to a library system that handles loanable items and their corresponding loan types. The items available for loan fall into three categories: books, comics, and audiobooks. There are also two types of loans: in-library loans and external loans.

For in-library loans, the system only requires the name of the person borrowing the item and a brief description of the loan. However, for external loans, additional information is required, such as the borrower’s address, name, and the return date of the item.

### Bridge Pattern 🌉
The Bridge Pattern is a structural design pattern that separates an abstraction from its implementation, allowing the two to vary independently. This pattern is useful when you want to decouple an interface from its implementation so that both can evolve independently without affecting each other. It can help reduce the complexity of a system by avoiding a proliferation of classes.

Key Components of the Bridge Pattern
1.	Abstraction: This is an interface or abstract class that defines the high-level control logic. It contains a reference to the implementation object and delegates the actual work to it.
2.	Refined Abstraction: A concrete implementation of the abstraction that provides specific functionalities. This class can add additional features while still using the implementation.
3.	Implementor: This is an interface that defines the operations that can be performed. It does not need to be an abstraction of the same type as the Abstraction.
4.	Concrete Implementor: A specific implementation of the Implementor interface that provides the actual behavior. There can be multiple concrete implementors for the same interface.

How It Works
1.	Decoupling: The abstraction contains a reference to an implementor. This way, the abstraction can use different implementations without being tightly coupled to them.
2.	Flexibility: You can change the implementation of the abstraction without altering its interface. Similarly, you can change the abstraction while keeping the same implementor.
3.	Extensibility: New implementations and abstractions can be added easily without modifying existing code.

Example Use Cases
*	Graphics Rendering: A graphics framework where different shapes (like circles, squares) can be rendered using different rendering techniques (like vector or raster).
*	Database Abstraction: An application that can work with different databases (like MySQL, Oracle) while providing the same interface for querying and updating data.

## Implementation: 
To achieve this, a bridge was developed between the ILoanItem interface, which represents loanable items (comic, book, or audiobook), and LoanItem, which defines the loan type (in-library or external).

## Class Diagram:
<div style="text-align:center"><img src="https://github.com/DussanFreire/Library/blob/main/Images/Diagrama%20de%20clases%20loan.png" /></div>
## Sequence Diagram:
<div style="text-align:center"><img src="https://github.com/DussanFreire/Library/blob/main/Images/sequence%20diagram%20bridge.png" /></div>
