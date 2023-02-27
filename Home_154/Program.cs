/* 
Home_154.
    Даны два неупорядоченных массива, но элементы связанны индексами.
    В первом массиве указаны фамилии и инициалы,
    во втором массиве стоят оценки по информатике каждого ученика.
    Вывести оценочную ведомость учеников:
        а). упорядоченного по фамилии;
        б). упорядоченного по оценкам.
*/

/*
От себя:
    Оба масстива имеют одинаковый размер (допустим 10).
    Первый сожержит строковой индекс и Ф.И.О.
    Второй содержит цифровой индекс и оценку [1-5]
*/
Console.Clear();

// Задаем массивы
string[,] famArray = {
//  ID      Family
    {"5",   "Беловошин В.Е."},
    {"3",   "Карпов О.Е."},
    {"7",   "Сергеев С.А."},
    {"2",   "Воронов В.Н."},
    {"6",   "Зинченко Г.А."},
    {"4",   "Кузнецов М.Н."},
    {"8",   "Афонин О.П."},
    {"9",   "Щетинин С.В."},
    {"1",   "Тимохин А.А."},
    {"10",  "Жукин С.В."}
};

int[,] gradArray = {
//  ID, GRADLE
    {3, 3},
    {2, 5},
    {5, 4},
    {8, 4},
    {10,3},
    {4, 4},
    {1, 5},
    {6, 5},
    {7, 3},
    {9, 4},
};

// печать исходных массивов
void prntArrays(string[,] famArray)
{
    Console.Write($"famArray[i,j] = Value\tfamArray[i,j] = Value\n");
    for (int i = 0; i < famArray.GetLength(0); i++)
    {
        for (int j = 0; j < famArray.GetLength(1); j++)
        {
            Console.Write($"famArray[{i},{j}] = {famArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

string[,] BubbleSort(string[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0) - 1; i++)
        if (string.CompareOrdinal(inArray[i, 1], inArray[i + 1, 1]) > 0)
        {
            // для ID
            string temp0 = inArray[i, 0];
            inArray[i, 0] = inArray[i + 1, 0];
            inArray[i + 1, 0] = temp0;

            // для Фамилий
            string temp1 = inArray[i, 1];
            inArray[i, 1] = inArray[i + 1, 1];
            inArray[i + 1, 1] = temp1;
        }
    return inArray;
}

Console.WriteLine("\nИсходный массив:\n");
prntArrays(famArray);

Console.WriteLine("\nСортировка по столбцам:\n");
famArray = BubbleSort(famArray);
prntArrays(famArray);
