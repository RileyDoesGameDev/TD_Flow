using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shotgunner : BaseTower
{
    public SO_Shotgunner Data;
    CircleCollider2D CircleCollider2D;
    private List<GameObject> enemyCollection;
    public List<GameObject> sockets;
    private bool enemyInRange;
    private EnemyBase enemy;
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
        sockets = new List<GameObject>();
        enemy = GetComponent<EnemyBase>();
    }

    // Update is called once per frame
    void Update()
    {

        if (enemyInRange)
        {
            Fire();
        }

        if (health <= 0)
        {
            Destroy(this);
        }

        Debug.Log(enemyCollection.Count);
    }

    protected override void Fire()
    {
        Debug.Log("Fire");
        RaycastHit2D hit = Physics2D.CircleCast(CircleCollider2D.transform.position, CircleCollider2D.radius, Vector2.zero, 2.5f);
        
        if (hit)
        {
            enemy.MaxHP -= damage;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyInRange = true;
            enemyCollection.Add(collision.gameObject);
            Debug.Log("Intersected");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyInRange = false;
            enemyCollection.Remove(collision.gameObject);
        }
    }
}
