using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogidaDeItems : MonoBehaviour
{
    [SerializeField] GameObject itemsHijo;
    [SerializeField] float tiempoApagadTems, tiempoDestruirItems;
    [SerializeField] int valorItems = 1;

    [SerializeField] GameObject mascaraItems;

    Animator animator;
    Rigidbody rigidbody;
    AudioSource audioSource;
    Collider collider;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        collider = GetComponent<Collider>();




    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            mascaraItems.SetActive(true);
            StartCoroutine(ActivadorMascaraItems());
            print("Activador de Mascara Items");
            Debug.Log("Funciona el Ontrigger");


            if (animator != null)
            {

                animator.SetTrigger("ActivadorItems");
                audioSource.Play();
                collider.enabled = false;
                Destroy(itemsHijo, tiempoApagadTems);
                Destroy(gameObject, tiempoDestruirItems);
                other.GetComponent<PlayerItem>().SumaItems(valorItems);





            }
            else
            {
                print("No A ");
            }
            print("hit!");
        }
    }

    IEnumerator ActivadorMascaraItems() {

        yield return new WaitForSeconds(0.5f);
        mascaraItems.SetActive(false);
        print("Desactivador de Mascara Items");

    }
    
}

