var tests = new List<Tuple<string, string>>()
{
  new("abb", "cdd"),
  new("cassidy", "1234567"),
  new("cass", "1233"),
  new("test", "999"),
  new("tests", "21123"),
  new("abcc", "acbc"),
  new("aaabbbba", "bbbaaaba"),
};

foreach (var test in tests)
{
  Console.WriteLine(IsIsomorphic(test.Item1, test.Item2));
}

bool IsIsomorphic(string s, string t) 
  => s.Length == t.Length && GetDistribution(s) == GetDistribution(t);

int GetDistribution(string input)
{
  var relations = new Dictionary<char, int>();
  
  var i = 0;
  var fingerprint = 0;

  foreach (var character in input)
  {
    relations.TryAdd(character, ++i);
    fingerprint = fingerprint * 10 + relations[character];
  }

  return fingerprint;
}