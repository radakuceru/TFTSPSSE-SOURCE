using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitTimeScript : MonoBehaviour {
    public string nextScene;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Wait());
        SceneManager.LoadScene(nextScene);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(30); 
    }

}
