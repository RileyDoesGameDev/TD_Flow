using UnityEngine;
using UnityEngine.Splines;

public class Grunt : SplineMover
{
    public SO_Grunt data;
    protected float splineLength;
    private float t = 0;
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    public override void Move()
    {
        throw new System.NotImplementedException();
    }
    private void Awake()
    {
        MaxHP = data.MaxHP;
        Speed = data.Speed;
        Damage = data.Damage;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        base.Start();
        splineLength = spline.CalculateLength();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (t > 1)
        {
            t = 0;
        }
        transform.position = spline.EvaluatePosition(t);
        t += (Speed * Time.deltaTime) / splineLength;
        transform.rotation = Quaternion.LookRotation(spline.EvaluateTangent(t));
    }
   

}
