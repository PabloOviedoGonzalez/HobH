using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float vida;
    public void TomarDamage(float damage)
    {
        vida -= damage;

        if (vida <= 0)
        {
            Destroy(gameObject);
            GameManager.instance.AddenemyKills(1);
            GameManager.instance.AddEnemyPoints(10);
        }
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