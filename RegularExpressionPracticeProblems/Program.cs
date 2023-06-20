namespace RegularExpressionPracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to perform the operation\n1.matches a string that has an ‘a’ followed by two to three 'b'.\n2.Find Sequence of lowercase letters\n3.Validate HTML Tags\n4.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                PracticeProblems practice=new PracticeProblems();
               switch (option)
                {
                    case 1:
                        practice.MatchString();
                        break;
                        case 2:
                        practice.FindSequenceOfLowerCase();
                        break;
                        case 3:
                        practice.FetchHTMLTags();
                        break;
                    case 4:
                        flag= false;
                        break;
                }
            }
        }
    }
}