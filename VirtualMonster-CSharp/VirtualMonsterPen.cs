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

	public VirtualMonsterPen(params VirtualMonster[] monsters)
    {
		Dictionary<string, VirtualMonster> newPen = new Dictionary<string, VirtualMonster>();

		foreach (VirtualMonster m in monsters)
        {
			newPen.Add(m.Name, m);
        }

		this.MonsterPen = newPen;
    }

	public VirtualMonsterPen(Dictionary<string, VirtualMonster> monsterPen)
    {
		this.MonsterPen = monsterPen;
    }

	// Service methods
	public List<VirtualMonster> RetrieveAllMonsters()
    {
		List<VirtualMonster> monstersInPen = new List<VirtualMonster>();
		foreach(VirtualMonster monster in this.MonsterPen.Values) 
		{
			monstersInPen.Add(monster);
		}
		return monstersInPen;
    }
	/* one for each attribute: feed, play, refill, add pet, remove pet */
	// public List RetrieveAllMonsters()
	// public VirtualMonster RetrieveMonsterByName(string name)
	// public static void PenTick() { ...; iterate through Dictionary and .Tick() each }
}
