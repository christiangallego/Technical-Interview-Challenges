// String Compression: Implement a method to perform basic string compression using the counts of repeated characters. 
// For example, the string "aabcccccaaa" would become "a2b1c5a3". If the "compressed" string would not become smaller 
// than the original string, your method should return the original string. 
// You can assume the string has only uppercase and lowercase letters (a-z, A-Z).

//Compress("c");
//Compress("cCc";
//Compress("aaaBccc");

static public string Compress(string s)
{
  string lower = s.ToLower();
  string ans = "";
  int count = 1; 
    for (int i = 0; i < lower.Length - 1; i++)
    {
      if (lower[i] == lower[i + 1])
        count++;
      else
      {
        ans = ans + lower[i] + count;
        count = 1;
      }
    }
    ans = ans + lower[lower.Length - 1] + count;
    return lower.Length < ans.Length ? lower : ans;
}