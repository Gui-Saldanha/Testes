namespace Function
{
    public class Function
    {
        public int NumbersRomansToInt(string numberRoman)
        {
            Dictionary<string, int> dictionaryNumberRomans = new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 }
            };

            int result = 0;

            for (int i = 0; i < numberRoman.Length; i++)
            {
                if (i > 0 && dictionaryNumberRomans[numberRoman[i].ToString()] > dictionaryNumberRomans[numberRoman[i - 1].ToString()])
                    result += dictionaryNumberRomans[numberRoman[i].ToString()] - 2 * dictionaryNumberRomans[numberRoman[i - 1].ToString()];
                else
                    result += dictionaryNumberRomans[numberRoman[i].ToString()];
            }

            return result;
        }

        public IEnumerable<string> FizzBuzz(int valor)
        {
            List<string> listaResultado = new List<string>();

            string resultado = string.Empty;

            for (var n = 1; n <= valor; n++)
            {
                resultado = n.ToString();

                if (n % 3 == 0)
                    resultado = "Fizz";

                if (n % 5 == 0)
                    resultado = "Buzz";

                if (n % 15 == 0)
                    resultado = "FizzBuzz";

                listaResultado.Add(resultado);
            }

            return listaResultado;
        }
    }
}