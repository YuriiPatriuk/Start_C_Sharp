using System;

namespace class_intro
{
    //class Number
    //{
    //    private int number;
    //    public Number(int num)
    //    {
    //        this.number = num;
    //    }
    //    public Number() : this(1)
    //    { }
    //    public void Inc()
    //    {
    //        ++number;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Number: {number}";
    //    }
    //}

    class ATM 
    {
        private string id;
        private string password;
        private double balance;
        public ATM(string id, string pass, double balance)
        {
            this.id = id;
            this.password = pass;
            this.balance = balance;
        }
        public string getPassword()
        {
            return password;
        }
        public string getID()
        {
            return id;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {balance}");
        }
        public void AddMoney(double addedMoney)
        {
            balance += addedMoney;
        }
        public void Withdraw(double withdrawMoney)
        {
            if (balance < withdrawMoney)
                balance = 0;
            else
                balance -= withdrawMoney;
        }
        public void menu()
        {
            Console.WriteLine("1. Show balance");
            Console.WriteLine("2. Add money");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Number num = new Number(12);
            //Console.WriteLine(num);
            int choose = 0;
            string pass, id;

            ATM atm = new ATM("1002", "6000", 3500);
            Console.Write("Enter id: ");
            id = Console.ReadLine();
            Console.Write("Enter password: ");
            pass = Console.ReadLine();
            if (pass == atm.getPassword() && id == atm.getID())
            {
                while (choose != 4)
                {
                    atm.menu();
                    choose = int.Parse(Console.ReadLine());
                    double money;
                    switch (choose)
                    {
                        case 1:
                            atm.ShowBalance();
                            break;
                        case 2:
                            Console.Write("Enter money: ");
                            money = double.Parse(Console.ReadLine());
                            atm.AddMoney(money);
                            break;
                        case 3:
                            Console.Write("Enter money: ");
                            money = double.Parse(Console.ReadLine());
                            atm.Withdraw(money);
                            break;
                        case 4:
                            Console.WriteLine("Goodbye!!");
                            break;
                        default:
                            Console.WriteLine("Error, choose correct position");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Error id or password!!");            }

        }
    }
}

// class ATM : login- password*+
// ctor (id, money)+
// ShowBalance()+
// AddMoney()+
// Withdraw()+
// Main() : menu