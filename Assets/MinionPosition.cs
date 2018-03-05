using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionPosition : MonoBehaviour
{
    public float speed;
    public bool farAway;
    public float setDistance;
    public bool following = true;

    private float distance;
    private GameObject player;

    private Vector3 targetPos;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (following)
        {
            distance = Vector3.Distance(player.transform.position, transform.position);

            if (!farAway && distance > setDistance)
                farAway = true;

            if (farAway && distance < setDistance)
                farAway = false;

            if (farAway)
            {
                targetPos = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);
            }
        }
    }


}