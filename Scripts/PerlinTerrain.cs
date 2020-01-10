using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinTerrain : MonoBehaviour
{
    private TerrainData myTerrainData;
    public Vector3 worldSize;
    public int resolution = 129;
    float[,] heightArray;
    // Start is called before the first frame update
    void Start()
    {
        myTerrainData = gameObject.GetComponent<TerrainCollider>().terrainData;
        worldSize = new Vector3(200, 15, 200);
        myTerrainData.size = worldSize;
        myTerrainData.heightmapResolution = resolution;
        heightArray = new float[resolution, resolution];
        Perlin();
        myTerrainData.SetHeights(0, 0, heightArray);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Perlin()
    {
        for (int i = 0; i < resolution; i++)
        {
            for (int k = 0; k < resolution; k++)
            {
                heightArray[i, k] = Mathf.PerlinNoise(i * 0.03f, k * 0.03f);
            }
        }
    }
}
