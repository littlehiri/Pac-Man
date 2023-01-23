using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PacDots : MonoBehaviour
{
    public GameManager referencia;
    //Método para conocer cuando un objeto se ha metido en la zona de trigger de los PacDots
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si el objeto que ha entrado en el trigger está etiquetado como Player
        if (collision.tag == "Player")
        {
            //Recogemos el objeto PacDot concreto, en nuestro caso lo eliminamos
            Destroy(this.gameObject);

            //Podría sumar puntos
            referencia.Puntos += 100;

            referencia.Score.text = referencia.Puntos.ToString();
        }
    }
}
