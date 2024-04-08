/* Тема:
Для раздачи домашних животных (вес)
Коровы (длина рогов, сколько молока дает в сутки)
Собаки (порода, расстояние начиная с которого начинает игнорировать команды хозяина, длина хвоста)
Кошки (наличие шерсти, улов мышей в день)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    // Родительский класс для наследования
    public class Animal 
    {
        public static Random rnd = new Random();
        public int weight = 0;
        // Функция для преопределения в классах наследниках
        public virtual string GetInfo()
        {
            var str = String.Format("\nВес {0} кг", this.weight);
            return str;
        }
    }

    // Класс для вывода коров
    public class Cows : Animal
    {
        public int lengthHorns = 0; // Длина рогов
        public int milkDay = 0; // Сколько даёт молока в сутки

        // Метод наследования GetInfo
        public override string GetInfo()
        {
            var str = "Я коровка 🐮";
            str += base.GetInfo(); // base Ключевое слово используется для доступа к членам базового класса из производного класса.
            str += String.Format("\nДлина рогов {0} см", this.lengthHorns);
            str += String.Format("\nМолока в сутки {0} л", this.milkDay);
            return str;
        }
        // Cтатический метод генерации случайных значений для Cows
        public static Cows Generate()
        {
            return new Cows
            {
                weight = rnd.Next(25, 600),
                lengthHorns = rnd.Next(0, 71),
                milkDay = rnd.Next(0, 82)
            };
        }
    }

    // Виды пород собак
    public enum DogsType { Husky, Doberman, Bulldog }

    // Класс для вывода собак
    public class Dogs : Animal
    {
        public DogsType type = DogsType.Husky;
        public int ignoringHost = 0; // Расстояние с которого собака игнорирует хозяина
        public int tailLength = 0; // Длина хвоста

        // Метод наследования GetInfo
        public override string GetInfo()
        {
            var str = "Я собачка 🐕";
            str += base.GetInfo();
            str += String.Format("\nИгнор хозяина от {0} м", this.ignoringHost);
            str += String.Format("\nДлина хвоста {0} см", this.tailLength);
            str += String.Format("\nПорода {0}", this.type);
            return str;
        }
        
        // Cтатический метод генерации случайных значений для Dogs
        public static Dogs Generate()
        {
            return new Dogs
            {
                weight = rnd.Next(1, 70),
                type = (DogsType)rnd.Next(3),
                ignoringHost = rnd.Next(100, 1000),
                tailLength = rnd.Next(1, 30)
            };
        }
    }

    // Класс для вывода котов
    public class Cats : Animal
    {

        public bool wool =  false; // Наличие шерсти
        public int mouseDay = 0; // Улов мышей в день

        // Метод наследования GetInfo
        public override string GetInfo()
        {
            var str = "Я кошечка =^◕⩊◕^=";
            str += base.GetInfo();
            if (this.wool == false)
            {
                str += String.Format("\nНаличие шерсти: НЕТ");
            }
            else
            {
                str += String.Format("\nНаличие шерсти: ДА");
            }
            str += String.Format("\nМышей в день {0} шт", this.mouseDay);
            return str;
        }

        // Cтатический метод генерации случайных значений для Cats
        public static Cats Generate()
        {
            return new Cats
            {
                weight = rnd.Next(2, 6),
                wool = rnd.Next() % 2 == 0,
                mouseDay = rnd.Next(0, 30)
            };
        }
    }
}