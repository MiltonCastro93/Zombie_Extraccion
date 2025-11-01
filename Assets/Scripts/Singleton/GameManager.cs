using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private static GameManager _manager;

    private List<IObserver> observers = new List<IObserver>();
    private float rangeSound = 100f;

    public static GameManager Manager => _manager;
    private bool _mouseOn = false;

    private void Awake() {
        if(_manager == null) {
            _manager = this;
        } else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void ActivateMouse() {
        _mouseOn = !_mouseOn;
    }

    public void Getsound(float setKey) {
        rangeSound = setKey;
        NotificeObservers();
    }


    public void AddObservers(IObserver newObservers) {
        if (!observers.Contains(newObservers)) {
            observers.Add(newObservers);
        }
    }

    public void DeleteObservers(IObserver FindObservers) {
        if (observers.Contains(FindObservers)) {
            observers.Remove(FindObservers);
        }
    }

    private void NotificeObservers() {
        foreach (IObserver observer in observers) {
            observer.SoundConfiguration(rangeSound);
        }
    }


    ///--------------Actualizar Configuraciones -------------------
    public bool MouseUpdate() {
        return _mouseOn;
    }

}
