using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    // URL del icono de Flaticon
    [SerializeField] private string urlFlaticon;
    public void IrMenuCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    
    // Método para abrir la página del icono de Flaticon
    public void AbrirFlaticon()
    {
        Application.OpenURL(urlFlaticon);
    }
}
