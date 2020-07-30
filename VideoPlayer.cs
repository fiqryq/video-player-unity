using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour {

    private VideoPlayer videopPlayer;

    private void Start()
    {
        videopPlayer = GetComponent<VideoPlayer>();
    }
    
    public void Play()
    {
        videopPlayer.Play();
    }

    public void Pause()
    {
        videopPlayer.Pause();
    }

    public void Stop()
    {
        videopPlayer.Stop();
    }

    public void UrlVideo(string url)
    {
        videopPlayer.source = VideoSource.Url;
        videopPlayer.url = url;
        videopPlayer.Prepare();
        // Jika Prepare Video Selelai akan memutar video
        videopPlayer.prepareCompleted += VideopPlayer_prepareCompleted;
    }

    private void VideopPlayer_prepareCompleted(VideoPlayer source)
    {
        Play();
    }
}
