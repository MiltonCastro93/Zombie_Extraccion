using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour {
    public float _maxTimer = 2f;
    private float _currentTimer = 0f;
    public Image Image;
    private bool startEfect = false;
    private int indexScene = 0;

    public void switchScene(int scene) {
        SceneManager.LoadScene(scene);
    }

    public void QuitApp() {
        Application.Quit();
    }

    private void Update() {
        if (startEfect) {
            _currentTimer += Time.deltaTime;
            _currentTimer = Mathf.Clamp(_currentTimer, 0f, _maxTimer);
            float porcen = _currentTimer / _maxTimer;
            Image.color = new Color(0, 0, 0, porcen);
            if (porcen >= 1) {
                SceneManager.LoadScene(indexScene);
            }
        }

    }

    public void switchSceneEfect(int scene) {
        startEfect = true;
        indexScene = scene;
    }

}
