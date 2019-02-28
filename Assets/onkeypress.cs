using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class onkeypress : MonoBehaviour {
    public VideoPlayer VideoPlayer;
    void Start()
    {
        VideoPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
