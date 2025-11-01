using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
    [SerializeField] GameObject _endLaser;
    [SerializeField] int _damage = 25;
    LineRenderer _line;
    bool _aimEnemy = false;

    private void Awake() {
        gameObject.SetActive(false);
        _endLaser = transform.GetChild(0).gameObject;
    }

    void Start() {
        _line = GetComponent<LineRenderer>();
        _endLaser.SetActive(false);
    }

    private void Update() {
        _line.SetPosition(0, transform.position);
    }

    private void FixedUpdate() {
        RaycastHit hit;
        Vector3 inputDirection = transform.forward + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
        Vector3 direction = inputDirection.normalized;

        if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity)) {
            if (hit.collider.CompareTag("Enemy")) {
                _endLaser.SetActive(true);
                _endLaser.transform.position = hit.point;
                _line.SetPosition(1, hit.point);
                if (Input.GetButtonDown("Fire1") && GetComponentInParent<Player>().ShootReality) {
                    ItakeDamage damage = hit.transform.GetComponentInParent<ItakeDamage>();
                    if (damage != null) {
                        damage.GenerateDamage(_damage);
                    }
                }
            } else {
                _line.SetPosition(1, transform.position + direction * 10f);
            }
        } else {
            _endLaser.SetActive(false);
        }

        if (hit.collider != null) {
            _aimEnemy = hit.collider.CompareTag("Enemy");
            _endLaser.SetActive(_aimEnemy);
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Vector3 dir = transform.forward + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
        Gizmos.DrawLine(transform.position, transform.position + dir.normalized * 10f);
    }
}
