using UnityEngine;
using UnityEngine.Video;
using System.Collections.Generic;
public class OnlineVideoLoader : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject lighting; 
    public List<string> videoUrls = new List<string>{
        "https://theuxmf.github.io/CinemaVR/Cartoon Network _ Patolino_ O Mago _ 2014.mp4",
        "https://theuxmf.github.io/CinemaVR/Crazy Frog - Axel F (Official Video).mp4",
        "https://theuxmf.github.io/CinemaVR/Dragon Ball Z Clipes Animados - Living On A Prayer [QHD 1440p].mp4"
    };
    private int currentVideoIndex = 0;

    private void Start()
    {
        videoPlayer.url = videoUrls[currentVideoIndex];
    }

    public void PlayNextVideo()
    {
        currentVideoIndex++;
        if (currentVideoIndex < videoUrls.Count)
        {  
            videoPlayer.url = videoUrls[currentVideoIndex];
            videoPlayer.Prepare();
        }
        else
        {
            Debug.Log("Todos os vídeos foram reproduzidos.");
            currentVideoIndex--;
        }
    }

    public void PlayPreviouVideo()
    {
        
        if (currentVideoIndex > 0)
        {
            currentVideoIndex--;
            videoPlayer.Play();
            videoPlayer.url = videoUrls[currentVideoIndex];
            videoPlayer.Prepare();
        }
        else
        {
            Debug.Log("Voce esta no primeiro video");
        }
    }

    public void PlayPause(){
        if(videoPlayer.isPlaying){
            videoPlayer.Pause();
        }else{
            videoPlayer.Play();
        }
    }

    public void SetLight()
    {
        lighting.SetActive(!lighting.activeSelf);
    }

}