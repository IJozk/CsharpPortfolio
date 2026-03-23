//  Operaciones basicas

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//  Division con decimales

//  Casos correctos
decimal decimalQuotient1 = 7 / 5.0m;
decimal decimalQuotient2 = 7.0m / 5.0m;
Console.WriteLine($"Decimal quotient case 1: {decimalQuotient1}");
Console.WriteLine($"Decimal quotient case 2: {decimalQuotient2}");

//  Casos incorrectos o inexactos
// int decimalQuotientA = 7 / 5.0m;
// int decimalQuotientB = 7.0m / 5;
// int decimalQuotientC = 7.0m / 5.0m;
// decimal decimalQuotientD = 7 / 5;

// Agregar código para convertir los resultados de la división de enteros

int first = 7;
int second = 5;
//  Conversión a decimal
decimal quotientR = (decimal)first / (decimal)second;
Console.WriteLine(quotientR);

//  Operador modulo
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
//  resultado 0 si el numero es divisible por el que se da como segundo parametro

//  Orden PEMDAS: Parentheses - Exponents - Multiplication/Division( izquierda a derecha ) - Addition/Subtraction ( izquierda a derecha )

// Ejemplo

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);