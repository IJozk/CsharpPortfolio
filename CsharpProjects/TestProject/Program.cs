// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#!");

// Secuencias de escape 
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

// Insertar comillas a la cadena literal
// Error Console.WriteLine("She said, "Hello!"");
// Corta la cadena antes de terminar el string completo
Console.WriteLine("She said, \"Hello!\"");

// Insertar slash a la cadena literal
// Ejemplo error Console.WriteLine("This is a backslash: \");
// El compilador interpreta el slash como el inicio de una secuencia de escape.
Console.WriteLine("This is a backslash: \\");

// Ejemplos uso de secuencias de escape en un escenario real
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// Literal de cadena textual
/*  Un literal de cadena textual conservará todos los espacios en blanco y los caracteres sin 
    necesidad de usar una secuencia de escape para la barra diagonal inversa. Para crear una cadena 
    textual, use la directiva @ antes de la cadena literal. */

// Ejemplo de literal de cadena textual
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

// Caracteres de escape Unicode
// También puede agregar caracteres codificados en cadenas literales mediante la secuencia de escape 
// \u y, después, un código de cuatro caracteres que represente algún carácter en Unicode (UTF-16).
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");