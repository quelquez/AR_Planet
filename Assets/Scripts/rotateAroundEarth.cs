using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAroundEarth : MonoBehaviour
{
    public Transform Earth;
    public Transform Moon;

    // Start is called before the first frame update
    void Start()
    {
        Earth = GameObject.FindGameObjectWithTag("Earth").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //rotate moon around earth
        Moon.RotateAround(Earth.position, Vector3.up, 15 * Time.deltaTime);
    }
}
