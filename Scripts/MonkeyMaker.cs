using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyMaker : MonoBehaviour
{
    public GameObject monkey;
    List<GameObject> monkeyList = new List<GameObject>();
    List<float> yPost = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        int xPosition;
        int zPosition;
        int roll;
        RaycastHit hit;
        for (int i = 0; i < 110; i++)
        {
            roll = Random.Range(0, 101);
            zPosition = Random.Range(120, 150);
            if (roll< 50)
            {
                xPosition = Random.Range(65, 85);
            }
            else if (roll < 75)
            {
                xPosition = Random.Range(55, 65);
            }
            else if (roll < 90)
            {
                xPosition = Random.Range(45, 50);
            }
            else
            {
                xPosition = Random.Range(35, 40);
            }
            GameObject monk = Instantiate(monkey, new Vector3(0, 0, 0), Quaternion.identity);
            Physics.Raycast(new Vector3(xPosition, 100, zPosition), Vector3.down, out hit, Mathf.Infinity); //Raycasts to keep the bananas level with the ground 
            monk.transform.position = hit.point;
            monkeyList.Add(monk);
        }
        for (int k = 0; k < monkeyList.Count; k++)
        {
            yPost.Add(monkeyList[k].transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //bool up = true; ;
        //for (int i = 0; i < monkeyList.Count; i++)
        //{
        //    if (up == true)
        //    {
        //        monkeyList[i].transform.position = new Vector3(monkeyList[i].transform.position.x, monkeyList[i].transform.position.y + 1f*Time.deltaTime, monkeyList[i].transform.position.z);
        //    }
        //    else if (up == false)
        //    {
        //        monkeyList[i].transform.position = new Vector3(monkeyList[i].transform.position.x, monkeyList[i].transform.position.y - 1f*Time.deltaTime, monkeyList[i].transform.position.z);
        //    }
        //    if (monkeyList[i].transform.position.y >= 10f)
        //    {
        //        up = false;
        //    }
        //    else if (monkeyList[i].transform.position.y <= yPost[i])
        //    {
        //        up = true;
        //    }
                  
        //}
    }
}
