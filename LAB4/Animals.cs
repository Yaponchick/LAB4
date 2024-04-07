using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Animal { }
    // Коровы
    public class Cows : Animal
    {
        public int lengthHorns = 0; // Длина рогов
        public int milkDday = 0; // Сколько даёт молока в сутки
    }

    // Виды порог собак
    public enum DogsType { Husky, Doberman, Bulldog }

    //Собаки
    public class Dogs : Animal
    {
        public DogsType type = DogsType.Husky;
        public int ignoringHost = 0; // Расстояние с которого собака игнорирует хозяина
        public int tailLength = 0; // Длина хвоста
    }
    
    // Коты
    public class Cats : Animal
    {
        public bool wool =  false; // Наличие шерсти
        public int mouseDay = 0; // Улов мышей в день
    }
}