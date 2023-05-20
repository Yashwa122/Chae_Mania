using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTeleport : MonoBehaviour
{
    private GameObject player;
    public GameObject cam;
    public Transform spawnLocation;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            player.transform.position = spawnLocation.transform.position;
    }
}