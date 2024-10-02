using LastWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    enum Gender { Man = 1, Woman }

    enum Сountry
    {

        Russia = 1,
        USA,
        Ukraina,
        Canada,
        Germany,
        China,
        India,
        Kazahstan,
        Belarus,
        Moldova,
        France,
        Japan,
        Brazil,
        Usbecistan
    }

    class Passport
    {
        //* int Serial(проверка: 4 цифры)
        //* int Number(проверка: 6 цифр)
        //* string Issued(проверка: не пустая строка)
        //* DateTime IssuedDate(проверка: паспорт РФ. Намек: минимальная дата выдачи - дата образования РФ.Максимальная - сегодняшний день)
        //* bool IsActive(признак активности)
        //В OPD классе использовать конструктор(ы) и защищенные свойства с проверкой входных значений

        private int _seria;
        private int _number;
        private string _name;
        private string _sername;
        private DateTime _age;
        private Gender _gender;
        private Сountry _contry;

        public Passport() { }
        public Passport(int seria, int number, string name, string sername, DateTime age, Gender gender, Сountry сountry)
        {
            _seria = seria;
            _number = number;
            _name = name;
            _sername = sername;
            _age = age;
            _gender = gender;
            _contry = сountry;

        }
        public Passport(Passport passport) // данной перегрузкой мы воспользуемся при создании второго паспорта и можем скопиовать
        {                                  // из предыдущего но при изменении первого в будущем, на второй это не повлияет, так как
            _seria = passport._seria;      // благодоря данному консруктору мы подготовим свою область видимости и поля.
            _number = passport._number;
            _name = passport._name;
            _sername = passport._sername;
            _age = passport._age;
            _gender = passport._gender;
            _contry = passport._contry;

        }

           

        public static void GetAllInfo()
        {
            Passport passport = new Passport();

            passport._seria = 0;

            Helper.PrintResult("Введите серию: ");
            passport._seria = int.Parse(Console.ReadLine());
            Helper.PrintResult("Введите номер: ");
            passport._number = int.Parse(Console.ReadLine());
            
            GetName(ref passport);
            GetLastInfo(ref passport);

            passport.PrintPassport();
        }

        public void PrintPassport()
        {

            Console.WriteLine("Информация по паспорту:");
            Console.WriteLine("Серия:" + _seria);
            Console.WriteLine("Номер:" + _number);
            Console.WriteLine("Имя:" + _name);
            Console.WriteLine("Фамилия:" + _sername);
            Console.WriteLine("Пол:" + _gender);
            Console.WriteLine("Дата рождения:" + _age);
            Console.WriteLine("Страна:" + _contry);
        }

        public int Seria   // Так же можно за место private методов использовать Свойства и в них проверять поля на правильность заполнения после 
        {                  // передавать их в private переменные.
            get { return _seria; }

            set
            {
                if (value == 0) throw new IndexOutOfRangeException("Строка не заполнена!");

                if (value < 1000 || value > 9999) throw new ArgumentException("Введено неверное значение!");
            }
        }

        public int Number
        {
            get { return _number; }

            set
            {
                if (value == 0) throw new IndexOutOfRangeException("Cтрока не заполнена!");

                if(value < 100000 || value > 999999) throw new ArgumentException("Введено неверное значение!");
            }
        }




        private static void GetName(ref Passport passport)
        {

            bool IsEmpty = true;

            while (passport._name is null || passport._sername is null || IsEmpty is true)
            {
                Console.Clear();
                Console.Write("Введите Имя и Фамилию:\nИмя:");

                passport._name = Convert.ToString(Console.ReadLine());
                Console.Write("Фамилия:");
                passport._sername = Convert.ToString(Console.ReadLine());

                if (passport._name == "" || passport._sername == "") IsEmpty = true;
                else IsEmpty = false;

            }

        }

        private static void GetLastInfo(ref Passport passport)
        {

            bool IsEmpty = true;

            while (IsEmpty is true)
            {

                Console.Write("Дата рождения:");

                passport._age = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Пол:1 = Man или 2 = Woman");

                int a = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Gender), a))
                {
                    passport._gender = (Gender)a;
                    IsEmpty = false;
                }
                else IsEmpty = true;

                Console.Write("Cтрана:\nRussia = 1,\nUSA = 2,\nUkraina = 3,\nCanada = 4\nGermany =5,\nChina = 6,\n" +
                 "India = 7,\nKazahstan = 8,\nBelarus = 9,\nMoldova = 10,\nFrance = 11,\nJapan = 12,\nBrazil = 13,\nUsbecistan = 14\n");
                int b = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Сountry), b)) //Такой проверкой мы узнаем есть ли такое значение под данным номером.
                {
                    passport._contry = (Сountry)b;  //приведем int к Сountry
                    IsEmpty = false;
                }
                else IsEmpty = true;


            }
            Console.Clear();
        }





    }
}

