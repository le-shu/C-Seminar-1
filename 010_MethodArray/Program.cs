
int [] array = {15,2,53,64,554,66,64,78,29};

int n = array.Length;
int find = 64;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // при повторе одинаковых элементов быдаст только первый (прервет ветвление)
    }
    index++;
}