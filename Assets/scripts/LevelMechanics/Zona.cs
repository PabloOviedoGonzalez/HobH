using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona : MonoBehaviour
{
    // Musica reproducir en esta zona
    public int musicToPlay;
    // Variable para saber si la musica ya esta sonando
    private bool musicStarted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Busco si el objeto que ha entrado dentro del trigger esta etiquetado como player
        if (collision.CompareTag("Player"))
        {
            // si no ha empezado la musica le decimos que ahora si y la reproducimos 

            if ( !musicStarted)
            {
                musicStarted = true;
                AudioManager.singleton.PlayBgm(musicToPlay);
            }
        }
    }
}
