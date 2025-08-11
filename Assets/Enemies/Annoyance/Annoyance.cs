using UnityEngine;

public class Annoyance : SplineMover
{
    public SO_Annoyance data;
    private bool hitThePentagon = false;
   
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }
    private void Awake()
    {
        MaxHP = data.MaxHP;
        Speed = data.Speed;
        Damage = data.Damage;
        animator = GetComponent<Animator>();
    }
    public override void Update()
    {
        base.Update();
        if (t == 1)
        {
            hitThePentagon = true;
            DeathAnimThenDestroy();
        }


    }
    private void DeathAnimThenDestroy()
    {
        animator.SetTrigger("Die");

    }
    public void OnDeathAnimEnd()
    {
        Destroy(transform.root.gameObject);
    }
    private void OnDestroy()
    {
      
        
    }
}
