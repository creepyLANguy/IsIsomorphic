var tests = new List<Tuple<string, string>>()
{
  new("abb", "cdd"),
  new("cassidy", "1234567"),
  new("cass", "1233"),
  new("test", "999"),
  new("tests", "21123")
};

foreach (var test in tests)
{
  Console.WriteLine(IsIsomorphic(test.Item1, test.Item2));
}

bool IsIsomorphic(string s, string t) 
  => s.Length == t.Length && GetDistribution(s) == GetDistribution(t);

string GetDistribution(string s)
{
  var orderedBuckets = s
    .GroupBy(c => c)
    .Select(group => group.Count())
    .OrderBy(count => count);
  
  return string.Join(".", orderedBuckets);
}
