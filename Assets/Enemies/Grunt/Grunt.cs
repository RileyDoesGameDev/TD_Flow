using UnityEngine;
using UnityEngine.Splines;

public class Grunt : SplineMover
{
    public SO_Grunt data;
    
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }
    private void Awake()
    {
        MaxHP = data.MaxHP;
        Speed = data.Speed;
        Damage = data.Damage;
    }
}
