﻿using System;

namespace VirtualMonsterClasses
{
	public class VirtualMonster
	{
		// Instance Variables and Properties
		private string name;
		public string Name { get; private set; }
		private int health;
		public int Health { get; private set; }
		private int sleepiness;
		public int Sleepiness { get; private set; }
		private int hunger;
		public int Hunger { get; private set; }
		private int thirst;
		public int Thirst { get; private set; }
		private int bathroom;
		public int Bathroom { get; private set; }
		private int rage;
		public int Rage { get; private set; }
		private bool isAlive;
		public bool IsAlive { get; private set; }

		// Constructors
		public VirtualMonster()
		{
		}

		public VirtualMonster(string name)
        {
			this.Name = name;
			this.Health = 100;
			this.Sleepiness = 50;
			this.Hunger = 50;
			this.Thirst = 50;
			this.Bathroom = 25;
			this.Rage = 0;
			this.IsAlive = true;
		}

		public VirtualMonster(string name, int health, int sleepiness, int hunger, int thirst, int bathroom, int rage)
        {
			this.Name = name;
			this.Health = health;
			this.Sleepiness = sleepiness;
			this.Hunger = hunger;
			this.Thirst = thirst;
			this.Bathroom = bathroom;
			this.Rage = rage;
			this.IsAlive = true;
        }

		// Other methods
		public void Tick()
		{
			this.Sleepiness += 5;
			if (this.Sleepiness > 100) { this.Sleepiness = 100; }
			this.Hunger += 5;
			if (this.Hunger > 100) { this.Hunger = 100; }
			this.Thirst += 5;
			if (this.Thirst > 100) { this.Thirst = 100; }
			this.Bathroom++;
			if (this.Bathroom > 100) { this.Bathroom = 100; }

			// A little angry if somewhat discontent
			if (this.Sleepiness > 85 || this.Hunger > 85 || this.Thirst > 85 || this.Bathroom > 50)
			{
				this.Rage++;
			}

			// Very angry if maxed values
			if (this.Thirst == 100)
			{
				this.Rage += 5;
			}
			if (this.Hunger == 100)
            {
				this.Rage += 5;
            }

			if (this.Bathroom > 90)
			{
				this.Rage += 5;
			}

			// Animal self-determination - prioritize bathroom, thirst, hunger, sleepiness
			Random rndm = new Random();
			if (rndm.Next(0, 10) > 5)
			{
				if (this.Bathroom > 60 && rndm.Next(0, 10) > 8) { this.Potty(); }
				if (this.Thirst > 75 && rndm.Next(0, 10) > 8) { this.Drink(); }
				if (this.Hunger > 75 && rndm.Next(0, 10) > 8) { this.Eat(); }
				if (this.Sleepiness > 60 && rndm.Next(0, 10) > 8) { this.Sleep(); }
			}

			// Check for special behaviors based on attributes
			this.CheckSpecialBehaviors();
		}

		public void CheckSpecialBehaviors()
        {
			// What happens when an attribute hits an extreme?
			if (this.Hunger == 100) { Health -= 10; }
			if (this.Thirst == 100) { Health -= 10; }
			if (this.Sleepiness == 100) { Health -= 10; }
			if (this.Bathroom == 100) 
			{ 
				Health -= 10; 
			//	Bathroom = 0;	// And make a mess
			}

			if (this.Health <= 0) { Die(); }
        }
		/*
		Add vessel to eat / drink from:
		public void Eat(Vessel container) {}
		public void Drink(Vessel container) {}
		public void Potty(Vessel latrine) {}
		public void Fight(VirtualMonster opponent) {}

		*/
		public void Eat()
        {
			this.Hunger -= 40;
			this.Bathroom += 15;
        }

		public void Drink()
        {
			this.Thirst -= 40;
			this.Bathroom += 15;
        }

		public void Potty()
        {
			this.Bathroom = 0;
        }

		public void Sleep()
        {
			this.Sleepiness = 0;
        }

		public void Fight(VirtualMonster opponent)
        {
			this.Rage -= 50;
			opponent.Rage += 20;
        }

		public void Die()
        {
			this.IsAlive = false;
        }
	}
}