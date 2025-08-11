using UnityEngine;
using UnityEngine.Splines;

public class EnemySpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SplineContainer spline;
    public GameObject grunt;
    public GameObject annoyance;
    public GameObject bigGrunt;
    public float rate;
    public float gruntSpawnTime;
    private float gruntSpawnTimeMax;
    public float annoyanceSpawnTime;
    private float annoyanceSpawnTimeMax;
    public float bigGruntSpawnTime;
    private float bigGruntSpawnTimeMax;
    void Start()
    {
        gruntSpawnTimeMax = gruntSpawnTime;
        annoyanceSpawnTimeMax = annoyanceSpawnTime;
        bigGruntSpawnTimeMax = bigGruntSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        gruntSpawnTime -= rate * Time.deltaTime;
        annoyanceSpawnTime -= rate * Time.deltaTime;
        bigGruntSpawnTime -= rate * Time.deltaTime;
        if (gruntSpawnTime <= 0)
        {
            spawnGrunt();
            gruntSpawnTime = gruntSpawnTimeMax;
        }
        if (bigGruntSpawnTime <= 0)
        {
            spawnBigGrunt();
            bigGruntSpawnTime = bigGruntSpawnTimeMax;
        }
        if (annoyanceSpawnTime <= 0)
        {
            spawnAnnoyance();
            annoyanceSpawnTime = annoyanceSpawnTimeMax;
        }
    }
    public void spawnGrunt()
    {
        GameObject newGrunt = Instantiate(grunt);
        Grunt gruntscript = newGrunt.GetComponent<Grunt>();
        gruntscript.spline = spline;

    }
    public void spawnAnnoyance()
    {
        GameObject newAnnoyance = Instantiate(annoyance);
        Annoyance annoyancescript = newAnnoyance.GetComponent<Annoyance>();
        annoyancescript.spline = spline;
    }
    public void spawnBigGrunt()
    {
        GameObject newBigGrunt = Instantiate(bigGrunt);
        BigGrunt biggruntscript = newBigGrunt.GetComponent<BigGrunt>();
        biggruntscript.spline = spline;
    }

}
