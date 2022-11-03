using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHits : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        Debug.Log("Bumped into a wall");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
