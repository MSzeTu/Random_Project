using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GorillaMaker : MonoBehaviour
{
    public GameObject gorilla;
    // Start is called before the first frame update
    void Start()
    {
        int x = 99;
        int z;
        float xzScale;
        float yScale;
        RaycastHit hit;
        for (int i = 0; i < 8; i++)
        {

            z = Random.Range(127,133);
            xzScale = Gaussian(2f, 0.5f);
            yScale = Gaussian(2f, 0.5f);
            GameObject goril = Instantiate(gorilla, new Vector3(0, 0, 0), Quaternion.identity);
            Physics.Raycast(new Vector3(x, 100, z), Vector3.down, out hit, Mathf.Infinity); //Raycasts to keep the bananas level with the ground 
            goril.transform.position = hit.point;
            goril.transform.localScale = new Vector3(xzScale, yScale, xzScale);
            x += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Generates Gaussian Scale
    float Gaussian(float mean, float stdDev)
    {
        float val1 = Random.Range(0f, 1f);
        float val2 = Random.Range(0f, 1f);
        float gaussValue = Mathf.Sqrt(-2.0f * Mathf.Log(val1)) * Mathf.Sin(2.0f * Mathf.PI * val2);
        return mean + stdDev * gaussValue;
    }
}
