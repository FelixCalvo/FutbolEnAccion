using UnityEngine;

public class MandoPinball : MonoBehaviour
{
    [Header("Configuración del Mando del Pinball")]
    [SerializeField] private float velocidadRotacion; // Grados por segundo
    [SerializeField] private float anguloMaximo; // Ángulo máximo cuando se activa (hacia arriba)
    [SerializeField] private float anguloReposo; // Ángulo de reposo (posición inicial, caído)
    
    [Header("Fuerza de Impacto")]
    [SerializeField] private float fuerzaImpacto; // Fuerza extra al golpear el balón

    [Header("Controles")]
    [SerializeField] private KeyCode teclaActivar; // Tecla para activar ESTE mando específico

    private float anguloObjetivo;

    void Start()
    {
        // Establecer la posición inicial
        anguloObjetivo = anguloReposo;
        transform.rotation = Quaternion.Euler(0f, 0f, anguloReposo);
    }

     void Update()
    {
        // Control usando la tecla específica de este mando
        bool mandoActivado = Input.GetKey(teclaActivar);

        // Determinar ángulo objetivo
        if (mandoActivado)
        {
            anguloObjetivo = anguloMaximo; // Rotar hacia arriba cuando se activa
        }
        else
        {
            anguloObjetivo = anguloReposo; // Volver a la posición de reposo
        }

        // Aplicar rotación suave
        float anguloActual = transform.eulerAngles.z;
        
        // Convertir ángulo a rango -180 a 180 para mejor interpolación
        if (anguloActual > 180f)
            anguloActual -= 360f;
            
        float nuevoAngulo = Mathf.MoveTowards(anguloActual, anguloObjetivo, velocidadRotacion * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0f, 0f, nuevoAngulo);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("BalonFutbol"))
        {
            
            Rigidbody2D balonRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (balonRb != null)
            {
                Vector2 direccionGolpe = new Vector2(Random.Range(-1f, 1f), 1f).normalized;
                balonRb.AddForce(direccionGolpe * fuerzaImpacto, ForceMode2D.Impulse);
            }
        }
    }

}

