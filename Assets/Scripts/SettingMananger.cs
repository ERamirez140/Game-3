using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SettingMananger : MonoBehaviour
{
    public Toggle FullScreenToggle;
    public Slider MusicVolumeSlider;
    public GameSettings gs;
    public AudioSource musicSource;
    public GameObject BackGroundMusic;
    
    void Start()
    {
        BackGroundMusic = GameObject.FindGameObjectWithTag("music");
        musicSource = BackGroundMusic.GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        gs = new GameSettings();
        FullScreenToggle.onValueChanged.AddListener(delegate { OnFullScreenToggle(); });
        MusicVolumeSlider.onValueChanged.AddListener(delegate { OnMusicVolume(); });
      
    }
    public void OnFullScreenToggle()
    {
       gs.fullscreen = Screen.fullScreen = FullScreenToggle.isOn;
    }

    


    public void OnMusicVolume()
    {
        musicSource.volume = gs.musicVolume = MusicVolumeSlider.value;
    }

    public void SaveSettings()
    {

    }

    public void LoadSettings()
    {

    }
}
