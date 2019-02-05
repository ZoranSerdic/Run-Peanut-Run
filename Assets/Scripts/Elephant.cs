using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephant : MonoBehaviour
{
    private void Awake()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().camEndMoveSpeed += 1;
        GameObject.Find("Main Camera").GetComponent<CameraMove>().camMidMoveSpeed += 1;
        GameObject.Find("Main Camera").GetComponent<CameraMove>().camStartMoveSpeed += 1;
    }

    void Update ()
    {
        if (Input.GetKey(KeyCode.F))
        {
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
        else if (GameObject.Find("Main Camera").GetComponent<CameraMove>().timeUpStart == true && GameObject.Find("Main Camera").GetComponent<CameraMove>().timeUpMid == true)
        {
            transform.Translate(Vector3.right * (GameObject.Find("Main Camera").GetComponent<CameraMove>().camEndMoveSpeed * Time.deltaTime));
        }
        else if (GameObject.Find("Main Camera").GetComponent<CameraMove>().timeUpStart == true)
        {
            transform.Translate(Vector3.right * (GameObject.Find("Main Camera").GetComponent<CameraMove>().camMidMoveSpeed * Time.deltaTime));
        }
        else if (GameObject.Find("Main Camera").GetComponent<CameraMove>().timeUpStart == false)
        {
            transform.Translate(Vector3.right * (GameObject.Find("Main Camera").GetComponent<CameraMove>().camStartMoveSpeed * Time.deltaTime));
        }

        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * 0.2f;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Destroyable")
        {
            Destroy(collision.gameObject);
        }
    }
}
