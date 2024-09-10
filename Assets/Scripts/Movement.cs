using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
public class Movement : MonoBehaviour
{
    public int speed;
    public int jumpforce;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        if (Input.GetKey(KeyCode.Insert))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }
}
