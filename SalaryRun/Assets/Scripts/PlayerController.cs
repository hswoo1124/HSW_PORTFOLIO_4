using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpForce;
    private float speedcount;
    public float speedinc;
    public float speedmulti;
        

    private Rigidbody2D myRigidbody;

    public bool grounded;

    private bool doubleJumped;

    private Health theHealth;   

    public LayerMask whatIsGround;

    private Collider2D myCollider;

    private bool damaged;
    private bool pushed;
    private Animator myAnimator;
    public AudioSource hitt;
    public AudioSource jump;
    public AudioSource cure;

   
    // Use this for initialization
    void Start()
    {


        myRigidbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();

        theHealth = FindObjectOfType<Health>();
       
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        if (transform.position.x > speedcount)
        {
            speedcount += speedinc;
            moveSpeed = moveSpeed * speedmulti;
        }
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

            if (Input.GetKeyDown(KeyCode.Space) && grounded) //|| Input.GetMouseButtonDown(0)
        {
            if (grounded)
            {
                doubleJumped = false;
                jump.Play();
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce * 3 / 4);
            doubleJumped = true; }
            


            if (theHealth.Min_Health < 10)
        {
            myAnimator.SetFloat("Downed", 0.2f);
        }

        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
        myAnimator.SetFloat("Downed", theHealth.Min_Health);
        myAnimator.SetBool("Damaged", damaged);
        myAnimator.SetBool("Pushed", pushed);

        if (this.transform.position.y < -10.0f)
        {

            theHealth.Min_Health = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Trap")
        {
            hitt.Play();
            damaged = true;
        }
        else if(other.gameObject.tag == "paper")
        {
            cure.Play();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Trap")
        {
            hitt.Stop();
            damaged = false;
        }
        else if (other.gameObject.tag == "paper")
        {
            cure.Stop();
        }
    }

   

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Trap_push")
        {
            pushed = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Trap_push")
        {
            pushed = false;
        }
    }
}
  

