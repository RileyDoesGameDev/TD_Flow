using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Anchor : BaseTower
{
    public SO_Anchor Data;
    CircleCollider2D CircleCollider2D;
    private List<GameObject> enemyCollection;
    private bool enemyInRange;
    private void Awake()
    {
        damage = Data.damage;
        description = Data.description;
        cost = Data.cost;
        range = Data.range;
        fireRate = Data.fireRate;
        health = Data.health;
    }

    void Start()
    {
        enemyCollection = new List<GameObject>();
        CircleCollider2D = GetComponent<CircleCollider2D>();
        CircleCollider2D.radius = Data.range;




    }

    // Update is called once per frame
    void Update()
    {

        if (enemyInRange)
        {
            Fire();
        }


        Debug.Log(enemyCollection.Count);
    }

    protected override void Fire()
    {
        Debug.Log("Fire");


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyInRange = true;
            enemyCollection.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyCollection.Remove(collision.gameObject);
        }
    }







}
