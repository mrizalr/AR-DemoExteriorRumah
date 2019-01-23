using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class ControlVideo : MonoBehaviour {

    public VideoPlayer m_VideoPlayer;
    public Button playButtonImg;
    public Sprite playImg;
    public Sprite pauseImg;

    // Update is called once per frame


    void Update () {
		
	}

    public void PlayVideoProfil()
    {
        if (!m_VideoPlayer.isPlaying)
        {
            m_VideoPlayer.Play();
            playButtonImg.image.sprite = pauseImg;
        }
        else if (m_VideoPlayer.isPlaying)
        {
            m_VideoPlayer.Pause();
            playButtonImg.image.sprite = playImg;
        }
    }

    public void stopVideoPlayer()
    {
        m_VideoPlayer.Stop();
        playButtonImg.image.sprite = playImg;
    }

    public void playbackVideo()
    {
        m_VideoPlayer.time -= 3;
    }
}
