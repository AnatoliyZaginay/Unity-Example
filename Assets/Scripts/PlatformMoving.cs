using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    private Vector3 coordinates;

    public float moveSpeed;
    public Vector3 direction;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        coordinates = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(coordinates, transform.position) >= distance)
        {
            coordinates = transform.position;
            moveSpeed *= -1;
        }

        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

}
