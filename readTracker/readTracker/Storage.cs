using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goodreads.Models.Response;

namespace readTracker
{
    public static class Storage
    {
        public const string ApiKey = "FTqoN1ox85j5gNbhGIMghA";
        public const string ApiSecret = "b3si0HCHwharaoApTaoL7a5sFA0gpWRlZ5lqfi5Ps";
        public static List<Book> libCarti = new List<Book>();
        private static Dictionary<string, string> _tokens = new Dictionary<string, string>();
        public static void SaveToken(string token, string secret)
        {
            if (!_tokens.ContainsKey(token))
                _tokens.Add(token, secret);
        }

        public static string GetSecretToken(string token)
        {
            return _tokens.ContainsKey(token) ? _tokens[token] : null;
        }
    }
}
