using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float velocidad;
    //private int puntuacion;

    //[SerializeField]
    //private GameObject puntuacionUI;

    void Start()
    {

        //this.puntuacion = 0;
    }

    // Time.deltaTime = 1 / frames por segundo

    void Update()
    {

        //Teclado
        //GetKeyDown --> solo una vez
        //GetKey --> mientras este pulsada
        //GetKeyUp --> cuando se suelta

        if (Input.GetKeyDown(KeyCode.Space)) //KeyCode.A
        {
            //ebug.Log("Salto");
        }

        //Raton
        //GetMouseButtonDown(0) --> click izquierdo
        //GetMouseButtonDown(1) --> click derecho
        //GetMouseButtonDown(2) --> click rueda

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Click izquierdo");
        }

        //Input.GetAxis("Horizontal") --> devuelve un valor float entre -1 a 1
        //entrada del usuario para un eje específico (en este caso horizontal)


        //Movimiento jugador

        //Project Settings --> Input Manager
        //Horizontal --> A,D, Flecha izq, Flecha der
        //print("Pulso: " + Input.GetAxis("Horizontal"));


        //desplazamiento barra/jugador
        this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0.0f, 0.0f);


    }

    /* private void OnCollisionEnter2D(Collision2D collision)//cuando entra en colision con otro objeto primer frame
    {
        //Debug.Log("Colision con: " + collision.gameObject.name);
        //Para sacar por consola el tag
        //Debug.Log("Colision con: " + collision.gameObject.tag);

        if (collision.gameObject.tag == "BalonFutbol")
        {
            puntuacion++;
            Debug.Log("Choqué con el balón");
            puntuacionUI.gameObject.GetComponent<TMP_Text>().text = "Puntuación: " + puntuacion;

        }
    }

    private void OnCollisionStay2D(Collision2D collision)//cuando entra en colision con otro objeto primer frame
    {
        if (collision.gameObject.tag == "BalonFutbol")
        {
            //Debug.Log("Estoy chocando con el balón");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)//cuando entra en colision con otro objeto primer frame
    {
        //Debug.Log("Colision con: " + collision.gameObject.name);
        //Para sacar por consola el tag
        //Debug.Log("Colision con: " + collision.gameObject.tag);

        if (collision.gameObject.tag == "BalonFutbol")
        {
            //Debug.Log("Dejo de chocar con el balón");
        }
    } */
    

}
