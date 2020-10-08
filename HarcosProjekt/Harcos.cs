using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        string nev;
        int level;
        int xp;
        int hp;
        int baseHp;
        int baseAttack;

        public Harcos(string nev, int statuszSablon)
        {
            this.nev = nev;
            level = 1;
            xp = 0;
            switch (statuszSablon)
            {
                case 1: this.baseHp = 15; this.baseAttack = 3; break;
                case 2: this.baseHp = 12; this.baseAttack = 4; break;
                case 3: this.baseHp = 8; this.baseAttack = 5; break;
                default: this.baseHp = 12; this.baseAttack = 4; break;
            }
            this.hp = baseHp;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Level { get => level; set => level = value; }
        public int Xp { get => xp; set => xp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int BaseHp { get => baseHp; }
        public int BaseAttack { get => baseAttack; }
        public int Attack { get => baseAttack+level; }
        public int TillNextLevel { get => 10 + level * 5; }
        public int MaxHp { get => baseHp + level * 3; }

        public override string ToString()
        {
            return string.Format($"{nev}:\nLVL: {level}\nEXP: {xp}/{TillNextLevel}\nHP: {hp}/{MaxHp}\nDMG: {Attack}");
        }
        public void Megkuzd(Harcos masikHarcos, Harcos harcos)
        {
            if (masikHarcos==harcos)
            {
                Console.WriteLine("Ez nem az a játék.");
            }
            else if (masikHarcos.hp==0||harcos.hp==0)
            {
                Console.WriteLine("Ő már meghalt.");
            }
            masikHarcos.hp -= harcos.Attack;
            if (masikHarcos.hp>0)
            {
                harcos.hp -= masikHarcos.Attack;
            }
            if (harcos.hp > 0) 
            {
                harcos.xp += 5;
            }
            if (masikHarcos.hp > 0) 
            {
                masikHarcos.xp += 5;
            }
            if (harcos.hp==0)
            {
                masikHarcos.xp += 10;
            }
            if (masikHarcos.hp==0)
            {
                harcos.xp += 10;
            }
        }

        public void Heal(Harcos harcos)
        {
            if (harcos.Hp<=0)
            {
                harcos.Hp = harcos.MaxHp;
            }
            else
            {
                harcos.Hp += 3;
            }
        }


    }
}
