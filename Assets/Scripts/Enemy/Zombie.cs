using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Zombie : GroundFeet {
    [SerializeField]protected AudioSource _audio;
    public AudioClip[] sounds;

    protected new void Awake() {
        base.Awake();
        if(sounds.Length >= 1) {
            _audio = GetComponent<AudioSource>();
        }
    }


    public new void Update() {
        base.Update();
        if(_audio != null) {
            _audio.clip = replay(_detected);
            _audio.Play();
        }

        _action();
    }

    protected override void _action() {
        if (!_incapacited && _detected) {
            _coolDownAttack += Time.deltaTime;
            _coolDownAttack = Mathf.Clamp(_coolDownAttack, 0, _maxCoolDown);
            if (_coolDownAttack >= _maxCoolDown) {
                if (Physics.CheckBox(transform.position + transform.forward, Vector3.one, Quaternion.identity, _layermask)) {
                    _player.GetComponent<ItakeDamage>().GenerateDamage(_damage);
                }
                if(_anim != null && _inAttack) {
                    _anim.SetTrigger("_inAttack");
                }
                _coolDownAttack = 0f;
            }

        }
        if(_anim != null) {
            agent.enabled = !_anim.GetBool("_isDead");
            _Animations();
        }

    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.white;
        Gizmos.DrawCube(transform.position + transform.forward, Vector3.one);
    }

    protected virtual void _Animations() {
        _anim.SetBool("_isDead", _life <= 0);
        if (agent.enabled) {
            if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance && agent.velocity.sqrMagnitude == 0f) {
                _anim.SetBool("_inMove", false);
            } else {
                _anim.SetBool("_inMove", true);
            }
        }
    }

    protected AudioClip replay(bool stateZombie) {
        if (stateZombie) { 
            return sounds[1];
        } else {
            return sounds[0];
        }
    }

}
