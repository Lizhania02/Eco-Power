using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemigoQuitaVidaAlContacto : MonoBehaviour
{
    [SerializeField] int dano = 1;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerVida>().RestarVida(dano);
            print("Trigger");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerVida>().RestarVida(dano);
            print("Trigger");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerVida>().RestarVida(dano);
            print("Trigger");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerVida>().RestarVida(dano);
            print("Collider");
        }
    }
}
