string input = "a quick brown fox jumps over the lazy dog";
bool containsAllLetters = HasAllLetters(input);

if (containsAllLetters)
    Console.WriteLine("A string contém todas as letras do alfabeto.");
else
    Console.WriteLine("A string não contém todas as letras do alfabeto.");

static bool HasAllLetters(string input)
{
    bool[] alphabetFlags = new bool[26];
    int count = 0;

    foreach (char c in input.ToLower())
    {
        if (char.IsLetter(c))
        {
            int index = c - 'a';
            if (!alphabetFlags[index])
            {
                alphabetFlags[index] = true;
                count++;
            }
        }
    }

    return count == 26;
}