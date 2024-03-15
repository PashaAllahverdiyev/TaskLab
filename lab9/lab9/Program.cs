//Task1
//Console.WriteLine("Eded yaz:");
//int n = int.Parse(Console.ReadLine());
//int count = 0;
//for (int i = 0; i < n; i++)
//{
//    int result = n * i;
//    Console.WriteLine(count + "hasili:" + result);
//    count++;
//}

//Task2
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Sample array
int[] arr1 = new int[arr.Length / 3];
int[] arr2 = new int[arr.Length / 3];
int[] arr3 = new int[arr.Length / 3];
for (int i = 0; i < arr.Length; i++)
{
    if (i % 3 == 0)
    {
        arr1[i / 3] = arr[i];
    }
    else if (i % 3 == 1)
    {
        arr2[i / 3] = arr[i];
    }
    else
    {
        arr3[i / 3] = arr[i];
    }
}
Console.WriteLine("arr1: " + string.Join(", ", arr1));
Console.WriteLine("arr2: " + string.Join(", ", arr2));
Console.WriteLine("arr3: " + string.Join(", ", arr3));

//Task3