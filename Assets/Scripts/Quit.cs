using UnityEngine;


public class Quit : MonoBehaviour
{
    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego..."); 
        //cerrar editor unity       
        UnityEditor.EditorApplication.isPlaying = false;
        //cerrar build compilada
        Application.Quit();
    }
}
