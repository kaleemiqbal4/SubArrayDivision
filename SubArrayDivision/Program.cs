namespace SubArrayDivision;

public class Program
{
    public static void Main(string[] args)
    {
        // consecutive square is m 
        Console.WriteLine("Enter consecutive square count");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter sum of elemets (consecutive square)");
        // sum of consecutive is d
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Array Length");
        int arrayLength = Convert.ToInt32(Console.ReadLine());
        int[] choclateArray = new int[arrayLength];
        for (int i = 0; i < choclateArray.Length; i++) 
        { 
            Console.WriteLine($"enter of index {i} lement: ");
            choclateArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        SubDivisonArrayClass subDivisonArrayClassObject = new SubDivisonArrayClass();
        int result = subDivisonArrayClassObject.FindSubDivisionArray(d, m, choclateArray);
        Console.WriteLine($"Sub Array Combination will be {result} times");
        Console.ReadLine();
    }
}

public class SubDivisonArrayClass
{
    public int FindSubDivisionArray(int d, int m, int[] choclateArray)
    {
        int result = 0;
        for (int i = 0; i <= choclateArray.Length - m; i++) 
        {
            int count = 0;
            for(int j = i; j < i+m;  j++)
            {
                count += choclateArray[j];
            }

            if(count == d)
            {
                result++;
            }
        }

        return result;
    }
}