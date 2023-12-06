// Format string literals in C#

Console.WriteLine("Hello\nWorld!"); // Line break
Console.WriteLine("Hello\tWorld!"); // tab
Console.WriteLine("Hello \"World\" !"); // Quotes within quotes
Console.WriteLine("c:\\source\\repos"); // Use of bars

// Format output using character escape sequences
Console.WriteLine("------------------");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
// Verbatim string literal

Console.WriteLine("------------------");
Console.WriteLine(@"    c:\source\repos
            (this is where your code goes)");

Console.Write(@"c:\invoices");

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u3060F World!");

// Format output using Unicode escape characters
Console.WriteLine("------------------");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");