using UnityEngine;
using UnityEngine.Splines;

public class EnemySpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]private GameObject grunt;
    [SerializeField] private GameObject annoyance;
    public float time;
    public bool StartWave;
    public SplineContainer spline;
    public float maxTime;
    void Start()
    {
        time = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        

        


    }


    private void FixedUpdate()
    {
        if (StartWave)
        {
            time -= Time.deltaTime;

            if (time <= 0)
            {
                time = maxTime;
                var spawnedEnemy = Instantiate(annoyance);
                //  spawnedEnemy

            }


        }
    }
}
