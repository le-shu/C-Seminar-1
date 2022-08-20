
int [] array = {15,2,53,64,554,66,97,78,29};

int n = array.Length;
int find = 78;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}