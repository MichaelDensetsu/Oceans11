using UnityEngine;
using System.Collections;
using UnityEngine.Video;
using UnityEngine.UI;
using VRStandardAssets.Utils;

[RequireComponent (typeof(AudioSource))]

public class MoviePlayer : MonoBehaviour {


    [SerializeField] private VRInteractiveItem m_VRInteractiveItem; // The VRInteractiveItem that needs to be looked at for the textures to play.
    private VideoPlayer videoPlayer;

    void Start ()
    {
        videoPlayer = GetComponent<VideoPlayer>(); // In order to work with the videoplayer component

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
        videoPlayer.Play();
    }


    private void HandleOut()
    {
        // When the user looks away from the VRInteractiveItem the textures should no longer be playing.
        videoPlayer.Stop();
    }
}
