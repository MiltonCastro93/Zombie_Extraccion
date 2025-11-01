using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Key : PresentItem {
    public ManagerSistem controller;


    private void Start() {
        speedTurn = 0.5f;
    }

    protected new void Update() {
        base.Update();
        turnMe();
    }


    private void OnTriggerEnter(Collider other) {
        ItakeItems target = other.GetComponent<ItakeItems>();
        target._ItakeKey();
        controller.cantidadKey = 1;
        Destroy(gameObject);
    }

    protected override void turnMe() {
        transform.Rotate(Vector3.up * speedTurn);
    }

}
