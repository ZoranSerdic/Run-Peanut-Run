using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    private string HorizontalControl = "Horizontal_P1";
    [SerializeField]
    private string VerticalControl = "Vertical_P1";


    void Start ()
    {
		
	}
	

	void Update ()
    {
        float h = Input.GetAxis(HorizontalControl) / 8;
        if (h > 0.1f || h < -0.1f)
        {
            Player.transform.Translate(h, 0, 0);
        }
        float j = Input.GetAxis(VerticalControl) / 8;
        if (j > 0.1f || j < -0.1f)
        {
            Player.transform.Translate(0,0,j * -1);
        }

    }
}
