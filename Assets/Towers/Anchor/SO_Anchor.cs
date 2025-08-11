using UnityEngine;

[CreateAssetMenu(fileName = "SO_Anchor", menuName = "Scriptable Objects/SO_Anchor")]
public class SO_Anchor : ScriptableObject
{
    public string description;
    public int cost;
    public float range;
    public int damage;
    public float fireRate;
    public int health;
}
