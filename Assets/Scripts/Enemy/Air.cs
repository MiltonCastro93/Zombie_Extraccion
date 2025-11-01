using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : Enemy {
    private Rigidbody _rb;
    [SerializeField] private GameObject _vomit, _mount;

    private float frecuencia = 2f;      // Qué tan rápido oscila
    private float amplitud = 0.5f;      // Qué tan alto/bajo va
    private float alturaBase = 3f;      // Altura base del movimiento

    private new void Awake() {
        base.Awake();
        _rb = GetComponent<Rigidbody>();
    }

    private new void Update() {
        base.Update();
        if (!_incapacited) {
            UpDown();
            if (_detected) {
                _conoVision = 360f;
                _walking();
            }
        }
        _rb.useGravity = _incapacited;
    }

    protected override void _walking() {
        Vector3 myPosition = new Vector3(transform.position.x, 0f, transform.position.z);
        float distance = Vector3.Distance(_player.transform.position, myPosition);
        Vector3 lookTarget = _player.transform.position - myPosition;
        transform.rotation = Quaternion.LookRotation(lookTarget, Vector3.down);

        if (distance >= distanceAttack) {
            Vector3 direction = (_player.transform.position - myPosition).normalized;
            direction.y = 0f;
            _rb.MovePosition(transform.position + direction * _speedWalking * Time.deltaTime);
        } else {
            _action();

        }
    }
    
    protected override void _action() {
        _coolDownAttack += Time.deltaTime;
        _coolDownAttack = Mathf.Clamp(_coolDownAttack, 0, _maxCoolDown);
        if(_coolDownAttack >= _maxCoolDown) {
            _coolDownAttack = 0f;
            GameObject bullet = Instantiate(_vomit, _mount.transform.position, _mount.transform.rotation);
            bullet.GetComponent<VomitAttack>()._latePosition = _player.transform.position;
        }
    }

    protected void UpDown() {
        float yOffset = Mathf.Sin(Time.time * frecuencia) * amplitud;
        Vector3 position = transform.position;
        position.y = alturaBase + yOffset;
        transform.position = position;
    }

    public new void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            if (!_detected && _incapacited) {
                _player = null;
            }

        }
    }

}