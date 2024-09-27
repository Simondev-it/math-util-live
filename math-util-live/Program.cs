namespace math_util_live
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("this code test for git ");

            SumAll();

            
        }

        static void SumAll()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)

                sum += i;
            Console.WriteLine("Tổng giá trị từ 1 đến 10 là :{0} ",sum );


        }
    }
}
