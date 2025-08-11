using UnityEngine;

public class BigGrunt : SplineMover
{
    public SO_BigGrunt data;
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
