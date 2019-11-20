using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerIsom : MonoBehaviour
{

    private Animator animator;
    private SpriteRenderer sp;
    private Rigidbody2D rb;
    public float speed = 5.0f;

    // Use this for initialization
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        rb.AddForce(move * speed);
       // transform.position += move * speed * Time.deltaTime;
        

    }
}