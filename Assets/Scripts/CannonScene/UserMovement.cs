using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private bool onGround = false;

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
        if (collision.gameObject.tag == "Cube")
            collision.gameObject.SetActive(false);
    }

    private Vector3 GetUserMovementDirection()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        return new Vector3(0, 0, vertical).normalized;
    }

    private void MoveObject(Rigidbody rigidbody, Vector3 direction, float speed)
    {
        rigidbody.AddForce(direction * speed);
    }

    void FixedUpdate()
    {
        Vector3 direction = GetUserMovementDirection();
        MoveObject(_rigidbody, direction, _speed);

        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce);
            onGround = false;
        }
    }
}
