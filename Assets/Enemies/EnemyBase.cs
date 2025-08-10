using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    //base enemy class, all enemies will have a velocity hp, speed and max hp.
    protected Vector3 Velocity;
    protected int HP;
    protected float Speed;
    protected int MaxHP;
    protected float Damage;
    

    public abstract void Move();
    public abstract void Attack();
    public virtual void Start()
    {
        tag = "Enemy";
    }
    

}
