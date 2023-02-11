
string hello = "  z hello, world! Here I am?  ";

Console.WriteLine(hello);


int stringLength = hello.Length;

//string trimmedString = hello.Trim(); // Trim võtab maha tühikud sõne eest ja tagant

hello = hello.Trim();

// Lause esimese tähe suureks muutmine

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter= hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);


// sõnade lugemine

//int wordCounter = 1;

//// 1 võimalus
//for (int i = 0; i < hello.Length; i++)
//{
//    if (hello[i] == ' ')
//    {
//        wordCounter++;
//    }
//}

//// 2 võimalus
//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");
