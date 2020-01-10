using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaMaker : MonoBehaviour
{
    public GameObject Banana;
    List<GameObject> bananaList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        int x;
        int z;
        RaycastHit hit;
        for (int i = 0; i < Random.Range(30, 51); i++) //Generates 30-50 Bananas
        {
            x = Random.Range(0, 201);
            z = Random.Range(0, 201);
            Physics.Raycast(new Vector3(x, 100, z), Vector3.down, out hit, Mathf.Infinity); //Raycasts to keep the bananas level with the ground       
            bananaList.Add(Instantiate(Banana, hit.point, Quaternion.identity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < bananaList.Count; i++)
        {
            bananaList[i].transform.Rotate(0, 30 * Time.deltaTime, 0);
        }
    }
}
