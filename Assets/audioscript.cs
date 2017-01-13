using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioscript : MonoBehaviour {

    [SerializeField]
    private AudioSource ButtonHighlightSound;

    [SerializeField]
    private Slider SFXSlider;

    [SerializeField]
    private Slider MasterSlider;

    public void Start()
    {
        SFXSlider.value = ButtonHighlightSound.volume;
        MasterSlider.value = AudioListener.volume;
    }

	public void SFXController()
    {
        ButtonHighlightSound.volume = SFXSlider.value;
    }

    public void MasterVolume()
    {
        AudioListener.volume = MasterSlider.value;
    }
}
