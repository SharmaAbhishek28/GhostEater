using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passage : MonoBehaviour
{

    public Transform connection;

    private void OnTriggerEnter2D(Collider2D other)    
    {
        Vector3 position = other.transform.position;
        position.y = this.connection.position.y;
        position.x = this.connection.position.x;
        other.transform.position = position;

    }
}
