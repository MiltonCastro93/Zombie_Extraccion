using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : MonoBehaviour, ItakeDamage {
    [SerializeField] protected int _life = 100, _lifeMax = 100;
    [SerializeField] protected float _speedWalking = 2f;
    [SerializeField] protected float _speedTurn = 2f;
    protected CapsuleCollider _body;

    protected abstract void _walking();
    protected virtual void _action() {
        Debug.Log("Que Hago?");

    }

    public abstract void GenerateDamage(int Damage);
}
