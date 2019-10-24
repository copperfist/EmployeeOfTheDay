﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawn : MonoBehaviour
{
    public GameObject npcPrefab;
    public Transform spawnpoints;

    public float spawnTimer = 5.0f;


    private void Update()
    {
          spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0)
        {
            Instantiate(npcPrefab, spawnpoints.position, spawnpoints.rotation);
            spawnTimer = 10.0f;
        }
    }


}
