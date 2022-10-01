using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class L1W1 : levelParent
{
    public L1W1()
    {
        coordsToMove = new List<Vector3>{ new Vector3(8, 9), new Vector3(8, 3), new Vector3(14, 3), new Vector3(14, 1)};
        this.levelStarted = Time.time;
        this.spawnDelay = 1.0f;
    }

    public void update()
    {
        if (Time.time - this.levelStarted >= this.spawnDelay & !(this.finishedSpawning))
        {
            orcSpawner.spawnOrc(coordsToMove);
            this.spawnDelay += 1.0f;
            if (this.spawnDelay == 5f)
            {
                this.finishedSpawning = true;
            }
        }
    }
}
