Console.WriteLine("1. Write your first program using c# ");

Console.WriteLine("Hello, World!");
Console.WriteLine("Congratulations");
Console.WriteLine("It works");

Console.WriteLine("2. https://learn.microsoft.com/training/modules/csharp-literals-variables/ "); 

Console.WriteLine('b');

// Console.WriteLine('Hello World'); //compiler expects a single character when single qoutes are used
Console.WriteLine(123);
Console.WriteLine(0.25F);     // float 32 bits(4bytes)
Console.WriteLine(2.625);     // double 64 bits (8 bytes)
Console.WriteLine(12.39816m); // decimal 128 bits (64 bytes )
Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine("3. https://learn.microsoft.com/training/modules/csharp-basic-formatting/ ");
Console.WriteLine("Hello\nWorld");
Console.WriteLine("Hello\tWorld");

Console.WriteLine("c:\\source\\repos");


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.WriteLine(@"     c:\source\repos
		it works ");

Console.WriteLine(@"c:\invoices");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

int x = 5;
Console.WriteLine($" x is ${x}");

Console.WriteLine("4 https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/2-exercise-add-numbers ");
int firstNum = 12;
int secNum = 7;
Console.WriteLine(firstNum + secNum);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int result = 3 + 1 * 5 / 2;
Console.WriteLine(result);

