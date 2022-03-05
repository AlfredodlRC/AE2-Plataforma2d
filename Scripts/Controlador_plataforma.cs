using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_plataforma : MonoBehaviour
{

    public Transform target;
    public float velocidad = 0.75f;
    private Vector3 comienzo, final;

    // Start is called before the first frame update
    void Start()
    {
        comienzo = transform.position;
        final = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position,velocidad * Time.deltaTime);
        if (transform.position == target.position)
        {
            if (target.position == final)
            {
                target.position = comienzo;
            }
            else
            {
                target.position = final;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.parent = transform;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
    }
}
