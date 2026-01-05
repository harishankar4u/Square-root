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
        int left = 1; //square root cannot be less than 1 (for n ≥ 2)
        int right = n; //square root of any number > 1 is never greater than n/2
        int result = 0; //stores best possible answer so far
        while (left <= right)
        {
            int mid=left+(right-left)/2;
            long square = (long)mid * mid;
            if (square== n)
            {
                return mid;
            }
            else if(square<n)
            {
                result = mid;
                left = mid+1;
                
            }
            else
            {
                right = right - 1;
            }
        }

        return result;
    }
}