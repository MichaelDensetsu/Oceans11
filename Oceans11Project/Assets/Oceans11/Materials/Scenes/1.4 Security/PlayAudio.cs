using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

    public AudioSource au;
    public AudioClip ac;
    private void OnMouseEnter()
    {
        au.clip = ac;
        au.Play();
    }
}
