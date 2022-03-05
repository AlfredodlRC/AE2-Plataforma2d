using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_rata : MonoBehaviour
{
    private float velocidad = 2.8f;
    private Transform posicionJugador;

    // Start is called before the first frame update
    void Start()
    {
        posicionJugador = GameObject.Find("player").transform;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, posicionJugador.position, velocidad * Time.deltaTime);
    }
}
