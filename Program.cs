//Task1.
//Task: Given an integer,N , print its first 10 multiples.
//Each multiple N x i (where 1 <= i <= 10) should be printed on a new line in the form: N x i = result.

Console.WriteLine("Reqem daxil edin:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int result = n * i;
    Console.WriteLine($"{n} x {i} = {result}");
}


//Task2.
//Write a program that evenly distributes the elements of the array named array among the array1, array2 and array3 arrays according to the following rule:
//Oth element in array1, 1st -> array2, 2nd -> array3, 3rd > array1, etc.
//Requirements:
//The program must not read anything from the keyboard.
//The program must evenly distribute elements of the array array to array1, array2 and array3 arrays.


//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12 };
//int length = arr.Length;

//int[] arr1 = new int[length / 3];
//int[] arr2 = new int[length / 3];
//int[] arr3 = new int[length / 3];

//Array.Copy(arr, 0, arr1, 0, length / 3);
//Array.Copy(arr, length / 3, arr2, 0, length / 3);
//Array.Copy(arr, 2 * length / 3, arr3, 0, length / 3);

//Console.WriteLine("Massiv1:");
//Array.ForEach(arr1, Console.WriteLine);

//Console.WriteLine("Massiv2:");
//Array.ForEach(arr2, Console.WriteLine);

//Console.WriteLine("Massiv3:");
//Array.ForEach(arr3, Console.WriteLine);

//Task3.
//Create a string array with the following names:
//{ Vahid, Nicat, Gülər, Gözəl, Ulduz, Famil, Dadaş, Vagif, Ümid, Durna };
//Print the words that contain the letter "u"
//after them add new array.After using that new array values, replace the letter "u" with the letter "e". (after again print)
//Do not use methods.

//string[] names = { "Vahid", "Nicat", "Guler", "Gozel", "Ulduz", "Famil", "Dadaş", "Vagif", "Ümid", "Durna" };


//Console.WriteLine("U > herf olan sozler.");
//foreach (string name in names)
//{
//    if (name.Contains("u") || name.Contains("ü"))
//    {
//        Console.WriteLine(name);
//    }
//}


//Console.WriteLine("Evez edilmis soz: 'u' buna 'e':");
//foreach (string name in names)
//{
//    Console.WriteLine(name.ToLower().Replace('u', 'e').Replace('ü', 'e'));
//}


