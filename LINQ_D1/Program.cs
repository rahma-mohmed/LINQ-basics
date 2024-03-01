namespace LINQ_D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var res = numbers.Where(x => x % 2 == 0);
            foreach (int x in res)
            {
               Console.WriteLine(x);
            }

            // basic
            //var res2 = Enumerable.Where(numbers , x => x % 2 == 0);

            var res2 = 
                from n in numbers
                where n % 2 == 0
                select n;

            foreach (int x in res2)
            {
                Console.WriteLine(x);
            }

            List<string> w = new List<string>() { "i", "love", "asp.net" };
            //var res3 = w.Select(x => x.ToUpper());
            var res3 = from word in w
                      select word.ToUpper();

            foreach (var i in res3)
            {
                Console.WriteLine(i);
            }

            string[] sentence = { "I love asp.net core", "I like sql server also", "in general i love programming" };
            var res4 = sentence.SelectMany(x => x.Split(" "));
            foreach ( var i in res4 )
            {
                Console.WriteLine(i);
            }

            string[] c = { "Red", "Green", "Blue" };
            string[] h = { "FF000", "00FF00", "0000FF" };

            var res5 = c.Zip(h, (c , h) => $"{c} {h}");
            foreach(var r in res5)
            {
                Console.WriteLine(r);
            }

            
        }
    }
}
