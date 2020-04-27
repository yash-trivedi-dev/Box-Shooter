using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public enum motionDirection {Spin, Horizontal, Vertical};
    public motionDirection motionState = motionDirection.Horizontal;
    public float SpinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;

    // Update is called once per fram
    void Update()
    {
        switch(motionState) {
            case motionDirection.Spin:
                
                // rotate around the up axis to the gameObject
                gameObject.transform.Rotate(Vector3.up * SpinSpeed * Time.deltaTime);
                break;

            case motionDirection.Horizontal:
                // move right and left over time
                gameObject.transform.Translate( Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude );
                break;

            case motionDirection.Vertical:
                // move up and down over time
                gameObject.transform.Translate( Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude );
                break;
        }
    }
}
