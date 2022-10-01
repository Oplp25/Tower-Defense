using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orc : enemy
{

    public orc Init(List<Vector3> aLevelCoords)
    {
        this.healthTotal = 25;
        this.damage = 5;
        this.drops = 1;
        this.range = 0;
        this.speed = 1;
        this.healthCurrent = this.healthTotal;
        this.moveSpeed = 0.003f * this.speed;
        this.preferredTargets = "defenders";
        this.levelCoords = aLevelCoords;
        this.coordHeadingTo = this.levelCoords[0];
        return this;
    }

}
