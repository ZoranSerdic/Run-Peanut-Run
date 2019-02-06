using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephant : MonoBehaviour
{
    void Update ()
    {
        if (Input.GetKey(KeyCode.F))
        {
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
        else if (GameObject.Find("Main Camera").GetComponent<CameraMove>().timeUpStart == true && GameObject.Find("Main Camera").GetComponent<CameraMove>().timeUpMid == true)
        {
            transform.Translate(Vector3.right * (GameObject.Find("Main Camera").GetComponent<CameraMove>().camEndMoveSpeed * Time.deltaTime));
            transform.Translate(Vector3.right * 0.2f * Time.deltaTime);
        }
        else if (GameObject.Find("Main Camera").GetComponent<CameraMove>().timeUpStart == true)
        {
            transform.Translate(Vector3.right * (GameObject.Find("Main Camera").GetComponent<CameraMove>().camMidMoveSpeed * Time.deltaTime));
        }
        else if (GameObject.Find("Main Camera").GetComponent<CameraMove>().timeUpStart == false)
        {
            transform.Translate(Vector3.right * (GameObject.Find("Main Camera").GetComponent<CameraMove>().camStartMoveSpeed * Time.deltaTime));
        }

        transform.Translate(Vector3.right * 0.3f * Time.deltaTime);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Destroyable")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Destroyable")
        {
            Destroy(other.gameObject);
        }
    }
}
