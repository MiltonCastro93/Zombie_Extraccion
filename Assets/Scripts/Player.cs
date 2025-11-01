using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person, ItakeItems {
    private CharacterController _cC;
    private Transform _camera;
    [SerializeField] private GameObject _weapon;
    private Animator _anim;
    private float _inputTurn = 0f, _inputWalking = 0f;
    public bool MouseON = false;
    private bool _keyObtained = false;
    protected AudioSource _audio;
    public AudioClip[] sounds;
    private float _timeShoot = 0f, _maxTime = 1f;

    public int Vida => _life;
    public bool ShootReality = false;

    private void Awake() {
        _cC = GetComponent<CharacterController>();
        _anim = GetComponentInChildren<Animator>();
        _camera = FindObjectOfType<Camera>().transform;
        _audio = GetComponent<AudioSource>();
        _audio.clip = sounds[0];
    }

    // Update is called once per frame
    void Update() {
        _life = Mathf.Clamp(_life, 0, _lifeMax);

        if (_life >= 1) {
            _timeShoot += Time.deltaTime;
            _timeShoot = Mathf.Clamp(_timeShoot,0f,_maxTime);
            ShootReality = _timeShoot >= _maxTime ? true : false;
            _inputTurn = Input.GetAxis("Horizontal");

            if (Input.GetButton("Fire2")) {
                _inputTurn = MouseON == true ? -Input.GetAxis("Mouse X") : Input.GetAxis("Horizontal");
                _action();
                if (Input.GetButtonDown("Fire1") && _timeShoot >= _maxTime) {
                    _timeShoot = 0f;
                    shoot();
                }
            } else {
                _walking();
            }
            _cC.transform.rotation *= Quaternion.Euler(new Vector3(0f, (_inputTurn * _speedTurn), 0f));

            _weapon.SetActive(Input.GetButton("Fire2"));
            _anim.SetFloat("_rightTurn", _inputTurn);
            _anim.SetBool("_inAim", _weapon.activeSelf);
        }

        _anim.SetBool("_isDie", _life <= 0);
    }

    protected override void _walking() {
        _inputWalking = Input.GetAxis("Vertical");
        _anim.SetFloat("_isTurn", _inputTurn);
        _anim.SetBool("_inWalking", _inputWalking != 0);
        _anim.SetFloat("_inMove", _inputWalking);

        if (_inputWalking != 0) {
            if (_audio.clip != sounds[1]) {
                _audio.clip = sounds[1];
                _audio.loop = true;
                _audio.Play();
            } else if (!_audio.isPlaying) {
                _audio.Play();
            }
        } else {
            if (_audio.clip != sounds[0]) {
                _audio.clip = sounds[0];
                _audio.loop = false;
                _audio.Stop();
            }
        }
        _cC.SimpleMove(transform.forward * _inputWalking * _speedWalking);
    }

    protected override void _action() {
        Debug.Log("Apuntando...");
    }

    private void shoot() {
        _audio.clip = sounds[0];
        _audio.Play();
    }


    public Transform Camera() {
        return _camera;
    }

    public override void GenerateDamage(int Damage) {
        _life -= Damage;
    }

    public void _ItakeLive(int healing) {
        _life += healing;
    }

    public void _ItakeAmmo()
    {
        throw new System.NotImplementedException();
    }

    public void _ItakeKey() {
        _keyObtained = true;
    }

    public bool _OpenDoor() {
        return _keyObtained;
    }

    public int life() {
        return _life;
    }
}
