int n = 5;
int[] array = { 2, 4, 7, 3, 9 };
int i = 0;
int max = array[i];
while (i < n)
{
    if (max < array[i])
    { 
        max = array[i];
        }
    i = i + 1;
}

Console.WriteLine(max);
