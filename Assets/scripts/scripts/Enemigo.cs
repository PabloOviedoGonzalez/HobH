using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float vida;

    public AudioClip deadMusic;
    [Range(0, 1)]
    public float volumeMusic;
    public void TomarDamage(float damage)
    {
        vida -= damage;

        if (vida <= 0)
        {
            Destroy(gameObject);
            GameManager.instance.AddenemyKills(1);
            GameManager.instance.AddEnemyPoints(10);
            AudioManager.instance.PlayAudio(deadMusic, volumeMusic);
        }
        GameManager.instance.ChangeScene("MainMenu");
    }

    public float GetHealth()
    {
        return vida;
    }

    public void SetHealth(float value)
    {
        vida = value;
    }

}