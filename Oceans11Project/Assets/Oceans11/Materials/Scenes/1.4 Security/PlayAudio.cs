using UnityEngine;
using System.Collections;
using UnityEngine.Video;
using UnityEngine.UI;
using VRStandardAssets.Utils;


public class PlayAudio : MonoBehaviour
{


    [SerializeField] private VRInteractiveItem m_VRInteractiveItem; // The VRInteractiveItem that needs to be looked at for the textures to play.
    public AudioSource au;
    public AudioClip ac;

    void Start()
    {
    }
    private void OnEnable()
    {
        m_VRInteractiveItem.OnOver += HandleOver;
        m_VRInteractiveItem.OnOut += HandleOut;
    }


    private void OnDisable()
    {
        m_VRInteractiveItem.OnOver -= HandleOver;
        m_VRInteractiveItem.OnOut -= HandleOut;
    }


    private void HandleOver()
    {
        // When the user looks at the VRInteractiveItem the textures should start playing.
        au.clip = ac;
        au.Play();
    }


    private void HandleOut()
    {
        // When the user looks away from the VRInteractiveItem the textures should no longer be playing.
        au.Stop();
    }
}
