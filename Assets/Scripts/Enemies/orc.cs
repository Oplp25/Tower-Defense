using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orc : enemy
{

    public orc()
    {
        this.healthTotal = 25;
        this.damage = 5;
        this.drops = 1;
        this.range = 0;
        this.speed = 1;
        this.preferredTargets = "defenders";
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
