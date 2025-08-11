using UnityEngine;

[CreateAssetMenu(fileName = "SO_Accelerator", menuName = "Scriptable Objects/SO_Accelerator")]
public class SO_Accelerator : ScriptableObject
{
    public string discription;
    public int cost;
    public float range;
    public float damage;
    public int fireRate;
}
