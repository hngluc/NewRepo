using System;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Chuong Trinh Doan So====");

            var random = new Random();
            int target = random.Next(100, 999);
            var targetString = target.ToString();

            int attemp = 1, MAX_GUESS = 7;
            string guess, fback = "";
            while (fback != "+++" && attemp <= MAX_GUESS)
            {
                Console.Write($"Lan doan thu {attemp}: ");
                guess = Console.ReadLine();
                fback = GetFeedBack(targetString, guess);
                Console.WriteLine($"Phan hoi tu may tinh: {fback}");
                attemp++;
            }
            Console.WriteLine($"Nguoi choi da doan: {attemp - 1}. Tro choi ket thuc!");
            if (attemp > MAX_GUESS)
                Console.WriteLine("Nguoi choi da thua cuoc. So can doan la: {0}", target);
            else
                Console.WriteLine("Nguoi choi thang!", attemp);
            Console.ReadLine();
        }

        private static string GetFeedBack(string target, string guess)
        {
            string fback = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == guess[i])
                    fback += "+";
                else if (target.Contains(guess[i].ToString()))
                    fback += "?";
            }
            return fback;
        }
    }
}
