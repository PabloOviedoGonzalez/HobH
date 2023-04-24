using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemys : MonoBehaviour
{
    
    public GameObject EnemyPrefab;
    float currentTime;
    public float maxTime = 1.5f;
    Stack<GameObject> pilaEnemys;
    
    public List<string> Enemy = new List<string>();
     


    private void Start()
    {
        pilaEnemys = new Stack<GameObject>();

        pilaEnemys.Push(EnemyPrefab);
        pilaEnemys.Push(EnemyPrefab);
        pilaEnemys.Push(EnemyPrefab);
    }

    void vaciarPila()
    {
        if(pilaEnemys.Count > 0)
        {
            pilaEnemys.Pop();
           
        }
    }


    void Update()
    {

        




        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            //Instantiate(vaciarPila);
            //currentTime = 0;
            //Debug.Log(Enemy.Capacity);
            //Enemy.Add("Enemy");


            foreach (string Asteroids in Enemy)
            {
                Debug.Log(Asteroids);
            }

        }


    }
}
