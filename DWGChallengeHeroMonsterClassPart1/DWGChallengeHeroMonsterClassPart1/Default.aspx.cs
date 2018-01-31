using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DWGChallengeHeroMonsterClassPart1
{
    
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create 2 instances of character hero / monster.
            Character hero = new Character();
            hero.Name = "Zeus";
            hero.Health = 30;
            hero.DamageMaximum = 10;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Godzilla";
            monster.Health = 30;
            monster.DamageMaximum = 10;
            monster.AttackBonus = true;


            //perform battle.
            Dice dice = new Dice();

            //Bonus attack
            if (hero.AttackBonus)
                monster.Defend(hero.Attack(dice));
            if (monster.AttackBonus)
                hero.Defend(monster.Attack(dice));
           
            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(dice));
                hero.Defend(monster.Attack(dice));

                displayStats(hero);
                displayStats(monster);
            }

            displayResult(hero, monster);

        }


        private void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p>Both {0} and {1} died.<p />", opponent1.Name, opponent2.Name);
            else if (opponent1.Health <= 0)
                resultLabel.Text += String.Format("<p>{0} defeats {1}.<p />", opponent2.Name, opponent1.Name);
            else
                resultLabel.Text += String.Format("<p>{0} defeats {1}.<p />", opponent1.Name, opponent2.Name);
        }

        private void displayStats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - DamageMaximum {2} - AttackBonus {3}<p />", 
                character.Name, 
                character.Health, 
                character.DamageMaximum, 
                character.AttackBonus);
        }


        //helper method to display stats of each character in label server control.
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        

        public int Attack(Dice dice)
        {
            //return an int
            //randomly determine the amount of damage this character object inflicted.
            //Random random = new Random();
            //int attackDamage = random.Next(this.DamageMaximum);
            dice.Sides = this.DamageMaximum;
            return dice.Roll();
            

        }

        public void Defend(int attackDamage)
        {
            //deducts the damage from this character's health.
            //current health - damage =

            this.Health -= attackDamage;
        }
    }

    class Dice
    {
        //one property : int sides
        // one method : Roll(), uses sides property as max value.
        public int Sides { get; set; }

        Random random = new Random();
        public int Roll()
        {
            return random.Next(this.Sides);
        }
    }

}