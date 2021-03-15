using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orcSpawner : MonoBehaviour
{
    public static Vector3 spawnArea = new Vector3(6, 9, 0);
    public static GameObject spawnPrefab;
    public GameObject ihateyouall;
    public static List<GameObject> orcsCurrentlySpawned = new List<GameObject>();
    public static List<orc> orcInstances = new List<orc>();
    void Start()
    {
        spawnPrefab = ihateyouall;
    }

    public static void spawnOrc(Vector3[] aLevelCoords)
    {
        orcsCurrentlySpawned.Add(Instantiate(spawnPrefab, spawnArea, Quaternion.identity));
        orcInstances.Add(orcsCurrentlySpawned[-1].GetComponent<orc>().Init(aLevelCoords));
    }


    // Update is called once per frame
    void Update()
    {

    }
}
