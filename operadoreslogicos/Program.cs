// See https://aka.ms/new-console-template for more information

var (valor1, valor2, valor3) = (true, false, true);
bool resultand = valor1 && valor2;
Console.WriteLine(resultand);
bool resultador = (valor1 && valor2) || valor3;
Console.WriteLine(resultador);
bool resutafuerte = (valor1 || valor3) ^ valor2; 
Console.WriteLine(resutafuerte);



