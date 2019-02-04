using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    public TextMeshProUGUI realText;

    private float realTime = 0.0f;
    private float time;

    void Update()
    {
        realTime += UnityEngine.Time.deltaTime;
        time = Mathf.Floor(realTime);

        realText.text = "" + time;
    }
}
