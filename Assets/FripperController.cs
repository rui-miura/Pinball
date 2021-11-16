using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    private HingeJoint myHingeJoint;
    private float defaultangle = 20;
    private float frickangle = -20;
    // Start is called before the first frame update
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultangle);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripper Tag")
        {
            SetAngle(this.frickangle);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripper Tag")
        {
            SetAngle(this.frickangle);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripper Tag")
        {
            SetAngle(this.defaultangle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripper Tag")
        {
            SetAngle(this.defaultangle);
        }
    }

    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}

