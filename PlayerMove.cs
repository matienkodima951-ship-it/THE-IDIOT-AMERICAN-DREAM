using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerMove : MonoBehaviour
{
    private CharacterController controler;
    public float speed = 5.0f;
    public float gravity = -7.0f;
    private Vector2 velocity;

    void Start()
    {
        controler = GetComponent<CharacterController>();
    }

    void Update()
    {
      float moveX = Input.GetAxis("Horizontal");
      float moveZ = Input.GetAxis("Vertical");
    }



}
