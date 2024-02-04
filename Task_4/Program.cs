int n = 5;
int[] array = { 12, 40, 17, 30, 19 };
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

max = array[0];
for (int j = 0; j < n; j++)
{
    if (max < array[j])
    {
        max = array[j];
    }
}
Console.WriteLine(max);

max = array[0];
foreach(int e in array)

    if (max < e)
    {
        max = e;
    }

Console.WriteLine(max);



