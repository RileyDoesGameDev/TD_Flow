using UnityEngine;

public abstract class BaseTower : MonoBehaviour
{
    protected string discription;
    protected int cost;
    protected float range;
    protected float damage;
    protected int fireRate;
    
    protected abstract void Fire();




}
