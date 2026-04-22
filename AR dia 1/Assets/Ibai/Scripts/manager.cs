using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rojo()
    {
        SceneManager.LoadScene("Dia2");
    }

    public void Azul()
    {
        SceneManager.LoadScene("Escena1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
