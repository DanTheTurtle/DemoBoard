using UnityEngine;
using UnityEngine.Video;

public class videoToggle : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
    }
    public void togglePlay()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
        else
        {
            videoPlayer.Play();
        }
    }
}