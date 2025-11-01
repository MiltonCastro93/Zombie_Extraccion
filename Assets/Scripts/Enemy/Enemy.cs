using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.AI;

public abstract class Enemy : Person {
    protected GameObject _player, _lookAngle;
    protected Transform _lostPost;
    protected float _coolDownAttack = 0f;
    [SerializeField] protected float _maxCoolDown = 2f, _conoVision = 90f, distanceAttack = 2f;
    [SerializeField] protected int _damage;
    protected bool _detected = false, _incapacited = false;

    public void Awake() {
        _lookAngle = transform.Find("LookAngle").gameObject;
        _body = GetComponentInChildren<CapsuleCollider>();
    }

    public void Update() {
        _life = (int)Mathf.Clamp(_life, 0, _life);
        _incapacited = _life <= 0;
        _body.enabled = !_incapacited;
    }

    private void FixedUpdate() {
        if(_player != null && !_incapacited) {
            RaycastHit hit;
            Vector3 direction = _lostPost.transform.position - transform.position;
            if(Physics.Raycast(transform.position, direction.normalized,out hit)) {
                _detected = hit.collider.CompareTag("Player");
            }
        }

        if (_incapacited) {
            Destroy(gameObject, 6f);
        }
    }

    protected override void _walking() {
        Debug.Log("debo caminar");
    }

    private void OnTriggerStay(Collider other) {
        if (_player != null) {
            Vector3 directionToPlayer = _player.transform.position - transform.position;
            directionToPlayer.y = 0f;
            if(directionToPlayer != Vector3.zero) {
                _lookAngle.transform.rotation = Quaternion.LookRotation(directionToPlayer);
                float angle = Vector3.Angle(transform.forward, directionToPlayer);
                _detected = angle <= _conoVision;
                _lostPost = _player.transform;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            _player = other.gameObject;
        }
    }

    public void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            _player = null;
        }
    }

    public override void GenerateDamage(int Damage) {
        _life -= Damage;
    }

}
