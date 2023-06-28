using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusicController : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObjects = GameObject.FindGameObjectsWithTag("MainMusic");
        if(musicObjects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void PlayMainMusic()
    {
        this.gameObject.GetComponent<AudioSource>().mute = false;
    }

    public void PauseMainMusic()
    {
       this.gameObject.GetComponent<AudioSource>().mute = true;
    }
}
