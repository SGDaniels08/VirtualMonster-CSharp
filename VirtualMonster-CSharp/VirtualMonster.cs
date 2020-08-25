using System;

namespace VirtualMonsterClasses
{
	public class VirtualMonster
	{
		// Instance Variables and Properties
		private string name;
		public string Name { get; private set; }
		private int hunger;
		public int Hunger { get; private set; }
		private int thirst;
		public int Thirst { get; private set; }
		private int bathroom;
		public int Bathroom { get; private set; }
		private int rage;
		public int Rage { get; private set; }

		// Constructors
		public VirtualMonster()
		{
		}

		public VirtualMonster(string name)
        {
			this.Name = name;
			this.Hunger = 50;
			this.Thirst = 50;
			this.Bathroom = 50;
			this.Rage = 0;
		}

		public VirtualMonster(string name, int hunger, int thirst, int bathroom, int rage)
        {
			this.Name = name;
			this.Hunger = hunger;
			this.Thirst = thirst;
			this.Bathroom = bathroom;
			this.Rage = rage;
        }

		// Other methods
	}
}