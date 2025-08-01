using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MenuMgr : MonoBehaviour
{
    public Button muteButton;
    public AudioSource audioSource;
    public GameObject muteImg;
    public GameObject unmuteImg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mute()
    {
        if (audioSource.isPlaying)
        {
            muteImg.SetActive(false);
            unmuteImg.SetActive(true);
            audioSource.Stop();
        }
        else
        {
            muteImg.SetActive(true);
            unmuteImg.SetActive(false);
            audioSource.Play();
        }
    }
}
