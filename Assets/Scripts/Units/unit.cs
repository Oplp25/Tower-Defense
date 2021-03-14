using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class unit : MonoBehaviour
{
    public int healthTotal;
    public int healthCurrent;
    public int damage;
    public int range;
    public int cost;

    public unit(int aHeathTotal, int aDamage, int aRange, int aCost)
    {
        healthTotal = aHeathTotal;
        healthCurrent = healthTotal;
        damage = aDamage;
        range = aRange;
        cost = aCost;
    }
    public void attack() { }
    public void takeDamage() { }
    public void death() { }
}
