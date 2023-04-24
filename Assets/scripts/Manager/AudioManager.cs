using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Array para los sonidos y la musica del juego
    public AudioSource[] sfx;
    public AudioSource[] bgm;


    // Hacemos una referencia singleton
    public static AudioManager singleton;
    // Inicializamos el singleton 
    private void Awake()
    {
        // Comprobamos si el singleton esta vacio y si lo esta queda rellenado con el contenido del codigo 
        if (singleton == null)
            singleton = this;

        // Hace que el AudioManager no sea destruido al cambiar entre escenas 
        DontDestroyOnLoad(gameObject);



    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Metodo para reproducir un sonido pasado por parametros 
    public void PlaySfx(int numeroDeSonido)
    {
        //Solo si el sonido existe lo para por si ya estuviera sonando, y lo reproduce
        if (numeroDeSonido < sfx.Length)
        {
            sfx[numeroDeSonido].Stop();
            sfx[numeroDeSonido].Play();
        }


    }

    // Metodo que reproduce una musica pasada por parametros 

    public void PlayBgm(int numeroDeMusica)
    {
        //Si no se esta reproduciendo ya la musica que queremos se paran todas y se reproduce la seleccionada si existe
        if (!bgm[numeroDeMusica].isPlaying)
        {
            StopMusic();
            if (numeroDeMusica < bgm.Length)
            {
                bgm[numeroDeMusica].Play();
               
            }
        }
    }

    // Metodo que para la musica 
    public void StopMusic()
    {
        //Para cualquier musica que estuviera sonando
        for (int i = 0; i<bgm.Length; i++ )
        {
            bgm[i].Stop();
        }

        
    }
}