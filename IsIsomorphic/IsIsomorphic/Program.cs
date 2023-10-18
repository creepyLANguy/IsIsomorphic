using System.Text;

var tests = new List<Tuple<string, string>>()
{
  new("abb", "cdd"),
  new("cassidy", "1234567"),
  new("cass", "1233"),
  new("test", "999"),
  new("tests", "21123"),
  new("abcc", "acbc"),
  new("aaabbbba", "bbbaaaba"),
  new("askljdfhpiouertynm,bxcvzxc234668678967", "askljdfhpiouertynm,bxcvzxc234668678967"),
};

foreach (var test in tests)
{
  Console.WriteLine(IsIsomorphic(test.Item1, test.Item2));
}

bool IsIsomorphic(string s, string t) 
  => s.Length == t.Length && GetFingerprint(s) == GetFingerprint(t);

string GetFingerprint(string input)
{
  var relations = new Dictionary<char, char>();
  
  var i = '0';
  var fingerprint = new StringBuilder();

  foreach (var character in input)
  {
    if (relations.TryAdd(character, i))
    {
      ++i;
    }

    fingerprint.Append(relations[character]);
  }

  return fingerprint.ToString();
}