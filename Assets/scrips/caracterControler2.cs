using UnityEngine;

public class caracterControler2:MonoBehaviour
{
    public float jumpForce=5.0f;
    public float speed=1.0f;
    public float moveDirection;
    public float moveInput;

    private bool jump;
    private bool grounded=true;
    private bool moving;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spritRender;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Start()
        
    {
   
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spritRender = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if(_rigidbody2D.linearVelocity != Vector2.zero)
        {
            moving = true; //H�z� varsa hareket ediyor
        }
        else
        {
            moving = false; //H�z� yoksa duruyor.
        }

        
        _rigidbody2D.linearVelocity = new Vector2(speed * moveDirection, _rigidbody2D.linearVelocity.y);
        

        if (jump == true)
        {
            _rigidbody2D.linearVelocity = new Vector2(_rigidbody2D.linearVelocityX, jumpForce);
            jump = false;
        }
        
    }
    //merhaba
    private void Update()
    {
        if (grounded && ( Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            Debug.Log("button");

            if (Input.GetKey(KeyCode.A))
            {
                moveDirection = -1.0f;
                _spritRender.flipX = true;
                anim.SetFloat("speed", speed);


            }
            else if (Input.GetKey(KeyCode.D))
            {
                moveDirection = 1.0f;
                _spritRender.flipX = false;
                anim.SetFloat("speed", speed);

            }

        }
        else if (grounded == true)
        {
            moveDirection = 0.0f;
            anim.SetFloat("speed", speed);
            anim.SetFloat("speed", 0);
        }

        if(grounded && Input.GetKey(KeyCode.W))
        {
            jump = true;
            grounded = false;
            anim.SetTrigger("jump");
            anim.SetBool("grounded", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D ether)
    {
        anim.SetBool("grounded", true);
        grounded = true;
    }

}
