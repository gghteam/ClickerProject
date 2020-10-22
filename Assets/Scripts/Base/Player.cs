using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player
{
    public long moneyPerClick = 10;
    public long moneyLevel = 1;
    public long money = 0;
    public LunchKing[] lunchKings;
}

[Serializable]
public class LunchKing
{
    public long level = 1;
    public long moneyPerSecond = 100;
    public long upgradeCost = 1540;
}