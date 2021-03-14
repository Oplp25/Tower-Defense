using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orcSpawner : MonoBehaviour
{
    public static Vector3 spawnArea = new Vector3(6, 9, 0);
    public static GameObject spawnPrefab;
    public GameObject ihateyouall;
    public static List<GameObject> orcsCurrentlySpawned = new List<GameObject>();
    void Start()
    {
        spawnPrefab = ihateyouall;
    }

    public static void spawnOrc()
    {
        orcsCurrentlySpawned.Add(Instantiate(spawnPrefab, spawnArea, Quaternion.identity));
    }


    // Update is called once per frame
    void Update()
    {

    }
}
