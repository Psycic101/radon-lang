using System.Text;
using radon_lang;

Console.WriteLine("Hello, World!");

string sourceFile = (args.Length == 0) ? string.Empty : args[0];

if (string.IsNullOrWhiteSpace(sourceFile))
{
    return ErrorCodes.ERROR_BAD_ARGUMENTS;
}

if (!File.Exists(sourceFile))
{
    return ErrorCodes.ERROR_FILE_NOT_FOUND;
}

using (StreamReader sr = new(sourceFile))
{
    StringBuilder sb = new();

    while (!sr.EndOfStream)
    {
        int currChar = sr.Read();
        Console.WriteLine(currChar.ToString());
        sb.Append((char)currChar);
    }

    Console.WriteLine(sb.ToString());
}

return 0;