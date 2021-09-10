using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource bsound;
    public GameObject btnmute;
    public GameObject btnplay;
    // Start is called before the first frame update
    void Start()
    {
        bsound.playOnAwake = true;
        bsound.loop = true;
        btnplay.SetActive(false);
    }

    public void mute() 
    {
        bsound.Pause();
        btnplay.SetActive(true);
        btnmute.SetActive(false);
    }
    public void play() 
    {
        bsound.Play();
        btnplay.SetActive(false);
        btnmute.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
