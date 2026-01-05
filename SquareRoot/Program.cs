class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(sqroot(8));  //output 2
        Console.WriteLine(sqroot(4));  //output 2
        Console.WriteLine(sqroot(9));  //output 3
    }
    public static int sqroot(int n)
    {
        if(n<2)
        {
            return n;
        }
        int left = 1;
        int right = n/2;
        int result = 0;
        while (left <= right)
        {
            int mid=left+(right-left)/2;
            long sqr=(long)mid*mid;
            if (sqr == n)
            {
                return mid;
            }
            else if (sqr < n)
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }

        }
        return result; 
    }
}