using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControlSound : MonoBehaviour, IObserver {
    public AudioMixer mixer;


    private void Awake() {
        GameManager.Manager.AddObservers(this); // Mejor usar Manager en vez de FindObjectOfType
    }


    public void SoundConfiguration(float volumen) {
        float safeVolume = Mathf.Clamp(volumen, 0.0001f, 1f);
        mixer.SetFloat("MasterVolume", Mathf.Log10(safeVolume) * 20);
    }

}
