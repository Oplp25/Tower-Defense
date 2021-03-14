using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orc : enemy
{

    public orc(int aHeathTotal, int aDamage, int aDrops, int aRange, string aPreferredTargets) :base(aHeathTotal, aDamage, aDrops, aRange, aPreferredTargets)
    {
        this.healthTotal = 25;
        this.damage = 5;
        this.range = 0;
        this.preferredTargets = "defenders";
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
