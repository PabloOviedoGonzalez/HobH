using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum EnemyState
{
    Wander,
    Follow,
    Die,
};

public class EnemyIA : MonoBehaviour
{
    GameObject Player;
    public EnemyState currState = EnemyState.Wander;
    public Transform target;
    Rigidbody2D myRigidbody;
    public float range = 2f;
    public float moveSpeed = 2f;
    private Animator animator;
    public string boolwalk = "walking";
    public string boolruning = "runing";
    public float currentTime;
    public Vector2 dir;
   
    public float maxTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>().gameObject;
        myRigidbody = GetComponent<Rigidbody2D>();
        //target = Player.GetComponent<Transform>();
        animator = GetComponent<Animator>();
        dir.x = Random.Range(-1, 2);
        dir.y = Random.Range(-1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        switch (currState)
        {
            case (EnemyState.Wander):
                Wander();
                break;
            case (EnemyState.Follow):
                Follow();
                break;
            case (EnemyState.Die):
                // Die();
                break;
        }

        if (IsPlayerInRange(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Follow;
        }
        else if (!IsPlayerInRange(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Wander;
        }
        //Crear un temporizador para que cambie de direecion cada x tiempo.
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            dir.x = Random.Range(-1, 2);
            dir.y = Random.Range(-1, 2);
            currentTime = 0;
        }
    }



    public bool IsPlayerInRange(float range)
    {
        
        return Vector3.Distance(transform.position, Player.transform.position) <= range; //Devuelve el resultado de si la posicion de range es verdfadera o falso.
        //Crear if para cambiare de escena.

    }
    
    void Wander()
    {
        //Debug.Log("Wander");
        myRigidbody.velocity = dir * moveSpeed;
        //animator.SetBool(boolwalk, true);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        moveSpeed *= -1;
        transform.localScale = new Vector3(-transform.localScale.x, -transform.localScale.y, -transform.localScale.z);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {


        if (other.collider.GetComponent<Player>())
        {



            Destroy(other.gameObject);
            GameManager.instance.ChangeScene("GameOver");
        }


    }




    void Follow() 
    {
        //Debug.Log("follow");
        myRigidbody.velocity = new Vector2(0f, 0f);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed *Time.deltaTime);
        //animator.SetBool(boolruning, true);
    }
}

