
namespace TestVersion_2
{
    public class NumberArray
    {
        private int[] _arrayNumbers;
        public int OddCount
        {
            get
            {
                return _arrayNumbers?.Count(x => x % 2 != 0) ?? 0;
            }
        }


        public NumberArray(string input)
        {
            _arrayNumbers = input.Trim().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        }

        public void PrintArray()
        {
            Console.WriteLine($"array = [{string.Join(", ", _arrayNumbers)}]");
        }

        public long GetProductBeforeLastMultipleOfThree()
        {
            long multiple = 1;
            int lastIndex = -1;

            for (int i = _arrayNumbers.Length-1; i >= 0 ; i--)
            {
                if (_arrayNumbers[i] % 3 == 0)
                {
                    lastIndex = i;
                    break;
                }
            }

            for (int i = 0; i < lastIndex; i++)
            {
                multiple *= _arrayNumbers[i];
            }
            return multiple;
        }
    }
}
