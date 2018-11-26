using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GeneralStats
{
    [Header("General Stats")]
    public double hpMax;
    public double hpCurrent;
    public double ppMax;
    public double ppCurrent;
    public int atkBase;
    public int defBase;
    public int atkMagic;
    public int defMagic;
    public enum Status { Normal, Poisoned }
    public Status status;
}
