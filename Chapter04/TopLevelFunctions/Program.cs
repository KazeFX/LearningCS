using static System.Console;

WriteLine("* Top-level functions exanple");

WhatsMyNamespace(); // call the function

void WhatsMyNamespace()
{
    WriteLine("Namespace of Program class: {0},
        arg0: typeof(Program).Namespace ?? "null");
}