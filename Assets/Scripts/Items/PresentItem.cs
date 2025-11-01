using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentItem : MonoBehaviour {
    protected GameObject _item;
    protected float frecuencia = 2f;
    protected float amplitud = 0.5f;
    protected float alturaBase = 0.3f;
    protected float speedTurn = 0.3f;

    private void Awake() {
        _item = transform.GetChild(0).gameObject;
    }

    protected void Update() {
        acciones();
        turnMe();
    }


    protected void acciones() {
        float yOffset = Mathf.Sin(Time.time * frecuencia) * amplitud;
        Vector3 position = _item.transform.localPosition;
        position.y = alturaBase + yOffset;
        _item.transform.localPosition = position;
    }

    protected virtual void turnMe() {
        _item.transform.Rotate(Vector3.up * speedTurn);
    }


}
