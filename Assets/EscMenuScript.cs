using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenuScript : MonoBehaviour {

    public GameObject menu; // Assign in inspector
    public bool isShowing;

    void Start () {
        menu.SetActive(false);
    }
    public void Play()
    {
        menu.SetActive(!isShowing);
        isShowing = !isShowing;
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }
    }
}
