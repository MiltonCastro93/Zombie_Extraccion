using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botiquin : PresentItem {
    public int healing = 50;

    private void OnTriggerEnter(Collider other) {
        ItakeItems target = other.GetComponent<ItakeItems>();
        if(target != null) {
            target._ItakeLive(healing);
            Destroy(gameObject);
        }

    }

}
