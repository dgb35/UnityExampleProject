using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _transform;
    [SerializeField] private float _force;
    private Vector3 direction;

    [SerializeField] private ScoreCounter _counter;

    private void Start()
    {
        direction = Vector3.up;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject bullet = Instantiate(_bullet, _transform);
            Rigidbody _bulletRigidbody = bullet.GetComponent<Rigidbody>();
            _bulletRigidbody.AddRelativeForce(direction * _force);

            _counter.AddValue();
        }
    }

    private void OnApplicationQuit()
    {
        if (_counter.GetScore() > _counter.GetMaxScore())
            PlayerPrefs.SetInt("MaxScore", (int)_counter.GetScore());
    }
}
