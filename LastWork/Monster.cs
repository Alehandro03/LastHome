using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    enum MonsterType
    {
        Dracon = 1, 
        Orc, 
        Undead, 
        Demon, 
        Mutant, 
        Animal,
        Elf,
        People
    }
    class Monster
    {

        //Методы:
        //int GetAttack(int bonus); (получить точное значение силы атаки в диапазоне[MinAttack; MaxAttack] + bonus)
        //* void Wounds(int damage); (вычитает damage из его HP; при этом HP не может уйти в минус!!!)
        //* void Heal(); (полностью исцеляет монстра).

        private MonsterType _monster;

        private int Hp = 100; //(текущее здоровье. Проверка: 0 - 100, но не более MaxHP)

        public int MaxHp; //(полное здоровье. Проверка: 0 - 500)

        public int MinHp; // (поверка здоровья, если меньше 0 )

        public int MinAttack = 1; //(минимальная сила атаки.Проверка:  1-10)

        public int MaxAttack;  //(максимальная атаки. Проверка:  20-100)

        private double Cash = 10500;

        public string WarCry;//боевой клич

        public string DeadCry; // крик смерти

        public string Name; // Ник нейм персонажа

        public Monster() { }

        public Monster(string name, MonsterType monster)
            :this()
        { 
            Name = name;
            _monster = monster;
        }

        public Monster(string name, MonsterType monster, double cash, int hp, int max_hp, int min_attack,int max_attack, string war_cry, string die_cry)
            : this(name, monster)
        {
            Cash = cash;
            Hp = hp;
            MaxHp = max_hp;
            MinAttack = min_attack;
            MaxAttack = max_attack;
            WarCry = war_cry;
            DeadCry = die_cry;

        }

        

        public string MonsterText
        {
            get
            {
                return (_monster == MonsterType.Dracon ? "Дракон" : (_monster == MonsterType.Orc ? "Орк"
                    : (_monster == MonsterType.Demon ? "Демон" : (_monster == MonsterType.Mutant ? "Мутант"
                   : (_monster == MonsterType.Animal ? "Животное" : (_monster == MonsterType.Undead ? "Нежить"
                   : (_monster == MonsterType.Elf ? "Эльф" : "Человек")))))));
            }

        }


        public bool IsDie     //(монстр не мертв, если его HP > 0)
        {
            get { return true; }                                             
        }

        public string GetInfo   //* (развернутая строка с описанием монстра(все основные поля, кроме строк его криков, в понятном пользователю текстовом виде)).
        {
            get
            {
                return ($"Имя персонажа:{Name},\nРасса:{_monster},\nКооличество здоровья:{Hp},\nДеньги:{Cash}.");
            }
        }

        public int GetAttack(int MinAttack, int MaxAttack,int bonus) //(получить точное значение силы атаки в диапазоне[MinAttack; MaxAttack] + bonus)
        {
            int attack = 0;

            Random rnd = new Random();

            int shec = rnd.Next(1, 10);

            if (shec > (MaxAttack - MinAttack) / 2)
            {
                attack = MaxAttack;
            }
            else if (shec < (MaxAttack - MinAttack) / 2)
            {
                attack = MinAttack;
            }
            else attack = (MaxAttack - MinAttack) / 2;

            return attack + bonus;
        }
    }
}
