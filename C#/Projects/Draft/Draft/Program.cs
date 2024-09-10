namespace Draft
{
    class Program
    {
        static void Main(string[] args)
        {

            //string characterName = Console.ReadLine();
            //int characterAge = int.Parse(Console.ReadLine());
            //Console.WriteLine("There once was a man named " + characterName);
            //Console.WriteLine("He was " + characterAge + " years old");
            //Console.WriteLine("He really liked the name " + characterName);
            //Console.WriteLine("But didnt like being " + characterAge);
            
            Console.Write("enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your math symbol Add +, Sub -, Mul *, Divide /");
            string mathSymbol = Console.ReadLine();
            Console.Write("enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (mathSymbol == "-")
            {
                double subNumber = num1 - num2;
                Console.WriteLine(subNumber);
            }
            else if (mathSymbol == "+")
            {
                double addNumber = num1 + num2;
                Console.WriteLine(addNumber);
            }
            else if (mathSymbol == "*")
            {
                double mulNumber = num1 * num2;
                Console.WriteLine(mulNumber);
            }
            else
            {
                double divNumber = num1 / num2;
                Console.WriteLine(divNumber);
            }


            




            Console.ReadLine();
        }
    }
}