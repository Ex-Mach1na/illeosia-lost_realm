﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLoadAnimations : MonoBehaviour
{
    Vector3 targetPos;
    float speed = 3f;

    float waitTimer;
    float timer;

    void Start()
    {
        waitTimer = Random.Range(0f, 3f);
        targetPos = transform.position;
        transform.position = new Vector3(transform.position.x, -VoxelData.ChunkHeight, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < waitTimer)
        {
            timer += Time.deltaTime;
        }
        else
        {

            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * speed);
            if ((targetPos.y - transform.position.y) < 0.05f)
            {
                transform.position = targetPos;
                Destroy(this);
            }

        }
    }
}
