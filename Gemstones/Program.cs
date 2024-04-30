class Result
{

    /*
     * Complete the 'gemstones' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY arr as parameter.
     */

    public static int gemstones(List<string> arr)
    {
        var result = 0;
        List<char> reviewedChars = [];

        for (int i = 0; i < arr.Count; i++)
        {
            var stringLenght = arr[i].Count();

            for (int j = 0; j < stringLenght; j++)
            {
                var currentChar = arr[i][j];

                if (reviewedChars.Contains(currentChar)) continue;

                var isExistInAllItems = arr.All(x => x.Any(y => y == currentChar));
                if (isExistInAllItems) result++;

                reviewedChars.Add(currentChar);
            }
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<string> inputList = ["abcdde", "baccd", "eeabg"];
        Result.gemstones(inputList);
    }
}
