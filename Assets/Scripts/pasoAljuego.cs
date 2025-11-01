using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasoAljuego : MonoBehaviour
{
    private AudioSource m_AudioSource;
    public int indexScene = 0;

    void Start() {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        if (!m_AudioSource.isPlaying) {
            SceneManager.LoadScene(indexScene);
        }


    }
}
