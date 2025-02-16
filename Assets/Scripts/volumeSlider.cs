using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class volumeSlider : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Slider audioSlider;
    public float startVolume;

    void Start()
    {
        // Set the slider's max value to 1 (full volume)
        audioSlider.maxValue = 1f;

        // Set the slider's initial value to the given
        audioSlider.value = 0;

        // Set the video player's volume to the given
        videoPlayer.SetDirectAudioVolume(0, 0);

        // Add listener to update the video player's volume when the slider value changes
        audioSlider.onValueChanged.AddListener(SetAudioVolume);
    }

    void SetAudioVolume(float volume)
    {
        // Set the video player's volume to the slider's value
        videoPlayer.SetDirectAudioVolume(0, volume);
    }
}