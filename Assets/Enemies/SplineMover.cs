using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Splines;

public abstract class SplineMover : EnemyBase
{
    //enemies that will move along the spline path
    public SplineContainer spline;
    protected float splineLength;
    protected float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Move() 
    {
        t += (Speed * Time.deltaTime) / splineLength;
        t = Mathf.Clamp01(t);
        transform.position = spline.EvaluatePosition(t);
        transform.rotation = Quaternion.LookRotation(spline.EvaluateTangent(t));
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {    
        splineLength = spline.CalculateLength();

    }

    // Update is called once per frame
    public virtual void Update()
    {

        Move();
    }

}
