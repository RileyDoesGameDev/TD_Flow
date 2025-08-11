using UnityEngine;

[CreateAssetMenu(fileName = "SO_Base", menuName = "Scriptable Objects/SO_Base")]
public abstract class SO_EnemyBase : ScriptableObject
{
    public int Speed;
    public int MaxHP;
    public int Damage;
    //public GameObject prefab;
}
