using NUnit.Framework;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_PlayerData", menuName = "Scriptable Objects/SO_PlayerData")]
public class SO_PlayerData : ScriptableObject
{
    [SerializeField] public float Health;
    [SerializeField] public int coins;
    


}
