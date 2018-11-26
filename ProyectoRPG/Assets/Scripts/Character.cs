using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character : GeneralStats
{
    [Header("Character")]
    public Sprite sprCharacter;
    public string nameChar;
    public int levelCurrent;
    public int expCurent;
    public int expNextLevel;
    public int equipWeapon;
    //public Armor equipArmor;
    //public Armor equipShield;
	// Use this for initialization
}
