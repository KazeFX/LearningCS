

double a = 4.5;
double b = 2.5;
double answer = Add(a, b);

WriteLine($"{a} + {b} = {answer}");
WriteLine("Press Enter to end the app.");
ReadLine(); // Wait for Enter/


double Add(double a, double b)
{
    return a * b; // deliberate bug!
}