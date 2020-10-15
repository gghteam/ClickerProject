using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player
{
    public long money;
    public LunchKing[] lunchKings;
}

[Serializable]
public class LunchKing
{
    public int level;
    public int moneyPerSecond;
    public int upgradeCost;
}