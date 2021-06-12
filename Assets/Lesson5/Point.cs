using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    private int point;
    private GameObject pointText; 
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        this.pointText = GameObject.Find("PointText");
        
    }

    // Update is called once per frame
    void Update(GameObject objectName){
        if(objectName.tag == "SmallStarTag") {
            this.point += 20;
            this.pointText.GetComponent<Text>().text = point.ToString();
            Debug.Log(point);
        }else if(objectName.tag == "LargeStarTag") {
            this.point += 10;
            this.pointText.GetComponent<Text>().text = point.ToString();
        }else if(objectName.tag == "SmallCloudTag" || objectName.tag == "LargeCloudTag") {
            this.point += 5;
            this.pointText.GetComponent<Text>().text = point.ToString();
        }
    }

    void OnCollisionEnter(Collision other){
        Update(other);
    }
}