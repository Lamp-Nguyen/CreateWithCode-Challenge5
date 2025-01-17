﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnTimer = 2.0f;
    private float spawnCooldown = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnCooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnCooldown = spawnTimer;
        }

        spawnCooldown -= Time.deltaTime;
    }
}
