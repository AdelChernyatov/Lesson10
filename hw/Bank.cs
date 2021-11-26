using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    namespace Banking
    {
        class Bank
        {
            public Bank_Account Create_account(int balance, long number)
            {
                Bank_Account bank = new Bank_Account();
                Console.WriteLine("Вы открыли счет!" + "\nБаланс: " + bank.Balance(balance) + "\nНомер счета: " + number);
                return bank;
            }
            public Bank_Account Create_account(long number, string answer2)
            {
                Bank_Account bank_num = new Bank_Account();
                accounts[bank_num.Number(number)] = bank_num;  //Номер счета - индекс
                ICollection keys = accounts.Keys; //позволяет перебирать ключи
                if (answer2.Equals("да"))
                {
                    Console.WriteLine("Вы закрыли счет");
                    Delete_account(number);
                    foreach (long c in keys)
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine("Cпасибо,что остаетесь с нами");
                    foreach (long c in keys)
                    {
                        Console.WriteLine("Ваш номер счета: " + c);
                    }
                }
                return bank_num;
            }
            private Hashtable accounts = new Hashtable();
            public void Delete_account(long number)
            {
                accounts.Remove(number);
            }
        }

    }

}
