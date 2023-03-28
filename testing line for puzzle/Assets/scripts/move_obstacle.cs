using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_obstacle : MonoBehaviour
{

    public Transform startPoint;
    public Transform endPoint;
    public float speed = 1.0f;

    private Vector2 currentTarget;

    private void Start()
    {
        currentTarget = endPoint.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        if (transform.position == (Vector3)currentTarget)
        {
            currentTarget = (currentTarget == (Vector2)startPoint.position) ? (Vector2)endPoint.position : (Vector2)startPoint.position;
        }
    }
}
