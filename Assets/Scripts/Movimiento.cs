using UnityEngine;
using TMPro;

public class Movimiento : MonoBehaviour
{
    private Rigidbody rb; //crea el objeto rb de tipo Rigidbody
    public float velocidad = 5f; //variable para la velocidad del objeto
    private int contador=0;
    public TextMeshProUGUI textoContador; //objeto de tipo TextMeshProUGUI para mostrar el contador


    void Start()
    {
        rb= GetComponent<Rigidbody>(); //asigna el componente Rigidbody al objeto rb
    }


    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal"); //obtiene el valor del eje horizontal
        float movimientoVertical = Input.GetAxis("Vertical"); //obtiene el valor del eje vertical

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical)*10;
        rb.AddForce(movimiento * velocidad); //fuerza aplicada al objeto
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cosas"))
        {
            other.gameObject.SetActive(false); //desactiva el objeto que colisiona
            Debug.Log("Cubos recogidos: " + ++contador);
            textoContador.text = "Puntos: "+ contador.ToString(); //hace visible el contador en pantalla como texto
        }
    }
}
