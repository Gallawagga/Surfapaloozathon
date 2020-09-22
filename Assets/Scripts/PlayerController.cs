using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{ 

	[Header("Variables")]
	private Rigidbody2D _playerRigidBody;
	private Vector2 _moveVelocity;
	public float speed = 5.0f;

	public void Start()
    {
		_playerRigidBody = GetComponent<Rigidbody2D>();
	}

    void Update()
    {
		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		_moveVelocity = moveInput.normalized * speed;
		//the .normalized smooths out diagonal movement

	}
	private void FixedUpdate()
	{// all code related to fixing phsyics should be placed in here - youtube guy

		_playerRigidBody.MovePosition(_playerRigidBody.position + _moveVelocity * Time.fixedDeltaTime);
	}
}

	
