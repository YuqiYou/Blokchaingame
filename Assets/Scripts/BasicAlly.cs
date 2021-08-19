using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAlly : MonoBehaviour
{
    public Transform target;
    public BasicEnemy enemy;

    //or make them all private
    public float speed = 3f;
    public float damage = 1f;
    public float defence = 1f;
    public float health = 30f;


    public float attack1Range = 1f;
    public int attack1Damage = 1;
    public float timeBetweenAttacks;

    //mimi
    // Use this for initialization
    void Start()
    {
        Rest();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveToEnemy()
    {
        //rotate to look at player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        //move towards Enemy
        if (Vector3.Distance(transform.position, target.position) > attack1Range)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        else
        {
            if (enemy.health > 0 && health > 0)
            {
                inFight();
            }
        }
    }

    public void inFight()
    {   
        if(enemy)
        health -= (enemy.damage + 1) - defence;
        Debug.Log(health);
        if (health == 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void Rest()
    {
        //do nothing
    }
}