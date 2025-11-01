using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogEnemy : Zombie {



    public new void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            if (!_detected && _incapacited) {
                _player = null;
            }
        }
    }

}
