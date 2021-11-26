using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    namespace Building
    {
        abstract class House
        {
            private double height;

            public abstract void Sheathe();
            public double Getheight()
            {
                return height;
            }
            public void Setheight(double height_)
            {
                height = height_;
            }
            private int floor;
            public int Getfloors()
            {
                return floor;
            }
            public void Setfloor(int floor_)
            {
                floor = floor_;
            }
            private int floats;
            public int Getfloat()
            {
                return floats;
            }
            public void Setfloat(int floats_)
            {
                floats = floats_;
            }
            private int porch;  //подъезды
            public int Getporch()
            {
                return porch;
            }
            public void Setporch(int porch_)
            {
                porch = porch_;
            }
            public void Heightfloor(double height_, int floor_)
            {
                Console.WriteLine("Высота одного этажа " + height_ / floor_ + " метров");
            }
            public void Quantity_floats_on_porch(int floats_, int porch_)
            {
                Console.WriteLine("Кол-во квартир в одном подъзде " + floats / porch);
            }
            public void Quantity_floats_on_floor(int floats_, int porch_, int floor_)
            {
                Console.WriteLine("Кол-во квартир на этаже " + (floats_ / porch_ / floor_));

            }
            static int house_number1 = 1;
            public int Getnumber_house()
            {
                return house_number1 + 1;
            }
        }
    }
}

