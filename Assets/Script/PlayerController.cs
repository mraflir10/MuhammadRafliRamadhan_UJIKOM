using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;

    private Animator animator;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float gravity = -9.81f;

    private float gravitySpeed = 0f;
  

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
       
    }

   
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        if (characterController.isGrounded)
        {
            gravitySpeed = 0f;
        }
        else
        {
            gravitySpeed += gravity * Time.deltaTime;
        }

        move.y = gravitySpeed;

        characterController.Move(move * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("Left");

        }
        else if (Input.GetKey(KeyCode.D))
        {

            animator.SetTrigger("Right");

        }
        else if (Input.GetMouseButton(0))
        {

            animator.SetTrigger("Throw");
        }

    }
}
