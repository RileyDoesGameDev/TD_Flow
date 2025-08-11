using UnityEngine;

[CreateAssetMenu(fileName = "SO_Base", menuName = "Scriptable Objects/SO_Base")]
public abstract class SO_EnemyBase : ScriptableObject
{
    public float Speed;
    public float MaxHP;
    public float Damage;
    //public GameObject prefab;
}
