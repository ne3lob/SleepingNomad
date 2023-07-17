using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float heightUp = 0.05f;
    public float heightFoward = 0.08f;
    public float heightRight = 0.08f;


    void Update()
    {
        var pos = transform.position;
        var newY = heightUp * Mathf.Sin(Time.time * speed);
        var newZ = heightFoward * Mathf.Sin(Time.time * speed);
        var newX = heightRight * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(transform.position.x + newX, transform.position.y + newY,
            transform.position.z + newZ);
        transform.RotateAround(gameObject.transform.position, Vector3.up, Random.Range(2, 13) * Time.deltaTime);
    }
}