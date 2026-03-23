//  Opererador +=
Console.WriteLine($"Opererador +=");
int value = 0;     // value is now 0.
Console.WriteLine($"Valor inicial: {value}");
value = value + 5; // value is now 5.
Console.WriteLine($@"Valor sumando 5 de la forma 'value = value + 5;' =  {value}");
value += 5;        // value is now 10.
Console.WriteLine($@"Valor sumando 5 de la forma 'value += 5; ' =   {value}"+"\n");

//  Operador ++ 
int value2 = 0;    // value is now 0.
Console.WriteLine($"Opererador ++");
value2 = value2 + 1; // value is now 1.
Console.WriteLine($@"Valor sumando 1 de la forma 'value = value + 1;' =  {value2}");
value2 ++;        // value is now 2.
Console.WriteLine($@"Valor sumando 1 de la forma 'value ++; ' =   {value2}"+"\n");

// Codigo para incrementar y disminuir un valor
Console.WriteLine($"Incrementar y disminuir un valor");
int value3 = 1;
Console.WriteLine("Initial value: " + value3);
value3 = value3 + 1;
Console.WriteLine("First increment: " + value3);
value3 += 1;
Console.WriteLine("Second increment: " + value3);
value3++;
Console.WriteLine("Third increment: " + value3);
value3 = value3 - 1;
Console.WriteLine("First decrement: " + value3);
value3 -= 1;
Console.WriteLine("Second decrement: " + value3);
value3--;
Console.WriteLine("Third decrement: " + value3);

// Colocación de los operadores de incremento y decremento
// ++valor primero realiza la suma y luego asigna el valor
// valor++ se asigna el vfalor y luego se suma
Console.WriteLine("Colocacion de operadores de incremento y decremento");
//  Ejemplo
int value4 = 1;
value4++;
Console.WriteLine("First: " + value4);
Console.WriteLine($"Second: {value4++}");
Console.WriteLine("Third: " + value4);
Console.WriteLine("Fourth: " + (++value4));

