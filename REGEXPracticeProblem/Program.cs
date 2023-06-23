namespace REGEXPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REGEX Practice Problem!");
            Validate validate = new Validate();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter option to choose \n1.Check String \n2.Lowercase Sequence \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEnter string that has an ‘a’ followed by two to three 'b'");
                        string str = Console.ReadLine();
                        validate.validateString(str);
                        break;
                    case 2:
                        string data = "abc_def_ghi_jkl_mno_pqr_stu_vwx_yz";
                        validate.ValidLowercaseSequence(data);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}