/*Программа формирует одномерный массив произвольной длины, вводимый пользователем и 
подсчитывает количество положительных чисел в массиве.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

Console.WriteLine("Нажмите клавишу 'Q', если хотите прекратить ввод");
int[] arrUser = GetArrayFromUser("Введите ", "-й элемент массива: ");

int count = CountOfPositiveNumber(arrUser);

PrintResult(arrUser, count);

//--------------------------------------------
static int[] GetArrayFromUser(string message1, string message2)
{
    int[] tempArr = new int[1];
    for(int i = 0; ; i++)	// Бесконечный цикл, прерываемый пользователем
    {
    Console.Write(message1 + i + message2);
	string y = Console.ReadLine() ?? "";
	if(y == "q" || y == "Q")	// прерываем ввод элементов массива по нажатию "q"
	    break;
    	Array.Resize(ref tempArr, i + 1);	//Меняем размер массива по мере увеличения количества его элементов
    	tempArr[i] = int.Parse(y);   
    }
    return tempArr;
}

//---------------------------------------
static int CountOfPositiveNumber(int[] arr)
{
	int summ = 0;
	foreach(int el in arr)
	{
		if(el > 0)
			summ += 1;
	}
	return summ;
}

//--------------------------------
static void PrintResult(int[] arr, int count) => Console.WriteLine($"{String.Join(", ", arr)} -> {count}");