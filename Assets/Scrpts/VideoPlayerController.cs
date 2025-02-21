using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Reference to the VideoPlayer component
    public Button button1;  // Button 1 for playing the first video
    public Button button2;  // Button 2 for playing the second video
    public Button playButton;  // Button to play the video
    public Button pauseButton;  // Button to pause the video
    public Button stopButton;  // Button to stop the video

    public VideoClip videoClip1;  // First video clip
    public VideoClip videoClip2;  // Second video clip

    public GameObject videoPlayerUI;
    public GameObject videoControlsUI;

    public LinkManager lm;



    private void Start()
    {
        // Button click listeners
        button1.onClick.AddListener(PlayVideo1);
        button2.onClick.AddListener(PlayVideo2);
        playButton.onClick.AddListener(PlayVideo);
        pauseButton.onClick.AddListener(PauseVideo);
        stopButton.onClick.AddListener(StopVideo);

        // Start with no video playing
        videoPlayer.Stop();
        videoPlayerUI.SetActive(false);
        videoControlsUI.SetActive(false);
        playButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(false);    
        stopButton.gameObject.SetActive(false);
    }

    // Function to play the first video clip
    public void PlayVideo1()
    {
        videoPlayerUI.SetActive(true);
        videoControlsUI.SetActive(true);
        videoPlayer.clip = videoClip1;
        playButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(true);
        stopButton.gameObject.SetActive(true);
        if (lm.avatar != null)
        {
            lm.avatar.SetActive(false);
        }       
        videoPlayer.Play();
    }

    // Function to play the second video clip
    public void PlayVideo2()
    {
        videoPlayerUI.SetActive(true);
        videoControlsUI.SetActive(true);
        videoPlayer.clip = videoClip2;
        playButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(true);
        stopButton.gameObject.SetActive(true);
        if (lm.avatar != null)
        {
            lm.avatar.SetActive(false);
        }
        videoPlayer.Play();
    }

    // Function to play the video
    public void PlayVideo()
    {
        if (videoPlayer.clip != null && !videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }

    // Function to pause the video
    public void PauseVideo()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
    }

    // Function to stop the video
    public void StopVideo()
    {
        if (videoPlayer.isPlaying || videoPlayer.isPaused)
        {
            videoPlayer.Stop();
            videoPlayerUI.SetActive(false);  // Hide the video player UI when stopped
            videoControlsUI.SetActive(false);
            playButton.gameObject.SetActive(false);
            pauseButton.gameObject.SetActive(false);
            stopButton.gameObject.SetActive(false);
            lm.avatar.SetActive(true);
        }
    }
}
