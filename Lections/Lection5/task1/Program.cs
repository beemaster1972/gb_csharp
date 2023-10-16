int n = 1;
void GetWord(string alphabet, char[] word, int WordLength = 0)
{
  string result = String.Empty;
  if (WordLength == word.Length)
  {
    Console.WriteLine($"{n++} {new String(word)}");
    return;
  }
  for (int i = 0; i < alphabet.Length; i++)
  {
    word[WordLength] = alphabet[i];
    GetWord(alphabet, word, WordLength + 1);
  }
}

GetWord("abcd", new char[5]);
