using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateKills : MonoBehaviour
{
    public Image healthbar;

    public float maxhealth;

    public float newhealth;

    [SerializeField] private int damage; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     public void Update()
    {
        healthbar.fillAmount =  maxhealth - newhealth;
    }
}
