using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private Rigidbody2D _rb;
    public Vector2 _moveVector;
    public Animator animator;
    public SpriteRenderer _spriteRenderer;
    public Transform GroundCheck;
    public LayerMask mask;

    float _moveSpeed = 1000f;
    public float jumpForce = 7f;
    public bool isGround = false;
    public float chekRadius = 0.5f;
  
    void Start()    
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

   
    void Update()
    {
        Walk();
        CheckingGround();
        Jump();
    }

    private void Walk ()
    {
        _moveVector.x = Input.GetAxis("Horizontal");
        animator.SetFloat("moveX", Mathf.Abs(_moveVector.x));
        


        if(_moveVector.x < 0 ) {
            RotatePlayerY(_moveVector,180);
        }
        else 
        {
            RotatePlayerY(_moveVector, 0);
        }
        _rb.velocity = new Vector2(_moveVector.x* _moveSpeed * Time.deltaTime, _rb.velocity.y);
      
      

    }
    private void RotatePlayerY(Vector2 _moveVector, int angle)
    {
        _moveVector = transform.eulerAngles;
        _moveVector.y = angle;
        transform.rotation = Quaternion.Euler(_moveVector);
    }

    private void Jump()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (isGround)
            {   

                _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
            }
        }
        
    }

    void CheckingGround()
    {
        isGround = Physics2D.OverlapCircle(GroundCheck.position, chekRadius, mask);
        animator.SetBool("Jump", isGround);
    }
}
