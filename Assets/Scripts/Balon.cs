using TMPro;
using UnityEngine;

public class Balon : MonoBehaviour
{

    [SerializeField]
    private GameObject PanelResultadoFinalPartido;

    [SerializeField]
    private GameObject puntuacionUILocal;
    [SerializeField]
    private GameObject TEXT_Resultado;

    [SerializeField]
    private GameObject puntuacionUIVisitante;

    private int puntuacionLocal = 0;
    private int puntuacionVisitante = 0;
    void Start()
    {
        // Verificar que PanelResultadoFinalPartido esté asignado antes de usarlo
        if (PanelResultadoFinalPartido != null)
        {
            PanelResultadoFinalPartido.SetActive(false);
        }
        else
        {
            Debug.LogWarning("PanelResultadoFinalPartido no está asignado en el Inspector del script Balon");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Analizamos las colisiones con trigger (está en el balón el script pero podría estar en el sensor BandaSurSensor)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BandaSurSensor")
        {
            Debug.Log("Trigger con: " + collision.gameObject.tag);

            puntuacionVisitante++;
            puntuacionUIVisitante.gameObject.GetComponent<TMP_Text>().text = "Visitante: " + puntuacionVisitante;

            PanelResultadoFinalPartido.SetActive(true);
            TEXT_Resultado.gameObject.GetComponent<TMP_Text>().text = "PERDISTE";

            //Destruimos la pelota cuando toca la banda sur
            Destroy(this.gameObject);
            
        }
        else if (collision.gameObject.tag == "BandaNorteSensor")
        {
            //Debug.Log("Trigger con: " + collision.gameObject.tag);

            puntuacionLocal++;
            puntuacionUILocal.gameObject.GetComponent<TMP_Text>().text = "Local: " + puntuacionLocal;

            PanelResultadoFinalPartido.SetActive(true);
            TEXT_Resultado.gameObject.GetComponent<TMP_Text>().text = "GANASTE";

            //Destruimos la pelota cuando toca la banda sur
            Destroy(this.gameObject);
            
        }

    }
}

