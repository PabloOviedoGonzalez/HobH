using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float healthofplayer;
    public void GetDamage(float damage)
    {
        healthofplayer -= damage;

        if (healthofplayer <= 0)
        {
            SceneManager.LoadScene("GameOver");

        }
    }

}
