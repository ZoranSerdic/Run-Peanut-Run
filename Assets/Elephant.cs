using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephant : MonoBehaviour
{
	void Update ()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * 1f;
        transform.Translate(Vector3.right * 3f * Time.deltaTime);
	}
}
