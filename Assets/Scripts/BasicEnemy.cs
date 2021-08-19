using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public Transform target;
    public BasicAlly ally;
    bool isAlive;

    //or make them all private
    public float speed = 3f;
    public float damage = 1f;
    public float defence = 1f;
    public float health = 20f;


    public float attack1Range = 1f;
    public int attack1Damage = 1;
    public float timeBetweenAttacks;


    // Use this for initialization
    void Start()
    {
        Rest();
        isAlive = true;
        ally = new BasicAlly();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveToPlayer()
    {
        //rotate to look at player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        //move towards player
        if (Vector3.Distance(transform.position, target.position) > attack1Range && ally.health > 0)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        else
        {
            if(ally.health > 0 && health > 0)
            {
                inFight();
            }
         
        }
    }

    public void inFight()
    {
        health -= (ally.damage + 1) - defence;
        if(health == 0)
        {

            Destroy(this.gameObject);
        }
    }

    public void Rest()
    {
        //do nothing
    }
}