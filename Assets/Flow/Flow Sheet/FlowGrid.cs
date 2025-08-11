using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FlowGrid : MonoBehaviour
{
    public Camera mainCamera;
    private Tile startTile;
    private Color activeColor;
    


    [SerializeField] private int CellCount;

    [SerializeField] private Tile tile;
    [SerializeField] private float tileScale;

    private Dictionary<Vector2, Tile> tiles;
   
    [SerializeField] private GameObject Pin;
    [SerializeField] private GameObject fill;
    private bool ValidTile = false;
    public SO_ChartData ChartData;

    private void Awake()
    {

        GenerateGrid();
        GeneratePins();
    }
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Tile tile = GetTileUnderMouse();

            if (tile != null && tile.hasPin)
            {
                ValidTile = true;
                startTile = tile;
                activeColor = tile.pinColor;

            }
        }







        if (Input.GetMouseButton(0))
        {
            Tile tile = GetTileUnderMouse();
            if (ValidTile && tile !=null)
            {
               
                tile.DrawFill(activeColor);
            }
            
        }



        if (Input.GetMouseButtonUp(0))
        {
           ValidTile = false;
        }

        
    }

    public void ResetGrid()
    {
        
    }

    Tile GetTileUnderMouse()
    {
        Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
        if (hit.collider != null)
        {
            var temp = hit.collider.GetComponent<Tile>();
            Debug.Log($"Tile: {temp.name}");
            return temp;
        }
        return null;
    }


    void GenerateGrid()
    {

        float offset = (CellCount- 0.5f);
        tiles = new Dictionary<Vector2, Tile>();
       // tiles = new Tile[CellCount, CellCount];
        for (int i = 0; i < CellCount; i++)
        {
            for(int j = 0; j < CellCount; j++)
            {
                var spawnedTile = Instantiate(tile, transform);
                spawnedTile.transform.localScale = Vector3.one * tileScale;
                spawnedTile.transform.localPosition = new Vector3(i - offset, j - offset, 0);
                spawnedTile.name = $"Tile ({i},{j})";
                tiles[new Vector2(i, j)] = spawnedTile;
            }
        }
    }



    public Tile GetTileAtPosition(Vector2 Pos)
    {
        if(tiles.TryGetValue(Pos, out var tile))
        {
            return tile;
           
        }
        return null;
    }




    private void setPinData(Color color, string tag, float posX, float posY )
    {
        GetTileAtPosition(new Vector2(posX, posY)).hasPin = true;
        GetTileAtPosition(new Vector2(posX, posY)).pinColor = color;
        GetTileAtPosition(new Vector2(posX, posY)).tag = tag;
    }


    void GeneratePins()
    {
        for (int i = 0; i < CellCount; i++)
        {
            for ( int j = 0; j < CellCount; j++)
            {

                GetTileAtPosition(new Vector2(i,j)).pinPrefab = Pin;
                GetTileAtPosition(new Vector2(i,j)).fillPrefab = fill;
                
                switch (ChartData.Set1_5x5[i, j])
                {
                    case 0:
                        
                        break;
                    case 1:
                        setPinData(Color.red, "red", i, j);
                        break;
                    case 2:
                        setPinData(Color.blue, "blue", i, j);
                        break;
                        case 3:
                        setPinData(Color.green, "green", i, j);
                        break;
                        case 4:
                        setPinData(Color.yellow, "yellow", i, j);
                        break;
                        case 5:
                        setPinData(Color.orange, "orange", i, j);
                        break;

                }
            }
        }
    }
   
}

