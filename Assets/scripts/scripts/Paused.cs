using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    
    [SerializeField] private GameObject menupausa;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            menupausa.SetActive(true);
        }

    }

    public void reanudar()
    {
        Time.timeScale = 1f;
        menupausa.SetActive(false);
    }
        
    public void reiniciar()
    {
        Time.timeScale = 1f;
       //GameManager.instance.time = 0;
        //GameManager.instance.puntuacion = 0;
        SceneManager.LoadScene("TestLevel");
    }

    public void Salir()
    {
        SceneManager.LoadScene("MainMenu");
    }
}