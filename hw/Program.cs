using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace hw
{
    class Program
    {
        static int Checked_int()
        {
            int n = 0;
            if (int.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;
        }
        static long Checked_long()
        {
            long n = 0;
            if (long.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;
        }
        static double Checked_double()
        {
            double n = 0;
            if (double.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Вы хотите завести банковский счет?");
            string answer = Console.ReadLine().ToLower();
            while (answer.Equals("да"))
            {
                Banking.Bank bank = new Banking.Bank();
                Console.WriteLine("Введите номер счета и баланс");
                long num = Checked_long();
                bank.Create_account(Checked_int(),num);
                Console.WriteLine("Проходит 1 год...");
                Console.WriteLine("Хотите ли вы закрыть счет в нашем банке?");
                string answer_2 = Console.ReadLine();               
                bank.Create_account(num,answer_2);               
                Console.WriteLine("Нужен ли еще один счет?");
                answer = Console.ReadLine();              
            }           
            Console.WriteLine("Task 3");
            Console.WriteLine("Каким материалом вы хотите обшить дом?(блоки|кирпичи|панель)");
            string material = Console.ReadLine().ToLower();
            Console.WriteLine("Сколько этажей будет в нем?");
            int floor = Checked_int(); 
            Console.WriteLine("Какова высота дома?");
            double height = Checked_double();
            Console.WriteLine("Сколько квартир будет в доме?");
            int floats = Checked_int();
            Building.Creator creator = new Building.Creator();
            switch (material) 
            {
                case "блоки":
                    Building.Block_House block_house = new Building.Block_House();
                    Building.Creator.CreateBuild(block_house, floor, height, floats);
                    
                    break;
                case "кирпичи":
                    
                    Building.Brick_House brick_house = new Building.Brick_House();
                    Building.Creator.CreateBuild(brick_house, floor, height, floats);
                    break;
                case "панель":
                    Building.Panel_House panel_house = new Building.Panel_House();
                    Building.Creator.CreateBuild(panel_house, floor, height, floats);
                    break;
            }
        }                
    }
}

