using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GroundFeet : Enemy {
    protected NavMeshAgent agent;
    [SerializeField] protected LayerMask _layermask;
    protected bool _inAttack = false;
    protected Animator _anim;

    protected new void Awake() {
        base.Awake();
        agent = GetComponent<NavMeshAgent>();
        _anim = GetComponentInChildren<Animator>();
        agent.speed = _speedWalking;
        agent.angularSpeed = _speedTurn;
    }

    // Update is called once per frame
    public new void Update() {
        base.Update();
        if (_detected && !_incapacited) {
            _walking();
        }
    }

    protected override void _walking() {
        float distance = Vector3.Distance(_lostPost.transform.position, transform.position);
        if (distance >= distanceAttack) {
            agent.SetDestination(_lostPost.transform.position);
        }
        agent.isStopped = distance <= distanceAttack;
        _inAttack = agent.isStopped;
    }

}
