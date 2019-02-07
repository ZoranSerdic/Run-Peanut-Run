using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject finish;

    public Transform teleport;

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
        if(other.tag == "Peanut" && reachedFinish == false)
        {
            other.transform.position = teleport.position;

            reachedFinish = true;
            Debug.Log(other.name + " reached the finish line!");
        }
    }
}
