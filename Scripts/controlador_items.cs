using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlador_items : MonoBehaviour
{

    private static int puntos = 0;
    public Text texto_puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            if (tag == "cereza") {
                puntos += 5;
            }

            if (tag == "diamante")
            {
                puntos += 20;
            }
            Debug.Log("puntos :" + puntos);
            texto_puntuacion.text = "Puntuación :" + puntos.ToString();
            Destroy(gameObject);
        }

    }

}
