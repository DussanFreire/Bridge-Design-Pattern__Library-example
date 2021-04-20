# Biblioteca 📕📗📘👓

### Introducción:
En el siguiente trabajo se muestra la implementación del patrón estructural "Bridge", este patrón fue aplicado para el caso de una biblioteca, la cual tiene ítems para prestar y hace préstamos. Los ítems para prestar pueden ser de 3 tipos: libros, comics y audiolibros. Y los préstamos pueden ser de tipo: dentro la biblioteca o prestamos externos.
Los préstamos que son para leer dentro de la biblioteca no requieren más información que el nombre de la persona, la cual se prestó el ítem, y una breve descripción del préstamo. En cambio para los prestamos externo, se requiere saber la dirección de la persona, la cual se prestó el ítem, nombre y también la fecha de retorno

### Desarrollo: 
Para eso se desarrolló un puente entre "ILoanItem" que es un ítem prestable (comic, libro o audiolibro) y "LoanItem" que hace referencia al tipo de préstamo de un ítem que puede ser dentro de la biblioteca o externo 

### Diagrama de clases:<div style="text-align:center"><img src="https://github.com/DussanFreire/Library/blob/main/Images/d.%20clases%20loan.png" /></div>
### Diagrama de Secuencia:<div style="text-align:center"><img src="https://github.com/DussanFreire/Library/blob/main/Images/sequence%20diagram%20bridge.png" /></div>
