using System.Net;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    //base enemy class, all enemies will have a velocity hp, speed and max hp.
    protected Vector3 Velocity;
    protected float HP;
    protected float Speed;
    protected float MaxHP;
    protected float Damage;
    protected Animator animator;
    //protected GameObject prefab;

    public abstract void Move();
    public abstract void Attack();
    public virtual void Start()
    {
        //prefab.tag = "Enemy";
    }
    

}
