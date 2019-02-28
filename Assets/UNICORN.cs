using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UNICORN : MonoBehaviour {
    public GameObject unicorn; // Assign in inspector
    public bool isShowing;
    void Start()
    {
        unicorn.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown("u"))
        {
            isShowing = !isShowing;
            unicorn.SetActive(isShowing);
        }
    }
}
