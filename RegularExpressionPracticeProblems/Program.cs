namespace RegularExpressionPracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to perform the operation\n1.matches a string that has an ‘a’ followed by two to three 'b'.\n2.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                PracticeProblems practice=new PracticeProblems();
               switch (option)
                {
                    case 1:
                        practice.MatchString();
                        break;
                    case 2:
                        flag= false;
                        break;
                }
            }
        }
    }
}