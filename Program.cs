// See https://aka.ms/new-console-template for more information

using module18;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        /*
        CarPlant plant = new CarPlant();
        // производство автоммобилей
        Conveyor builder = new CarConveyor();
        plant.Construct(builder);
        builder.Product.Show();

        // производство мотоциклов 
        Conveyor motoB = new MotoConveyor(); // реализация наследуемого класса 
        plant.Construct(motoB); // реализация метода для запуска процесса постройки 
        motoB.Product.Show(); // реализация метода получения информации о продукте
        
        ///////////
        //создание клиентского приложения
        ///////
        // создадим отправителя
        Pult pult = new Pult();
        // создадим получателя
        Gate gate = new Gate();
        //создание и инциализация команды
        pult.SetAction(new GateOpenAction(gate));
        pult.OpenButton();
        pult.CloseButton();
        */

        /*
        Задание
            Используя паттерн Команда и созданный выше шаблон, напишите консольную программу, которая будет:
            Принимать на вход ссылку на  Youtube-видео. 
            Выводить в консоль информацию: название видео и описание.
            Скачивать видео.
            У вас должно быть две команды: на получение информации о видео и на скачивание.



            */



        try
        {

            Console.WriteLine("Вставьте ссылку с Ютуб. Не забудьте включить ВПН!");
             string url = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Введите необходимую команду: 1 - скачать видео, 2 - получить информацию о видео, 0 - информация и скачивание одновременно");
            byte num = byte.Parse(Console.ReadLine()); 
            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

           

            switch (num)
            {
                case 1:
                    // создадим команду
                    var commandOne = new Download(receiver);
                    // инициализация команды
                    sender.SetCommand(commandOne);
                    sender.Run();
                    break; 
                    case 2:
                    var commandTwo = new Description(receiver);
                    sender.SetCommand(commandTwo);
                    sender.Run();
                    break; 
                    case 0:
                    // создадим команду
                    var _commandOne = new Download(receiver);
                    // инициализация команды
                    sender.SetCommand(_commandOne);
                    sender.Run();
                    var _commandTwo = new Description(receiver);
                    sender.SetCommand(_commandTwo);
                    sender.Run();
                    break;
                    default:

                    Console.WriteLine("Введен неверный номер"); 
                    break;
            }


            

           
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
        }


    }
}