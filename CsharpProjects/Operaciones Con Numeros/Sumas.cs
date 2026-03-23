// Ejemplo suma de  dos valoires numericos

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//  Combinación de tipos de datos para forzar las conversiones implícitas de tipos

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

//  Adición de números y concatenación de cadenas
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

//  Adición de paréntesis para aclarar la intención al compilador
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
