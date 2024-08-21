while (true)
{
    Console.Write("Input word (x to exit): ");
    string word = Console.ReadLine()!;
    if (word == "x") break;

    string reverse = String.Join("", word!.ToCharArray().Reverse());

    var isPalindrome = string.Compare(word, reverse, StringComparison.OrdinalIgnoreCase);

    if (isPalindrome == 0)
        Console.WriteLine("String is palindrome");
    else Console.WriteLine("String is not palindrome");
}
