using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public Character[] characters;
    public Enemy[] enemies;
    public static Data act;
    private void Awake()
    {
        act = this;
    }
}
