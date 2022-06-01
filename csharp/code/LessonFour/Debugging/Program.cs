using static System.Console;

double a = 4.5;
double b = 2.5;
double answer = Add(a, b);
WriteLine($"{a} + {b} = {answer}");


static double Add(double a1, double b1)
{
    return a1 * b1;
}