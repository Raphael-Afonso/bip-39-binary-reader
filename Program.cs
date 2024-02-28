// Path to the file containing BIP-39 English words
using System.Text.RegularExpressions;

string wordsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "english.txt");

// Read BIP-39 words from the file
string[] allWords = File.ReadAllLines(wordsFilePath);

// Request 12 phrases
for (int i = 0; i < 12; i++)
{
    Console.Write($"Enter phrase {i + 1} (12-bit binary): ");
    string userInput = Console.ReadLine() ?? string.Empty;

    // Validate if input is 12-bit binary
    if (!BinaryPattern().IsMatch(userInput) || userInput.Length != 12)
    {
        Console.WriteLine("Invalid input. Use 0 or 1, and ensure a length of 12.");

        // Repeat loop
        i--;
        continue;
    }

    // Convert binary input to int
    int wordIndex = Convert.ToInt32(userInput, 2);

    // Check if the index is within the valid range
    if (wordIndex < 0 || wordIndex >= allWords.Length)
    {
        Console.WriteLine("Index is out of range. Try again.");

        // Repeat loop
        i--;
        continue;
    }

    // Display the selected word for the input phrase
    string selectedWord = allWords[wordIndex];
    Console.WriteLine($"Phrase {i + 1} is: {selectedWord}");
}

// Define a partial class to contain the generated regex
partial class Program
{
    [GeneratedRegex("^[01]{12}$")]
    private static partial Regex BinaryPattern();
}