using UnityEngine;

public class Rotar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rota el elemento una cantidad diferente en cada eje y en cada intervalo de tiempo
        //Time.deltaTime es el tiempo transcurrido entre cada frame (a 60fps es aproximadamente 0.016 segundos)
        transform.Rotate(new Vector3 (0,300,0)* Time.deltaTime);
    }
}
