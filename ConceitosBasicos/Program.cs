using ConceitosBasicos;


int num1 = 20;
int num2 = 11;
int result;
double res;

Somador soma;
soma = new Somador();
result = soma.Soma(num1, num2);

Console.WriteLine($"A soma dos números {num1} + {num2} é {result}");

Console.WriteLine("A medida 1,76 metros corresponde a " + Conversor.MetrosMilimetros(1.76) +"  milimetros");