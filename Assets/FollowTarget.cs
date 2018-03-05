using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public float speed;
    public GameObject target;

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
        if (target)
        {
            targetPos = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);

            if (player.transform.position.y - 0.1f > transform.position.y && transform.position.z >= 0f)
            {
                Vector3 temp = new Vector3(0, 0, -1f);
                transform.position += temp;
            }
            else if (player.transform.position.y - 0.1f < transform.position.y && transform.position.z <= 0f)
            {
                Vector3 temp = new Vector3(0, 0, 1f);
                transform.position += temp;
            }
        }
    }

    public void SetTarget(GameObject newTarget)
    {
        target = newTarget;
    }
}
