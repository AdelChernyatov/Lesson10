using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static void Randomize(ref List<string>list,out string winner1,out string winner2,out string winner3) 
        {
            Random rnd = new Random();          
            int num_winner1 = rnd.Next(list.Count);
            winner1 = list[num_winner1];
            list.RemoveAt(num_winner1);
            int num_winner2 = rnd.Next(list.Count);
            winner2 = list[num_winner2];
            list.RemoveAt(num_winner2);
            int num_winner3 = rnd.Next(list.Count);
            winner3 = list[num_winner3];
            list.RemoveAt(num_winner3);
            
            
        }
        static void Change(string [] array,ref List<string> list) 
        {            
            for (int i = 0; i < array.Length; i++) 
            {
                list.Add(array[i]);
            }   
        }
        static void Deleting_and_Changing(ref List<string>list,ref string winner1,ref string winner2,ref string winner3) 
        {
            list.Remove(winner1);
            list.Remove(winner2);
            list.Remove(winner3);
            Random rnd = new Random();
            int num_winner1 = rnd.Next(list.Count);
            string winner2_1 = list[num_winner1];
            list.Remove(winner2_1);
            Sorting(list,winner2_1);
            int num_winner2 = rnd.Next(list.Count);
            string winner2_2 = list[num_winner2];
            Sorting(list, winner2_2);
            int num_winner3 = rnd.Next(list.Count);
            string winner2_3 = list[num_winner3];
            Sorting(list, winner2_2);
            int num_winner4 = rnd.Next(list.Count);
            string winner2_4 = list[num_winner4];
            Sorting(list, winner2_2);
            int num_winner5 = rnd.Next(list.Count);
            string winner2_5 = list[num_winner5];
            string congaratulations = "Билеты на балет на 25.11.2021 достаются: ";
            string[] winners2 = { congaratulations,winner2_1, winner2_2, winner2_3, winner2_4, winner2_5 };
            File.WriteAllLines("Победители2", winners2);
           
        }
        static void Sorting(List <string> list,string winner) 
        {
            foreach (string nam in list)
            {
                if (nam.Equals(winner))
                {
                    list.Remove(winner);
                }
            }
        }
        static void Main(string[] args)
        {
            string [] Theatre = File.ReadAllLines("Theatre.txt");
            string [] Balet = File.ReadAllLines("Balet.txt");
            string[] Football = File.ReadAllLines("Football.txt");
            List<string> Theatre1 =new List<string>();
            List<string> Balet1 = new List<string>();
            List<string> Football1 = new List<string>();
            Change(Theatre, ref Theatre1);
            Change(Balet, ref Balet1);
            Change(Football,ref Football1);
            string winner1, winner2, winner3;
            Randomize(ref Theatre1,out winner1,out winner2,out winner3 );
            string congratulations = "Билеты в театр на 20.11.2021 достаются:";
            string[] winners = { congratulations,winner1, winner2, winner3 };
            File.WriteAllLines("Победители.txt", winners);
            string win = File.ReadAllText("Победители.txt");
            Console.WriteLine(win);
            Deleting_and_Changing(ref Balet1, ref winner1, ref winner2, ref winner3);



            

        }
    }
}
