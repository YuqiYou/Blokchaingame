using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public BoxCollider territory;
    public float maxPopulation;//max population
    public float currentPopulation;
    public float regenSpeed;

    public GameObject player;
    BasicAlly basicAlly;
    bool playerInTerritory;


    GameObject enemy;
    BasicEnemy basicenemy;

    // Use this for initialization
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        basicAlly= player.GetComponent<BasicAlly>();
       // playerInTerritory = false;
    }

    // Update is called once per frame
    void Update()
    {

        basicAlly.MoveToEnemy();

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