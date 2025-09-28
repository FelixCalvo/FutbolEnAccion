using UnityEngine;
using UnityEngine.SceneManagement;
public class Temporizador_3sg : MonoBehaviour
{
    void Start()
    {
        // Cambiar escena después de 3 segundos
        Invoke("CambiarEscena", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void CambiarEscena()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
