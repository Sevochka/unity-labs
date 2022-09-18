using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += (movement * Time.deltaTime) * moveSpeed;

        gameObject.GetComponent<SpriteRenderer>().flipX = Input.GetAxis("Horizontal") < 0;

        
        anim.SetBool("isRun", Input.GetAxis("Horizontal") != 0);

    }
}
