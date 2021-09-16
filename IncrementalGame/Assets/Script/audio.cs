using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    //menambahkan audio 
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
    //mematikan audio   
    public void mute() 
    {
        bsound.Pause();
        btnplay.SetActive(true);
        btnmute.SetActive(false);
    }
    // memulai kembali audio
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
