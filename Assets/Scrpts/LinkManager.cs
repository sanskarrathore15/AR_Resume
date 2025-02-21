using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LinkManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject resume;
    public GameObject centerShowreel;
    public GameObject avatar;

    public VideoPlayerController vpc;

    private void Start()
    {
        resume.SetActive(false);
    }

    public void openLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/sanskar-rathore-a483911b1/");
    }

    public void openInstagram()
    {
        Application.OpenURL("https://www.instagram.com/themartian1553/");

    }

    public void openGithub()
    {
        Application.OpenURL("https://github.com/sanskarrathore15");
    }

    public void openDiscord()
    {
        Application.OpenURL("https://discord.com/users/TheProgrammarGuy#9344");
    }

    public void openGmail()
    {
        Application.OpenURL("mailto:sanskarrathore1553@gmail.com");
    }


    public void openCall()
    {
        Application.OpenURL("tel:6260636779");
    }


    public void openLinkTree()
    {
        Application.OpenURL("https://linktr.ee/sanskar_rathore");
    }

    public void openPortfolio()
    {
        Application.OpenURL("https://sanskarrathore15.netlify.app/");
    }

    public void openRepo0()
    {
        Application.OpenURL("https://github.com/sanskarrathore15/TheRollingBall_AR");
    }

    public void openRepo1()
    {
        Application.OpenURL("https://github.com/sanskarrathore15/Pencil-A-Collaborative-Workspace");
    }

    public void openRepo2()
    {
        Application.OpenURL("https://github.com/sanskarrathore15/Groves_Guardian_");
    }

    public void openRepo3()
    {
        Application.OpenURL("https://github.com/sanskarrathore15/Replantify");

    }
    public void openMRIRepo()
     {
            Application.OpenURL("https://github.com/sanskarrathore15/VR-Acclimatization");
     }

    public void ReloadGame()
    {
        
        Scene currentScene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(currentScene.name);
    }

    public void openResume()
    {
        if (resume != null && avatar != null)
        {
            if (!resume.activeSelf)
            {
                resume.SetActive(true);
                avatar.SetActive(false);
                centerShowreel.SetActive(false);
                if(vpc.videoPlayerUI != null){
                vpc.videoPlayerUI.SetActive(false);
                vpc.videoControlsUI.SetActive(false);
                vpc.playButton.gameObject.SetActive(false);
                vpc.stopButton.gameObject.SetActive(false);
                vpc.pauseButton.gameObject.SetActive(false);   
                }
            }
            else
            {
                resume.SetActive(false);
                avatar.SetActive(true);
                centerShowreel.SetActive(true);

            }
        }
        else
        {
            Debug.LogError("Resume or Avatar GameObject is not assigned.");
        }
    }



}
