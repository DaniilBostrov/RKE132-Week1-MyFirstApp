//This is a comment, to my code

//rakendus kysib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//strinng - sõne
string userName;

userName = Console.ReadLine();

Console.WriteLine("Hello, " + userName + "!");
//string interpolation

Console.WriteLine($"Hello, {userName}!");