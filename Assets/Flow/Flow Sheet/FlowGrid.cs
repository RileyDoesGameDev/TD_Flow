using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FlowGrid : MonoBehaviour
{
    [SerializeField] private int CellCount;

    [SerializeField] private Tile tile;
    [SerializeField] private float tileScale;
     private Tile[,] tiles;
     //private int[,] tileData;
    [SerializeField] private GameObject Pin;
    public SO_ChartData ChartData;

    private void Awake()
    {
        tiles = new Tile[CellCount, CellCount];


        GenerateGrid();
        GeneratePins();
    }
    private void Start()
    {
        
    }

   



    void GenerateGrid()
    {
        float offset = (CellCount- 0.5f);

        for (int i = 0; i < CellCount; i++)
        {
            for(int j = 0; j < CellCount; j++)
            {
                var spawnedTile = Instantiate(tile, transform);
                spawnedTile.transform.localScale = Vector3.one * tileScale;
                spawnedTile.transform.localPosition = new Vector3(i - offset, j - offset, 0);
                spawnedTile.name = $"Tile ({i},{j})";
                tiles[i, j] = spawnedTile;
            }
        }
    }


    void GeneratePins()
    {
        for (int i = 0; i < tiles.GetLength(0); i++)
        {
            for ( int j = 0;j < tiles.GetLength(1); j++)
            {
                tiles[i, j].pinPrefab = Pin;
                switch (ChartData.Set1_5x5[i, j])
                {
                    case 0:
                        
                        break;
                    case 1:
                        tiles[i, j].hasPin = true;
                        tiles[i, j].pinColor = Color.red;
                        break;

                }
            }
        }
    }
   
}

