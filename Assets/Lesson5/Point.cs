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
    void Update(){
        if(tag == "SmallStarTag") {
            this.point += 20;
            this.pointText.GetComponent<Text>().text = (string)point;
        }else if(tag == "LargeStarTag") {
            this.point += 10;
            this.pointText.GetComponent<Text>().text = (string)point;
        }else if(tag == "SmallCloudTag" || tag == "LargeCloudTag") {
            this.point += 5;
            this.pointText.GetComponent<Text>().text = (string)point;
        }
    }

    void OnCollisionEnter(Collision other){
        Update();
    }
}
