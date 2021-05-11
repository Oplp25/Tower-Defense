using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearmanShop : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    

    public void OnMouseDown()
    {
        shopParent.unitsCurrentlySpawned.Add(Instantiate(spawnPrefab, this.transform.position, Quaternion.identity));
        shopParent.unitsInit.Add(shopParent.unitsCurrentlySpawned[shopParent.unitsCurrentlySpawned.Count - 1].GetComponent<spearman>().Init());
    }
}
