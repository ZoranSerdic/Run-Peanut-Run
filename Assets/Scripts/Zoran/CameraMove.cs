using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float camStartMoveSpeed = 2f;
    public float camMidMoveSpeed = 3f;
    public float camEndMoveSpeed = 4f;

    private float timer;

    private bool timeUpStart = false;
    private bool timeUpMid = false;

	void Update ()
    {
        timer += 1 * Time.deltaTime;

        if (timer >= 15)
        {
            timeUpStart = true;
        }
        if (timer >= 30)
        {
            timeUpMid = true;
        }

        if (GameObject.Find("GM").GetComponent<GM>().timer >= 68)
        {
            transform.Translate(Vector3.right * 0 * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.F))
        {
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
        else if (timeUpStart == true && timeUpMid == true)
        {
            transform.Translate(Vector3.right * camEndMoveSpeed * Time.deltaTime);
        }
        else if (timeUpStart == true)
        {
            transform.Translate(Vector3.right * camMidMoveSpeed * Time.deltaTime);
        }
        else if(timeUpStart == false)
        {
            transform.Translate(Vector3.right * camStartMoveSpeed * Time.deltaTime);
        }
	}
}
