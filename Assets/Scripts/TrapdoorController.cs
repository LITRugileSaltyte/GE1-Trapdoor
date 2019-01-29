using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorController : MonoBehaviour {
    public HingeJoint2D pivotHingeJoint;
    public Transform trapDetector;


    void OnTriggerEnter2D(Collider col)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hero")
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