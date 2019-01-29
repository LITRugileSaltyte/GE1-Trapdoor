using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorController : MonoBehaviour {
    public HingeJoint2D pivotHingeJoint;
    public Transform trapDetector;


    void OnTriggerEnter2D(Collider col)
    {
        if (col.gameObject.tag == "Hero")
        {
            JointMotor2D theMotor = pivotHingeJoint.motor;
            theMotor.motorSpeed = 100f;
            pivotHingeJoint.motor = theMotor;
        }
    }

    //void SetTrap()
    //{
        
    //}
}