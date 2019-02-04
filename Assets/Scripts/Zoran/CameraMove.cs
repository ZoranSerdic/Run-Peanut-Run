using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float camMoveSpeed = 2f;

	void Update ()
    {

        transform.Translate(Vector3.right * camMoveSpeed * Time.deltaTime);
	}
}
