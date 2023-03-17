using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLog : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger : " + other.gameObject.name);

        other.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision : " + collision.gameObject.name);
    }
}
