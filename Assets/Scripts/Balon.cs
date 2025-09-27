using UnityEngine;

public class Balon : MonoBehaviour
{

    [SerializeField]
    private GameObject PanelDerrota;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PanelDerrota.SetActive(false);
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
            //Debug.Log("Trigger con: " + collision.gameObject.tag);
            
            //Activamos panel de derrota
            PanelDerrota.SetActive(true);
            //Destruimos la pelota cuando toca la banda sur
            Destroy(this.gameObject);
        }

    }
}
