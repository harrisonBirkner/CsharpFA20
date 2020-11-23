using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesClasses
{
    public class Game
    {
        //static/constant variables
        const string motto = "Yeet";
        const string company = "Acme Game Co.";

        //instance variables
        private int power;
        private string gamerTag;
        private string gameName;
        private double gameCost;
        public string Developer { get; set; }

        //constructors
        public Game() 
        {
            power = 1;
            gamerTag = "Some Gamer Tag";
            gameName = "Some Gamer Name";
            gameCost = 20;
        }
        
        
        public Game(int power, string gamerTag, string gameName, double gameCost)
        {
            Power = power;
            GamerTag = gamerTag;
            GameName = gameName;
            GameCost = gameCost;
        }
        /*
        public Game(string gamerTag, string gameName) : this(1, gamerTag, gameName, 20)
        {
            //power = 1;
            //GamerTag = gamerTag;
            //GameName = gameName;
            //gameCost = 20;
        }
        */
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value > 0)
                {
                    power = value;
                }
                else
                {
                    power = 1;
                }
                
            }
        }

        public string GamerTag { get => gamerTag; set => gamerTag = value; }

        public string GameName
        {
            get { return gameName; }
            set 
            {
                if (value.Trim().Length > 0)
                {
                    gameName = value.Trim();
                }
                else
                {
                    gameName = "Some Game Name";
                }
            }
        }

        public double GameCost
        {
            get
            {
                return gameCost;
            }
            set
            {
                if (value > 0)
                {
                    gameCost = value;
                }
                else
                {
                    gameCost = 20;
                }

            }
        }
    }
}
