using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public int countdown = 0;
    Vector2 dir;
    public GameObject target;
    private const string Tag = "Player";
    public Transform ObjectToFollow = null;
    
    // Start is called before the first frame update
    void Start()
    {
        ObjectToFollow = GameObject.FindGameObjectWithTag(Tag).GetComponent<Transform>();// invocoar " Player" 
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectToFollow == null) //por si no hubiese ningun "Player"
            return;

        transform.position = Vector2.MoveTowards(transform.position, ObjectToFollow.transform.position, speed * Time.deltaTime);
        transform.up = ObjectToFollow.position - transform.position;
    }



private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bullet"))
        {
            if (countdown < 3)
            {
                Destroy(col.gameObject);
                Destroy(gameObject);
            }
            
        }
        //if (col.CompareTag("MainCharacter"))
        //{

        //    Destroy(col.gameObject);
        //    SceneManager.LoadScene("Practica2");

        //}
    }
}
