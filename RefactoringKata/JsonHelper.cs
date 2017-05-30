using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringKata
{
    public static class JsonHelper
    {
        public static string GetJson(IEnumerable<KeyValuePair<string, object>> pairs)
        {
            var sb = new StringBuilder();
            var jsons = pairs.Select(p => string.Format("\"{0}\": {1}", p.Key, GetValString(p.Value)));
            sb.Append(string.Format("{{{0}}}", string.Join(", ", jsons)));
            return sb.ToString();
        }

        private static string GetValString(object p)
        {
            var collection = p as ICollection;
            if (collection != null)
            {
                var jsons = new List<string>();
                foreach (var item in collection)
                {
                    jsons.Add(GetValString(item));
                }

                return string.Format("[{0}]", string.Join(", ", jsons));
            }

            var json = p as IJson;
            if (json != null)
            {
                return json.ToJson();
            }

            switch (p.GetType().ToString())
            {
                case "System.Int16":
                case "System.Int32":
                case "System.Int64":
                case "System.Double":
                case "System.Decimal":
                    return p.ToString();

                default:
                    return string.Format("\"{0}\"", p);
            }
        }
    }
}