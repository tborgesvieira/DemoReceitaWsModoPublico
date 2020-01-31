using System.Text.RegularExpressions;

namespace ReceitaWs.Helpers
{
    public static class Extensions
    {
        public static string LimparCnpj(this string cnpj)
        {
            var pattern = @"[^0-9]";

            var rgx = new Regex(pattern);

            return rgx.Replace(cnpj.Trim(), "");
        }
    }
}
