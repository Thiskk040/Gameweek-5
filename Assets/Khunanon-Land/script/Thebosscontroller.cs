using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thebosscontroller : MonoBehaviour
{
    CharacterController characterController;
    public float speed;
    private Vector3 moveDirection = Vector3.zero;
    Rigidbody rigidbody;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            animator.SetBool("run", true);

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                animator.SetBool("run", false);
            }


            if (Input.GetAxis("Vertical") < 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                this.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 90, 0);
            }


        }
        characterController.Move(moveDirection * Time.deltaTime);
        functionEmogicon();




    }

    public void functionEmogicon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetBool("rumba", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            animator.SetBool("rumba", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Alpha6))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Alpha7))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Alpha8))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Alpha9))
        {

        }
    }
}