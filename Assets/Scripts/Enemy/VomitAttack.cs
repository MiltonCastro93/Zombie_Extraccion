using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VomitAttack : MonoBehaviour {
    [SerializeField] float _speed = 2f;
    [SerializeField] int _damage = 10;
    Rigidbody _rb;
    public Vector3 _latePosition = Vector3.zero;
    bool _inPaused = false;


    private void Awake() {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        if (_inPaused) {
            Debug.Log("me tengo que destruir");
        } else {
            Vector3 direction = (_latePosition - transform.position).normalized;
            _rb.MovePosition(transform.position + direction * _speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision) {
        bool targetPlayer = collision.gameObject.GetComponent<Player>();
        if (targetPlayer) {
            Debug.Log("entro");
            collision.gameObject.GetComponent<ItakeDamage>().GenerateDamage(_damage);
            _inPaused = true;
        }

    }

}
