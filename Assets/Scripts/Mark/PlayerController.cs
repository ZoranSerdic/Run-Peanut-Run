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
    private float rollstartspeed = 2.4f;
    private float rollRotation = 5;
    private float rollspeed = 0;
    private int Maxrollspeed = 6;

    private Vector3 Velocity;
    private Vector3 dir;

    void Update()
    {
        float Horizontal = Input.GetAxis(HorizontalControl);
        float Vertical = Input.GetAxis(VerticalControl);

        //looking in a direction 
        dir = this.transform.position - new Vector3(-Vertical, 0, -Horizontal);
        this.transform.LookAt(dir);

        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            if (rollspeed < Maxrollspeed)
            {
                rollspeed += 0.02f;
            }
            transform.Translate(new Vector3((rollspeed), 0, 0) * Time.deltaTime);
            Model.transform.Rotate(0, -rollRotation, 0);
        }
        else
        {
            rollspeed = rollstartspeed;
        }
    }
}
