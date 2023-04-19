public static string ReverseStringWithoutWords(string str)
{
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    int start = 0, end = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == ' ')
        {
            end = i - 1;
            ReverseWord(arr, start, end);
            start = i + 1;
        }
        else if (i == arr.Length - 1)
        {
            end = i;
            ReverseWord(arr, start, end);
        }
    }
    return new string(arr);
}

public static void ReverseWord(char[] arr, int start, int end)
{
    while (start < end)
    {
        char temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }
}

string str1 = "The weather is so sunny nowadays";
string str2 = "Life is so beautiful";
string reversedStr1 = ReverseStringWithoutWords(str1);
string reversedStr2 = ReverseStringWithoutWords(str2);
Console.WriteLine(reversedStr1);
Console.WriteLine(reversedStr2);





