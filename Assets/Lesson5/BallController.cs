using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private int point;
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private GameObject pointText;
    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointText = GameObject.Find("PointText");
        point = 0;
        this.pointText.GetComponent<Text>().text = point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePosZ){
            this.gameoverText.GetComponent<Text> ().text = "Game Over";
            Debug.Log("test");
        }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "SmallCloudTag"){
            this.point += 10;
            this.pointText.GetComponent<Text>().text = point.ToString();
        }　else if(collision.gameObject.tag == "SmallStarTag") {
            this.point += 20;
            this.pointText.GetComponent<Text>().text = point.ToString();
        } else if(collision.gameObject.tag == "LargeStarTag"){
            this.point += 30;
            this.pointText.GetComponent<Text>().text = point.ToString();
        } else if(collision.gameObject.tag == "LargeCloudTag") {
            this.point += 10;
            this.pointText.GetComponent<Text>().text = point.ToString();
        }
    }
}
