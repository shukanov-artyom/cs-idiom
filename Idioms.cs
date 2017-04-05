// If-Try idiom
// Idiom which builds logic on top of Try-method:

string input = Console.ReadLine();
int a;
if (Int32.TryParse(input, out a))
{
    // successful parse branch
    // Use a variable 
}
else
{
    // unsuccessful parse branch
}

// C# 7 version of this idiom: 
string input = Console.ReadLine();
if (Int32.TryParse(input, out int a))
{
    Console.WriteLine("Parsed input successfully!");
    // Use a variable 
}
else
{
    Console.WriteLine("Could not parse your input, sorry.")
}
