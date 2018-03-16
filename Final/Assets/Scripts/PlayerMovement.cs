using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]


public class PlayerMovement : MonoBehaviour 
{

	public Rigidbody2D rigid;
	public float speed;
	private Animator anim;
	private SpriteRenderer rend;
	public float Jump;
	private bool isGrounded;
	public Vector3 offset;
	public double myDouble;



	// Use this for initialization
	void Start () 
	{
		rigid = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		rend = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//check for button pushes
		rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
		anim.SetFloat ("HorizontalGo", Input.GetAxisRaw("Horizontal"));
		
		if(Input.GetAxisRaw("Horizontal") < -0.1){
			//Flip sprite renderer
			rend.flipX = true;
		}
		else{
			//unflip
			rend.flipX = false;
		}
		
		if(Input.GetButton("Fire1")){
			anim.SetTrigger("ShootGo");
		}

		if (isGrounded && Input.GetButtonDown("Jump")){
			RaycastHit2D hit = physics2D.Raycast(Transform.position, Vector2.down;
			Debug.DrawRay(transform.position,Vector3.down,red,0.1f,false)
			if (hit.collider.tag == "Ground"){
				Debug.Log("found ground");
				isGrounded = true;
			}
			else{
				isGrounded = false;
			}


			rigid.AddForce(new Vector2 (0,jump), ForceMode2D.Force);
		}




	}
	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.transform.tag == "Ground") {				
			isGrounded = true;
			}
		}

		private void OnCollisionExit2D(Collision2D collision){
			if(collision.transform.tag == "Ground"){
				isGrounded = false;
			}
		}


}
