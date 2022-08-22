// Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел)
//и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.

Console.Clear();
int[] array = new int[3];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

int[] newArray = new int[3];
for (int j = 0; j < array.Length; j++)
{
    int n = array[j];
    newArray[j] = Factorial(n);
    int Factorial(int n)
    {
        if (n == 1 || n == 0) return 1;

        return n * Factorial(n - 1);
    }
}
Console.WriteLine('[' + string.Join(", ", newArray) + ']');