using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject finish;

    private float timer;

    private bool reachedFinish;
    
    void Update ()
    {
		if (reachedFinish == true)
        {
            timer += 1 * Time.deltaTime;
            
            if(timer >= 8)
            {
                Debug.Log("Restarting current scene");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
	}
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            reachedFinish = true;
            Debug.Log(other.name + " reached the finish line!");
        }
    }
}
