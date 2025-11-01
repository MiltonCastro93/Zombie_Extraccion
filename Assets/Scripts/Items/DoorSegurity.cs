using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSegurity : MonoBehaviour
{
    public bool extraction = false;



    private void OnTriggerEnter(Collider other) {
        ItakeItems take = other.GetComponent<ItakeItems>();
        extraction = take._OpenDoor();
    }


}
