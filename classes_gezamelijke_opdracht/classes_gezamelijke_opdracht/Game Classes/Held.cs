using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_gezamelijke_opdracht.Game_Classes
{
    class Held
    {
        //Constructor(s)
        public Held()
        {
            Health = 10; Mana = 0; Level = 1; Xp = 0; Naam = "Sperma Spuiter";
            isLevend = true;
        }

        //Private Variabelen

        private int Health;
        private int Mana;
        private int Level;
        private int Xp;
        private string Naam;
        private bool isLevend;

        //Get/SetMethoden

        //Get voor Level

        public int GetLevel()
        {
            return Level;
        }

        //Set/Get voor Xp

        public int GetXp() { return Xp; }

        //Get voor Naam

        public string GetNaam() { return Naam; }

        //Publieke Methoden

        public void AddXp(int value)
        {
            Xp += value;

            Level = Xp / 10;
            if (Level > 10 && isGodly == false)
            {
                Naam = "Godly " + Naam;
                isGodly = true;
            }

            //Private Methoden
        }

        private bool isGodly = false;
    }
}
