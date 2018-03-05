using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public int scale;
    public float moveSpeed;

    private Vector3 targetPos;
    private Camera mycam;

    // Use this for initialization
    void Start()
    {
        mycam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mycam.orthographicSize = (Screen.height / 100f) / scale;

        if (target)
        {
            targetPos = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }
    }
}
