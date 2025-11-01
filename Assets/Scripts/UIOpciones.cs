using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIOpciones : MonoBehaviour, IObserver {
    GameManager gameManager;
    public Slider SliderSound;
    private float valueSound;

    private void Awake() {
        gameManager = GameManager.Manager;
        gameManager.AddObservers(this);

        SliderSound.onValueChanged.AddListener(OnSliderChanged);
    }

    private void Update() {
        valueSound = SliderSound.value;
        gameManager.Getsound(valueSound);
    }


    public void ConfigMouse() {
        gameManager.ActivateMouse();
    }

    public void OnSliderChanged(float value) {
        gameManager.Getsound(value);
    }

    public void SoundConfiguration(float volumen)
    {
        SliderSound.SetValueWithoutNotify(volumen);
    }



}
