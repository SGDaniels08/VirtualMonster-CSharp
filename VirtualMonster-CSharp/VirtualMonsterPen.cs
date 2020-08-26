using System;
using System.Collections.Generic;
using VirtualMonsterClasses;

public class VirtualMonsterPen
{
	// Instance Variables and Properties
	private string name;
	public string Name { get; private set; }
	private Dictionary<string, VirtualMonster> monsterPen;
	public Dictionary<string, VirtualMonster> MonsterPen { get; private set; }

	// Constructors
	public VirtualMonsterPen()
	{
	}

	public VirtualMonsterPen(Dictionary<string, VirtualMonster> monsterPen)
    {
		this.MonsterPen = monsterPen;
    }

	// Other methods

	/* one for each attribute: feed, play, refill, */
}
