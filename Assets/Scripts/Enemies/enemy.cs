using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    public int healthTotal;
    public int healthCurrent;
    public int damage;
    public int range;
    public string[] targetList = { "castle", "defenders", "any", "rangedTwo", "rangedOne", "melee" };
    private string PreferredTargets;
    public enemy(int aHeathTotal, int aDamage, int aRange, string aPreferredTargets)
    {
        healthTotal = aHeathTotal;
        healthCurrent = healthTotal;
        damage = aDamage;
        range = aRange;
        PreferredTargets = aPreferredTargets;
    }

    public string preferredTargets
    {
        get { return PreferredTargets; }
        set { 
            
            if (targetList.Contains(PreferredTargets))
                {
                    PreferredTargets = value;  
                }
            else
                {
                    PreferredTargets = "any";
                }

            }
    }
    public void attack() { }
    public void takeDamage() { }
    public void reachedCastle() { }
    public void death() { }
}
