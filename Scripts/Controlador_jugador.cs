using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_jugador : MonoBehaviour
{
    private float velocidad = 5.0f;
    private SpriteRenderer flipPlayer;
    private float movementX;
    private Rigidbody2D playerRB;
    private float fuerzaSalto = 9.0f;
    private bool isGround;

    // Start is called before the first frame update
    void Start()
    {
        flipPlayer = GetComponent<SpriteRenderer>();
        playerRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal");

        if (movementX > 0) { 
            flipPlayer.flipX = false;
        }

        if (movementX < 0)
        {
            flipPlayer.flipX = true;
        }

        transform.position += new Vector3(movementX,0,0) * velocidad * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGround) {
            playerRB.AddForce(Vector2.up * fuerzaSalto,ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo") {
            isGround = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            isGround = false;
        }

    }
}
