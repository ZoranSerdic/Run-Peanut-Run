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
    private float roll;
    private float rollRotation;


    private float MaxSpeed = 0.001f;

    private Vector3 Velocity;
    private Vector3 dir;


	void Update ()
    {
        //rotation.z ( forward = negative ) 

        float h = Input.GetAxis(HorizontalControl);
        float j = Input.GetAxis(VerticalControl);

        if (j > 0.001f || h > 0.001f)
        {
            dir = this.transform.position - new Vector3(-j, 0, -h);
            this.transform.LookAt(dir);
        }



        float Speed = Input.GetAxis(SpeedControl);
        if (Speed > 0.2 || Speed < 0.2)
        {
            roll += Speed / 20 ;
            rollRotation += Speed;

            
            transform.Translate(new Vector3(-roll, 0, 0) * Time.deltaTime);

        }
        else
        {
            roll = 0;
            rollRotation = 0;

        }

        if (roll > MaxSpeed)
        {
            roll = MaxSpeed;
        }

        //Model.transform.Rotate(0, rollRotation, 0);


    }
}
