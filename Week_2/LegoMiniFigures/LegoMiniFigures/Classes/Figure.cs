using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LegoMiniFigures.Classes
{
    enum FClass
    {
        Warrior,
        // INT:1 VIT:7 STR:7 SPD:5

        Wizard,
        // INT:9 VIT:4 STR:2 SPD:5

        Rogue,
        // INT:2 VIT:3 STR:6 SPD:9

        Paladin,
        // INT:5 VIT:6 STR:6 SPD:3

        Troll,
        Goblin,
        Orc,
        Demon,
    }
    class Figure
    {
        public string Name { get; set; }
        public FClass FigureFClass { get; set; }

        public bool IsAlive;

        private int _maxHp;
        private int _hp;
        private int _mp;
        private int _intellect;
        private int _vitality;
        private int _strength;
        private int _speed;
        private int _aDmg;
        private int _sDmg;
        private int _potCount;
        private int _xp;
        private int _reqXp;
        private int _lvl;
        private int _giveXp;
        private int _xpM;
        public Figure(string name)
        {
            Name = name;
        }

        public void SetClass(FClass figureFClass)
        {
            FigureFClass = figureFClass;
            IsAlive = true;

            switch (figureFClass)
            {
                case FClass.Warrior:
                    _intellect = 1;
                    _vitality = 7;
                    _strength = 7;
                    _speed = 5;
                    break;
                case FClass.Wizard:
                    _intellect = 9;
                    _vitality = 4;
                    _strength = 2;
                    _speed = 5;
                    break;
                case FClass.Rogue:
                    _intellect = 2;
                    _vitality = 3;
                    _strength = 6;
                    _speed = 9;
                    break;
                case FClass.Paladin:
                    _intellect = 5;
                    _vitality = 6;
                    _strength = 6;
                    _speed = 3;
                    break;
                case FClass.Troll:
                    _intellect = 2;
                    _vitality = 4;
                    _strength = 6;
                    _speed = 2;
                    _giveXp = 100;
                    break;
                case FClass.Goblin:
                    _intellect = 4;
                    _vitality = 3;
                    _strength = 2;
                    _speed = 6;
                    _giveXp = 150;
                    break;
                case FClass.Orc:
                    _intellect = 1;
                    _vitality = 5;
                    _strength = 7;
                    _speed = 4;
                    _giveXp = 175;
                    break;
                case FClass.Demon:
                    _intellect = 6;
                    _vitality = 6;
                    _strength = 6;
                    _speed = 6;
                    _giveXp = 666;
                    break;
                default:
                    Console.WriteLine("Didn't select a class");
                    break;
            }

            var hpMod = _vitality * 4;
            var mpMod = _intellect * 4;
            _hp = 100 + hpMod;
            _mp = 100 + mpMod;
            _maxHp = 100 + hpMod;
            _aDmg = _strength * 4;
            _sDmg = _intellect * 4;
            _potCount = 3;
            _lvl = 1;
            _xp = 0;
            _reqXp = 100;
            _xpM = 1;
        }

        public void GetInfo()
        {
            Console.WriteLine($"NAME: {Name}");
            Console.WriteLine($"CLASS: {FigureFClass}");
            Console.WriteLine($"HP: {_hp}");
            Console.WriteLine($"MP: {_mp}");
            Console.WriteLine($"INTELLECT: {_intellect}");
            Console.WriteLine($"VITALITY: {_vitality}");
            Console.WriteLine($"STRENGTH: {_strength}");
            Console.WriteLine($"SPEED: {_speed}");
            Console.WriteLine();
        }

        public void Fight(Figure enemy)
        {
            Console.WriteLine();
            if (_speed >= enemy._speed && _hp > 0 && enemy._hp > 0)
            {
                Console.WriteLine($"You attack first dealing {_aDmg} to {enemy.Name}!");
                Console.WriteLine($"{enemy.Name} attacks dealing {enemy._aDmg} to you!");
                enemy._hp -= _aDmg;
                _hp -= enemy._aDmg;
                if (_hp <= 0 || enemy._hp <= 0)
                {
                    Die(enemy);
                }
                else
                {
                    FightResult(enemy);
                }
            }
            else if (_speed < enemy._speed && _hp > 0 && enemy._hp > 0)
            {
                Console.WriteLine($"{enemy.Name} attacks first dealing {enemy._aDmg} to you!");
                Console.WriteLine($"You attack dealing {_aDmg} to {enemy.Name}!");
                _hp -= enemy._aDmg;
                enemy._aDmg -= _aDmg;
                if (_hp <= 0 || enemy._hp <= 0)
                {
                    Die(enemy);
                }
                else
                {
                    FightResult(enemy);
                }
            }
            Console.WriteLine();
        }

        public void FightResult(Figure enemy)
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"{Name}: HP: {_hp}/{_maxHp}");
            Console.WriteLine($"{enemy.Name} HP: {enemy._hp}/{enemy._maxHp}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. RUN!");
            Console.WriteLine("---------------------------");
            if (_potCount > 0)
            {
                Console.WriteLine($"3. Use HP Potion {_potCount}/3");
            }

            var resp = Convert.ToInt32(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Fight(enemy);
                    break;
                case 2:
                    Run(enemy);
                    break;
                case 3:
                    UsePot(enemy);
                    break;
                default:
                    Fight(enemy);
                    break;
            }
            Console.WriteLine();
        }

        public void UsePot(Figure enemy)
        {
            Console.WriteLine();
            if (_potCount > 0)
            {
                _potCount -= 1;
                _hp += 20;
                Console.WriteLine($"You used a HP Potion, and gained 20HP Your HP is now {_hp}");
                FightResult(enemy);
            }
            else
            {
                Console.WriteLine("You don't have any HP Potions Left!");
                Fight(enemy);
            }
            Console.WriteLine();
        }
        public void Run(Figure enemy)
        {
            if (_speed > enemy._speed)
            {
                Console.WriteLine("You got away safely");
            }
            else
            {
                Console.WriteLine("You got wrecked");
                _hp -= enemy._aDmg;
                Fight(enemy);
            }
        }

        public void Die(Figure enemy)
        {
            Console.WriteLine();
            if (_hp > enemy._hp)
            {
                Console.WriteLine($"You Killed {enemy.Name}");
                var giveXp = enemy._giveXp * _xpM;
                _xp += giveXp;
                Console.WriteLine($"You gained {giveXp} XP points.");
                Console.WriteLine($"XP: {_xp}/{_reqXp}");
                if (_reqXp <= _xp)
                {
                    LvlUp();
                }
            }
            else if (_hp <= 0)
            {
                Console.WriteLine($"{enemy.Name} Killed you!");
                IsAlive = false;
            }
            Console.WriteLine();
        }

        public void LvlUp()
        {
            _lvl += 1;
            var intXp = _intellect / 2 + _intellect;
            var strXp = _strength / 2 + _intellect;
            var vitXp = _vitality / 2 + _intellect;
            var spdXp = _speed / 2 + _intellect;
            _intellect += intXp;
            Console.WriteLine($"INT: {_intellect} (+{intXp})");
            _strength += strXp;
            Console.WriteLine($"STR: {_strength} (+{strXp})");
            _vitality += vitXp;
            Console.WriteLine($"VIT: {_vitality} (+{vitXp})");
            _speed += spdXp;
            Console.WriteLine($"SPD: {_speed} (+{spdXp})");
            var hpMod = _vitality * 4;
            _maxHp += hpMod;
            _reqXp += _reqXp * _lvl;
            _xp = 0;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("You leveled up!");
            Console.WriteLine($"Your now Level {_lvl}");
            Console.WriteLine($"HP: {_maxHp} (+{hpMod})");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!");
        }

        public void StartFight(Figure enemy)
        {
            Console.WriteLine($"{enemy.Name} appears!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. RUN!");
            var userResp = Convert.ToInt32(Console.ReadLine());
            switch (userResp)
            {
                case 1:
                    Fight(enemy);
                    break;
                case 2:
                    Run(enemy);
                    break;
                default:
                    Console.WriteLine("Please select 1 or 2");
                    break;
            }
        }

        public void EndFight()
        {
            switch (IsAlive)
            {
                case false:
                    break;
            }

            if (IsAlive)
            {
                Console.WriteLine(
                    $"Would you like to rest? Resting will Heal you to {_maxHp}/{_maxHp}HP (current {_hp}HP)");
                Console.WriteLine(
                    $"Skipping rest will increase your XP multiplier (current x{_xpM}), but you wont be healed!");
                Console.WriteLine("y=rest n=skip");
                var resp = Console.ReadLine().ToLower();
                switch (resp)
                {
                    case "y":
                        _hp = _maxHp;
                        _potCount = 3;
                        break;
                    case "n":
                        _xpM += 1;
                        _potCount = 3;
                        break;
                    default:
                        Console.WriteLine("Please enter y or n");
                        EndFight();
                        break;
                }
            }
        }

    }
}
