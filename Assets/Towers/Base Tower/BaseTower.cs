using UnityEngine;

public abstract class BaseTower : MonoBehaviour
{
    protected string description;
    protected int cost;
    protected float range;
    protected int damage;
    protected float fireRate;
    protected int health;
    
    protected abstract void Fire();

}
