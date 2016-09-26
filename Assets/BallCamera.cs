using UnityEngine;
using System.Collections;

public class BallCamera : MonoBehaviour {

    public GameObject BlueBall;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - BlueBall.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = BlueBall.transform.position + offset;

    }
		
}
