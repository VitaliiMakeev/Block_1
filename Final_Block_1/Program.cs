
string[] ArrayWord(string some)
{
    int count = 1;                                  // находим длинну будущего массива
    foreach (var el in some)
    {
        if (Convert.ToString(el) == " ") count++;
    }

    string[] array = new string[count];
    int count_1 = 0;
    string res = "";

    for (int i = 0; i < some.Length; i++)           // наполняем наш массив
    {
        if (Convert.ToString(some[i]) == " ")
        {
            array[count_1] = res;
            count_1++;
            res = "";
        }
        else res += some[i];
        if (i == some.Length - 1) array[count_1] = res;
    }
    int count_2 = 0;
    for (int i = 0; i < array.Length; i++)          // находим длинну нового массива без нулей
    {
        if (array[i] != "") count_2++;
    }
    string[] array_2 = new string[count_2];
    int count_3 = 0;
    for (int i = 0; array.Length > i; i++)          // наполняем наш новый массив элементами
    {
        if (array[i] != "")
        {
            array_2[count_3] = array[i];
            count_3++;
        }
    }
    return array_2;
}

string [] WordThree(string[] array)
{
    string [] result = {"в массиве нет нужных элементов"};
    int cou_1 = 0;
    foreach (var el in array)                       // нахожу длинну нового массива
    {
        if (el.Length <= 3) cou_1++;
    }
    if (cou_1 == 0) return result;
    else
    {
        string[] resArray = new string[cou_1];
        int cou_2 = 0;
        for (int i = 0; i < array.Length; i++)      // наполняю новый массив
        {
            if (array[i].Length <= 3)
            {
                resArray[cou_2] = array[i];
                cou_2++;
            }
        }
        result = resArray;
    }

    return result;

}
Console.WriteLine("Введите любое предложение:");
string someString = Console.ReadLine();
string [] res = ArrayWord(someString);
Console.WriteLine($"[{string.Join(", ", res)}] -> [{string.Join(", ", WordThree(res))}]");
