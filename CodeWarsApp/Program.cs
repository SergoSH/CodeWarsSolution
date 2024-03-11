using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var stages = new List<(int Num, string Name, bool IsCurrent)>()
            {
                (1,"first", false),
                (2,"second", false),
                (3, "third", false),
                (4,"fourth", false)
            };
            stages.Add((5, "fifth", false));
            var max = stages.Where(c => c.IsCurrent).Max( x => (int?)x.Num)??0;
            Console.WriteLine(max.ToString());
            // Console.ReadLine();
            */

            // const string str = "string";
            // Console.WriteLine ( str.Substring(0, 1).ToLower());

            //int[] arr = new[] { -52, 56, 30, 29, -54, 0, -110 };
            // List<int> ls = new List<int>(arr);
            //Console.WriteLine(arr.Sum(x => x > 0 ? x: 0));
            //int[] arr2 = new int[arr.Length];
            //arr2 = Array.ConvertAll(arr,x => -x);
            //Console.WriteLine(arr);

            //string name = "fucking name";
            //Console.WriteLine(name.Split(" ")[0].Substring(0,1).ToUpper() + "." + name.Split(" ")[1].Substring(0, 1).ToUpper() +".");

            //string str = "Serg";

            //Console.WriteLine($"Hello, {{{str}}} how are you doing today?");
            //int n = 9;
            //decimal sum = 1.00000M;
            //for (int i = n; i > 1; i--)
            //{
            //    sum +=  (decimal)1 / (1 + (i - 1) * 3);
            //}
            //Console.WriteLine(sum.ToString("0.00"));

            //int[] arr = new[] { 1,2,2 };
            //var res = arr.Sum(x => x*x);
            //Console.WriteLine(res);

            //string str = "съешь еще этих мерзких хранцузских булочек, сантахуина!";
            //var lst = str.Split(" ").ToList(); // x => x[0] = String.ToUpper(x[0]));
            //string.Join(" ", lst.Select(x => String.Concat(x[0].ToString().ToUpper(), x.AsSpan(1))));

            //int[] numbers = new[] { 1, 2, 2, 0, -3, -10 };
            ////int[] res = new int[] { numbers.Count(x => x > 0), numbers.Sum(x => x < 0 ? x : 0) };
            //int res = numbers.Sum() - numbers.Max() - numbers.Min();
            //double res2 = numbers.Average();
            //Console.WriteLine(res2);

            //string str = "-1154";
            //int res;
            //Int32.TryParse(str, out res);
            //Console.WriteLine(res);

            /*string str = "45385593107843568";
            char[] charrey = str.ToArray();
            var str1 = Array.ConvertAll(charrey, c => (int)Char.GetNumericValue(c) < 5 ? "0" : "1");
            str = string.Concat(str.Select(a => a < '5' ? "0" : "1"));
            Console.WriteLine(str);
            */
            /*
            long n = 1230;
            char[] charrey = n.ToString().ToArray();
            long [] larray = Array.ConvertAll(charrey, x =>long.Parse(x.ToString()));
            Array.Reverse(larray);
            Console.WriteLine(string.Concat(larray));
            */

            /*
            long n = 624;
            int a = (int) Math.Sqrt(n);
            Console.WriteLine( a * a == n);
            */
            /*
            Dictionary<string, int> grades = new Dictionary<string, int>();
            double grd = 95.0;
            grades.Add("A", 90);
            grades.Add("B", 80);
            grades.Add("C", 70);
            grades.Add("D", 60);
            grades.Add("F", 0);
            var mx = grades.Where (x=>x.Value <= grd).Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine(mx);
            */
            /*
            double speed = 0.7159558476255;
            int res = (int)(speed * 100 / 3.60000);
            Console.WriteLine(res);
            */

            /*
            // вывести число, которое встречается лишь 1 раз 
            int[] arr = { 17, 17, 3, 17, 17, 17, 17 };
            var res = arr.GroupBy(x => x).Single(c => c.Count()==1).Key;
            var x = arr.First(x => arr.Count(i => i == x) == 1); 
            var x1 = arr.Aggregate((a, b) => a ^ b);
            Console.WriteLine(x);
            */

            /*
            //вывести список имен в том же порядке, в которых 4 буквы
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            var friends = names.Where(c => c.Length == 4);
            */

            /*
            //вывести фразу, соответствующую кол-ву лепестков в ромашке
            var phrases = new List<string> {
                "I love you",
                "a little",
                "a lot",
                "passionately",
                "madly",
                "not at all" 
            };
            int x = 7;
            var res = phrases[(x-1) % phrases.Count];
            */

            //перевести возраст кошек и собак в кошачьи и собачьи относительные годы
            /*
            Cat Years
            15 cat years for first year
            +9 cat years for second year
            +4 cat years for each year after that
            Dog Years
            15 dog years for first year
            +9 dog years for second year
            +5 dog years for each year after that
            */
            /*
            int catYear = 15 + (humanYears >= 2 ? 9 + 4 * (humanYears-2): 0);
            int dogYear = 15+ (humanYears >= 2 ? 9 + 5 * (humanYears-2): 0);
   
            return new int[]{humanYears,catYear ,dogYear};
             */
            /*
            int[] catYears = { 15, 9, 4 };
            int[] dogYears = { 15, 9, 5 };

            int humanYears = 2;
            int curCatYears=0;
            foreach (int i in AnimalAge.GetAnimalYears(humanYears, catYears))
            {
                curCatYears += i;
            }

            int curDogYears = 0;
            foreach (int i in AnimalAge.GetAnimalYears(humanYears, dogYears))
            {
                curDogYears += i;
            }

            */

            /*
                        LeetTwoSum lts = new LeetTwoSum();
                        lts.TwoSum(new int[] {0, 1,3,5,6,8,10,12,15},15);
                        var res = lts.TwoSum(new int[] { 3, 3 },6);
                        lts.TwoSum(new int[] {-1,-2,-3,-4,-5 }, -8);
            */

            //  var answer = LeetAddTwoNumbers.AddTwoNumbers (new ListNode(3, new ListNode (2, new ListNode (1))), new ListNode(3, new ListNode(2, new ListNode(9, new ListNode(3)))));
            /* var answer = LeetAddTwoNumbers.AddTwoNumbers(new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))), 
                   new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))));

              // var answer = LeetAddTwoNumbers.AddTwoNumbers(new ListNode(0), new ListNode(0));
   */
            //  var str = LengthOfLongestSubstring.getLengthOfLongestSubstring("");

            //var str = LongestPalindrome.getLongestPalindrome("bavab");

            //var isPalindrome = PalindromeNumber.IsPalindrome(10);

            var str = ZigzagConversion.Convert("PA",1);

            Console.WriteLine("[{0}]", str);
        }

        
    }
}
