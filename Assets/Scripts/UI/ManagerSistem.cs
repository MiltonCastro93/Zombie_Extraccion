using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerSistem : MonoBehaviour {
    private GameObject _door, _player;
    [HideInInspector] public GameObject Player => _player;

    public GameObject RestarOn, MenuOn;
    public float _maxTimer = 2f;
    private float _currentTimer = 0f;
    public Image Image;
    private bool _pregame = false;
    public TextMeshProUGUI _state, _textKey, _objetive;
    public GameObject _panel;
    public int cantidadKey = 0;

    private void Awake() {
        _door = FindAnyObjectByType<DoorSegurity>().gameObject;
        _player = FindAnyObjectByType<Player>().gameObject;
        _state.enabled = false;
        _panel.SetActive(true);
        RestarOn.SetActive(false);
        MenuOn.SetActive(false);
        _pregame = true;
        Image.color = new Color(0, 0, 0, 1);
    }

    private void Update() {
        if (_pregame) {
            PlayStart();
        }
        effectoOscuro();

        _objetive.text = cantidadKey <= 0 ? "[Buscar / Recolectar] la Tajeta de Acceso" : "Buscar el Punto de Extraccion";
        _textKey.text = "X" + cantidadKey.ToString();
        _panel.GetComponentInChildren<Slider>().value = _player.GetComponent<Player>().Vida / 100f;
    }

    private void effectoOscuro() {
        if (_door.GetComponent<DoorSegurity>().extraction || _player.GetComponent<Player>().life() <= 0) {
            _state.enabled = true;
            _state.text = _door.GetComponent<DoorSegurity>().extraction == true ? "Te has Salvado" : "Has Muerto";
            _currentTimer += Time.deltaTime;
            _currentTimer = Mathf.Clamp(_currentTimer, 0f, _maxTimer);
            float porcen = _currentTimer / _maxTimer;
            Image.color = new Color(0, 0, 0, porcen);
            _panel.SetActive(false);
            if (porcen >= 1) {
                RestarOn.SetActive(true);
                MenuOn.SetActive(true);
            }
        }
    }

    private void PlayStart() {
        _currentTimer += Time.deltaTime;
        _currentTimer = Mathf.Clamp(_currentTimer, 0f, _maxTimer);
        float porcen = _currentTimer / _maxTimer;
        Image.color = new Color(0, 0, 0, 1 - porcen);
        if(porcen >= 1) {
            _pregame = false;
            _currentTimer = 0f;
        }
    }

}
