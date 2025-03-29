using System.Text.RegularExpressions;

namespace ExtractRSV
{
    public class Extract
    {
        public static Dictionary<string, string> FromFile(string filename)
        {
            Dictionary<string, string> rsvPairs = [];
            Regex rsvRegex = new Regex("^(?<type>262)\\|(?<timestamp>[^|]*)\\|(?<locale>[^|]*)\\|(?:[^|]*\\|)(?<key>[^|]*)\\|(?<value>[^|]*)\\|");

            foreach (string line in File.ReadAllLines(filename))
            {
                Match match = rsvRegex.Match(line);

                if (match.Success)
                {
                    string key = match.Groups[4].Value;
                    string value = match.Groups[5].Value;

                    rsvPairs.Add(key, value);
                }
            }

            return rsvPairs;
        }
    }
}
