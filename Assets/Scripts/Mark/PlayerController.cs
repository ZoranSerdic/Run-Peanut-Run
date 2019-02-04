using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    GameObject Model;
    [SerializeField]
    private string HorizontalControl = "Horizontal_P1";
    [SerializeField]
    private string VerticalControl = "Vertical_P1";
    [SerializeField]
    private string SpeedControl = "VerticalRight_P1";
    private float roll = 3;
    private float rollRotation = 5;

    private Vector3 Velocity;
    private Vector3 dir;


	void Update ()
    {
        //rotation.z ( forward = negative ) 

        float h = Input.GetAxis(HorizontalControl);
        float j = Input.GetAxis(VerticalControl);

        if (true)
        {
            //looking in a direction
            dir = this.transform.position - new Vector3(-j, 0, -h);
            this.transform.LookAt(dir);
        }

        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            roll = 3;
            transform.Translate(new Vector3((roll), 0, 0) * Time.deltaTime);
            Model.transform.Rotate(0, -rollRotation, 0);
        }
        else
        {
            roll = 0;
        }
    }
}
