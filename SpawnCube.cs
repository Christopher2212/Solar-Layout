using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject sampleObject; 

    public void AddObject()
    {
        Instantiate(sampleObject, Vector3.zero, Quaternion.identity);
    }
  
}
