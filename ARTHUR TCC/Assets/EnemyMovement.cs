using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public int speed;
    public Vector2 dir;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        dir = player.transform.position - transform.position;
        dir.Normalize();
        float angle =  Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        if(distance < 5 && distance > 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
