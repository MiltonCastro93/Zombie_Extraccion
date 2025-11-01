using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigUpdate : MonoBehaviour {
    private ManagerSistem _sistem;
    private GameManager _gameManager;

    private void Awake() {
        _sistem = GetComponent<ManagerSistem>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void Start() {
        _sistem.Player.GetComponent<Player>().MouseON = _gameManager.MouseUpdate();

    }


}
