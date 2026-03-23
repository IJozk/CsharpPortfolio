// Se declara una variable de tipo string y se le asigna inmediatamente un valor
string firstName = "Bob";
Console.WriteLine(firstName);
// Se reasigna un nuevo valor a la variable firstName. se puede cambiar el valor de una variables siempre que se requiera pero que cumpla con el tipo de dato declarado
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

// tipo de varianble var, el tipo de dato se infiere a partir del valor asignado
var lastName = "Smith";

// si se le asigna un valor tipo string, luego no se puede asignar uno que no sea compatible como por ejemplo
// lastName = 123.45; // Esto generaría un error de compilación porque el tipo de dato se infiere como string
// Error: CS0029: Cannot implicitly convert type 'decimal' to 'string'
// Las variablkes tipo var deben ser inicializadas en el momento de su declaración para que el compilador pueda inferir el tipo de dato correctamente.

// Declaracion de distintos tipos de variables
string nombre = "Bob";
int messages = 3;
double temperature = 34.4;

Console.Write("Hello, ");
Console.Write(nombre);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius."); 