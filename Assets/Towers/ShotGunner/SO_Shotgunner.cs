using UnityEngine;

[CreateAssetMenu(fileName = "SO_Shotgunner", menuName = "Scriptable Objects/SO_Shotgunner")]
public class SO_Shotgunner : ScriptableObject
{
    public string description;
    public int cost;
    public float range;
    public int damage;
    public float fireRate;
    public int health;
}
