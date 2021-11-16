using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject scoreText;
    private int SmallStarTag = 0;
    private int LargeStarTag = 0;
    private int a = 0;

    private float VisiblePosz = -6.5f;
    private GameObject tokutenText;
    // Start is called before the first frame update
    void Start()
    {
        this.tokutenText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        
        
            this.tokutenText.GetComponent<Text>().text = a + "“_";            
            
    }
    void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "SmallStarTag")
        {
            SmallStarTag += 10;
            a = SmallStarTag + LargeStarTag;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            LargeStarTag += 20;
            a = SmallStarTag + LargeStarTag;
        }
    }

}

