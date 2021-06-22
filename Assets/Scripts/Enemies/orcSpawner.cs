using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orcSpawner : MonoBehaviour
{
    private static Vector3 spawnArea = new Vector3(6, 9);
    private static GameObject spawnPrefab;
    [SerializeField]private GameObject ihateyouall;
    public static List<GameObject> orcsCurrentlySpawned = new List<GameObject>();
    public static List<orc> orcInstances = new List<orc>();
    void Start()
    {
        spawnPrefab = ihateyouall;
    }

    public static void spawnOrc(List<Vector3> aLevelCoords)
    {
        orcsCurrentlySpawned.Add(Instantiate(spawnPrefab, spawnArea, Quaternion.identity));
        levelParent.enemiesCurrentlySpawned.Add(orcsCurrentlySpawned[orcsCurrentlySpawned.Count-1]);
        orcInstances.Add(orcsCurrentlySpawned[orcsCurrentlySpawned.Count-1].GetComponent<orc>().Init(aLevelCoords));
    }


    // Update is called once per frame
    void Update()
    {

    }
}
