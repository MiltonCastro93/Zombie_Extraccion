using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventosSounds : MonoBehaviour
{
    private AudioSource AudioSource;

    // Start is called before the first frame update
    void Start() {
        AudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            AudioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            AudioSource.Stop();
        }
    }

}
