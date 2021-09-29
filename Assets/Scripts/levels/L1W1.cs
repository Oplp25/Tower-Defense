using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1W1 : levelParent
{
    public L1W1()
    {
        coordsToMove = new List<Vector3>{ new Vector3(8, 9), new Vector3(8, 3), new Vector3(14, 3), new Vector3(14, 1)};

    }

    public void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            orcSpawner.spawnOrc(coordsToMove);
        }
    }
}
