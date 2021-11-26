using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    namespace Building 
    {
        class Creator
        {
            private static Hashtable accounts2 = new Hashtable();
            public static void CreateBuild(Block_House block_house, int floor, double height, int floats)
            {
                block_house.Setheight(height);
                block_house.Sheathe();
                block_house.Setheight(height);
                Console.WriteLine("Высота дома: " + block_house.Getheight());
                block_house.Setfloor(floor);
                Console.WriteLine("Кол-во этажей: " + block_house.Getfloors());
                block_house.Setfloat(floats);
                Console.WriteLine("Кол-во квартир: " + block_house.Getfloat());
                accounts2[1] = block_house;
                ICollection keys = accounts2.Keys;
                foreach (int c in keys)
                {
                    Console.WriteLine("Уникальный номер " + c);
                }
            }
            public static void CreateBuild(Brick_House brick_house, int floor, double height, int floats)
            {
                brick_house.Sheathe();
                brick_house.Setheight(height);
                Console.WriteLine("Высота дома:+ " + brick_house.Getheight());
                brick_house.Setfloor(floor);
                Console.WriteLine("Кол-во этажей: " + brick_house.Getfloors());
                brick_house.Setfloat(floats);
                Console.WriteLine("Кол-во квартир: " + brick_house.Getfloat());
                accounts2[2] = brick_house;
                Delete_account(2);
            }
            public static void CreateBuild(Panel_House panel_house, int floor, double height, int floats)
            {
                panel_house.Sheathe();
                panel_house.Setheight(height);
                Console.WriteLine("Высота дома: " + panel_house.Getheight());
                panel_house.Setfloor(floor);
                Console.WriteLine("Кол-во этажей: " + panel_house.Getfloors());
                panel_house.Setfloat(floats);
                Console.WriteLine("Кол-во квартир: " + panel_house.Getfloat());
                accounts2[3] = panel_house;
                Delete_account(3);
            }
            static void Delete_account(int number)
            {
                accounts2.Remove(number);
            }


        }
    }
      
}
