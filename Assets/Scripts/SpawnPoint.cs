using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnPoint : MonoBehaviour
{

    public GameObject EvilGull;

    private void Start()
    {
        Instantiate(EvilGull, transform.position, Quaternion.identity);
    }
}
