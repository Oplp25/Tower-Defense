using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1W1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       for (int i=0;i<4;i++)
            {
                orcSpawner.spawnOrc();
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
