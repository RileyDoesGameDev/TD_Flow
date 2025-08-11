using UnityEngine;

[CreateAssetMenu(fileName = "SO_Igniter", menuName = "Scriptable Objects/SO_Igniter")]
public class SO_Igniter : ScriptableObject
{
    public string description;
    public int cost;
    public float range;
    public int damage;
    public float fireRate;
    public int health;
}
