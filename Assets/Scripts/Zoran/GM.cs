using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float realTime;
    private float timer;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        #region Time system
        realTime += UnityEngine.Time.deltaTime;
        timer = Mathf.Floor(realTime);

        timerText.text = "" + timer;
        #endregion

        #region RQ system
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Reloaded current scene");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("Application quit");
        }
        #endregion
    }
}
