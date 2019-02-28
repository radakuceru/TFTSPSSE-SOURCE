using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class AfterAlarmScene : MonoBehaviour {
    public VideoPlayer VideoPlayer;
    void Start()
    {
        VideoPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
        SceneManager.LoadScene("DoorDesitionScene");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("DoorDesitionScene");
        }

    }
}
