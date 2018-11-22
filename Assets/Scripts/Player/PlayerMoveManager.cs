using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour {

	public float MoveSpeed;
	public float AngleSpeed;

	private Rigidbody rd;
	private Animator animator;

	private float horizontal;
	private float vertical;

	void Start(){
		rd = this.GetComponent<Rigidbody>();
		animator = this.GetComponent<Animator>();
	}
	// Update is called once per frame
	void FixedUpdate () {
		vertical = Input.GetAxis("Vertical");
		horizontal = Input.GetAxis("Horizontal");

		rd.velocity = this.transform.forward * vertical * MoveSpeed;
		rd.angularVelocity = this.transform.up * horizontal * AngleSpeed;

		animator.SetFloat("Speed",vertical);
		animator.SetFloat("Direction",horizontal);
		if(Input.GetKey(KeyCode.Space))
		{
			animator.SetBool("Jump",true);
		}
		
		if ((animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f) && (animator.GetCurrentAnimatorStateInfo(0).IsName("Jump")))
        {
			animator.SetBool("Jump",false);
        }
	}
}
