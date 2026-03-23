//  Secuencia de escape
//  Un carácter de escape es un carácter especial que se utiliza para representar caracteres que no se pueden escribir directamente en una cadena literal.
//  En C#, se utilizan secuencias de escape para representar caracteres como comillas, saltos de línea, tabulaciones, entre otros. 
// La secuencia de escape se indica con una barra invertida (\) seguida del carácter que se desea representar.

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

//  Literal de cadena textual
/*  Un literal de cadena textual conservará todos los espacios en blanco y los caracteres sin 
    necesidad de usar una secuencia de escape para la barra diagonal inversa. Para crear una cadena 
    textual, use la directiva @ antes de la cadena literal. */

Console.Write(@"c:\invoices");
Console.Write("\n \n");

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

// Caracteres de escape Unicode
// También puede agregar caracteres codificados en cadenas literales mediante la secuencia de escape

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

