using System;
using UnityEngine;
using UnityEngine.Splines;

[CreateAssetMenu(fileName = "SO_Grunt", menuName = "Scriptable Objects/SO_Grunt")]
public class SO_Grunt : ScriptableObject
{
    public float Speed;
    public int MaxHP;
    public float Damage;
}
