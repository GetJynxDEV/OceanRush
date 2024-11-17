using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FloatChar2 : MonoBehaviour
{
    [SerializeField] public GameObject Player;

    [SerializeField] private float _velocity = 10f;
    [SerializeField] private float _rotationSpeed = 8f;

    [SerializeField] public Sprite endFish;

    bool isCollided = false;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow was pressed");

            //If w is pressed Character floats / swims up

            _rb.velocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }

    //Character Death Method

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isCollided = true;
        GetComponent<SpriteRenderer>().sprite = endFish;

        if (isCollided == true)
        {
            Player.SetActive(false);
        }
    }
}
