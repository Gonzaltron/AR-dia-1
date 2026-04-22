using UnityEngine;

public class triggers : MonoBehaviour
{

    [SerializeField] Canvas rojo;
    [SerializeField] Canvas azul;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rojo.enabled = false;
        azul.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Rojo"))
        {
            rojo.enabled = true;
        }
        else if (other.CompareTag("Azul"))
        {
            azul.enabled = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Rojo"))
        {
            rojo.enabled = true;
        }
        else if (other.CompareTag("Azul"))
        {
            azul.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Rojo"))
        {
            rojo.enabled = false;
        }
        else if (other.CompareTag("Azul"))
        {
            azul.enabled = false;
        }
    }
}
