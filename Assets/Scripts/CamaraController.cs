using UnityEngine;

public class CamaraController : MonoBehaviour
{
   
    public GameObject jugador;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - jugador.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = jugador.transform.position + offset;
    }
    void Update()
    {
        
    }
}
