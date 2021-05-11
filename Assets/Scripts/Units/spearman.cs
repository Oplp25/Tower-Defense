using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearman : unit
{
    public spearman Init()
    {
        this.healthTotal = 100;
        this.healthCurrent = this.healthTotal;
        this.cost = 10;
        this.damage = 5;
        this.range = 1;
        firstPositioning();
        return this;
    }
    public void firstPositioning()
    {
        this.positioning = true;
    }

    public void Update()
    {
       positioningMethod();
    }

}
