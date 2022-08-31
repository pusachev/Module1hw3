// See https://aka.ms/new-console-template for more information
do
{
    Console.WriteLine("Hello, please enter your string: ");

    string usrString = Console.ReadLine();

    if (string.IsNullOrEmpty(usrString.Trim(' ')))
    {
        Console.WriteLine("Please enter valid string.");
        Console.WriteLine("Press any key to continue.");
        continue;
    }


    string[] parts = usrString.Split(' ');
    string[] result = new string[parts.Length];
    int resIndex = 0;
   
    for (int i = 0; i < parts.Length; i++)
    {
        string word = parts[i];

        char[] symbols = word.ToCharArray();
        int lastIndex = symbols.Length - 1;

        symbols = Array.FindAll(symbols, i => !Char.IsDigit(i));

        if (symbols.Length == 0)
        {
            continue;
        }

        if (i % 2 != 0)
        {
            char[] revers = new char[symbols.Length];
            int j = 0;
            //symbols.Reverse();
            for (int k = symbols.Length - 1; k >= 0; k--, j++)
            {
                revers[j] = symbols[k];
            }

            symbols = revers;
        }

        if (symbols.Length > 1)
        {
            char firstLetter = char.ToUpper(symbols[0]);
            char lastLetter = symbols[lastIndex];

            if (firstLetter == 'P')
            {
                firstLetter = 'S';
            }

            if (char.ToUpper(lastLetter) == 'N')
            {
                lastLetter = 'O';
            }

            symbols[0] = firstLetter;
            symbols[lastIndex] = lastLetter;
        }
        else
        {
            char letter = char.ToUpper(symbols[0]);

            if (letter == 'P')
            {
                letter = 'S';
            }

            if (letter == 'N')
            {
                letter = 'O';
            }

            symbols[0] = letter;
        }

        

        result[resIndex++] = new string(symbols);

    }

    Console.WriteLine(String.Join(' ', result));

    Console.WriteLine("Please pres enter to continue or Esc to exit.");

} while (Console.ReadKey(true).Key != ConsoleKey.Escape);
