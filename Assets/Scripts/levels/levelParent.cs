using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelParent : MonoBehaviour
{
    public float levelStarted;
    public List<Vector3> coordsToMove;
    public static List<GameObject> enemiesCurrentlySpawned = new List<GameObject>();
    public float spawnDelay;
    public bool finishedSpawning = false;
}
