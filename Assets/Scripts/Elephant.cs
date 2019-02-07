using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Elephant : MonoBehaviour
{
    private ParticleSystem System;

    [MenuItem("AssetDatabase/LoadAssetExample")]

    private void Start()
    {
        System = (ParticleSystem)AssetDatabase.LoadAssetAtPath("Assets/Art/HitEffect/Stars.prefab", typeof(ParticleSystem));
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
        //transform.Translate(Vector3.right * -0.2f * Time.deltaTime);
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
            Instantiate(System, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject.gameObject);
            Destroy(collision.gameObject);
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
            Instantiate(System,other.transform.position,Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
