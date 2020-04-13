using System;

namespace HomeWork11._04
{
    class Client 
    {
        public string Name;
        public string LastName;
        public int Age;
        public decimal Cash;
        public Client(string Name, string LastName, int Age, decimal Cash)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
            this.Cash = Cash;
        }
        public Client(){}
        public void Show()
        {
            System.Console.WriteLine($"Имя клиента: {Name}\nФамилия: {LastName}\nВозраст: {Age}\nСумма денег: {Cash}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client[] clients = new Client[10];
            for (int i = 0; i < clients.Length;i++)
            {
                System.Console.WriteLine($"Введите имя {i+1}-го клиента \nфамилию \nвозраст \nденьги");
                clients[i] = new Client(Console.ReadLine(),Console.ReadLine(),int.Parse(Console.ReadLine()),decimal.Parse(Console.ReadLine()));
            }
            foreach(var el in clients)
            {
                el.Show();
            }
            Console.ReadKey();
        }
    }
}
