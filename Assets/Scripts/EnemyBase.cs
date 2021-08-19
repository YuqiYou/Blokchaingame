using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public BoxCollider territory;
    GameObject player;
    bool playerInTerritory;


    public GameObject enemy;
    BasicEnemy basicenemy;
    public float maxPopulation;//max population
    public float currentPopulation;
    public float regenSpeed;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        basicenemy = enemy.GetComponent<BasicEnemy>();
        playerInTerritory = false;
    }

    // Update is called once per frame
    void Update()
    {
       
       basicenemy.MoveToPlayer();
      
    }

    //void ontriggerenter(collider other)
    //{
    //    if (other.gameobject == player)
    //    {
    //        playerinterritory = true;
    //    }
    //}

    //void ontriggerexit(collider other)
    //{
    //    if (other.gameobject == player)
    //    {
    //        playerinterritory = false;
    //    }
    //}
}
