using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : Zombie {
    [SerializeField] Transform[] _patrolPoints;
    private int indexPoints = 0;
    float _currentDistance = 0f;
    [SerializeField] float _distanceMin = 2f, _distanceMax = 4f;
    Stack<Vector3> _pointStack = new Stack<Vector3>();
    protected bool _explored = false;

    private new void Update() {
        base.Update();
        if (_detected) {
            if(_pointStack.Count <= 0) {
                _pointStack.Push(_lostPost.transform.position);
                _explored = true;
            }
            if(_pointStack.Count >= 1) {
                _currentDistance = Vector3.Distance(_lostPost.transform.position, _pointStack.Peek());
                if (_currentDistance >= _distanceMin && _currentDistance <= _distanceMax) {
                    _pointStack.Push(_lostPost.transform.position);
                }

            }
            
        }

        agent.enabled = !_anim.GetBool("_isDead");
        _walking();

    }

    protected override void _walking() {
        if(agent.enabled && !_incapacited) {
            if (!_detected && _explored) {
                if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance) {
                    if (_pointStack.Count > 0) {
                        Vector3 nextPoint = _pointStack.Pop();
                        agent.SetDestination(nextPoint);
                    } else {
                        _pointStack.Clear();
                        _explored = false;
                    }
                }
            }
            if (_detected) {
                _currentDistance = Vector3.Distance(_lostPost.transform.position, transform.position);
                if (_currentDistance >= distanceAttack) {
                    agent.SetDestination(_lostPost.transform.position);
                }
                agent.isStopped = _currentDistance <= distanceAttack;
                _inAttack = agent.isStopped;
            }
            if (!_detected && !_explored) {
                if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance) {
                    agent.SetDestination(_patrolPoints[indexPoints].position);
                    indexPoints = (indexPoints + 1) % _patrolPoints.Length;
                }

            }

            _Animations();
        }


    }

    protected override void _Animations() {
        _anim.SetBool("_isDead", _life <= 0);
        _anim.SetBool("_inMove", agent.velocity.magnitude >= 0.01f);
    }

}
