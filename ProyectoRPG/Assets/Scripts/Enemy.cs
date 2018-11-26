using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemy : GeneralStats
{
    [Header("Enemy")]
    public string nameEnemy;
    public int gold;
    public int expKill;
    public enum Behaviour { Melee, Ranged }
    public Behaviour behaviour;
}
