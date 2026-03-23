// Interpolación de cadenas
// La interpolación de cadenas es una forma de construir cadenas de texto que permite incluir expresiones dentro de una cadena literal.
// En C#, se utiliza el símbolo $ antes de la cadena literal para indicar que se trata de una cadena interpolada.

// Ejemplo de interpolación de cadenas
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

// También se pueden incluir expresiones más complejas dentro de las llaves, como operaciones matemáticas o llamadas a métodos.
int version = 11;
string updateText = "Update to Windows";
string message2 = $"{updateText} {version}";
Console.WriteLine(message2);


//  Combinar literales textuales y interpolación de cadenas
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");