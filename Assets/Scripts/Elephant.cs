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
        if (collision.transform.tag == "Peanut")
        {
            collision.gameObject.GetComponent<Peanut>().Die();
        }
        else if (collision.transform.tag == "Destroyable")
        {
            try
            {
                collision.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            }
            catch
            {

            }
            //Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Peanut")
        {
            other.GetComponent<Peanut>().Die();
        }
        else if (other.transform.tag == "Destroyable")
        {
            try
            {
                other.GetComponentInChildren<ParticleSystem>().Play();
                Debug.Log(other.GetComponentInChildren<ParticleSystem>().gameObject.name);
            }
            catch
            {

            }
            
            //Destroy(other.gameObject);
        }
    }
}
