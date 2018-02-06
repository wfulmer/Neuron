using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron : MonoBehaviour {
    public GameObject spherePrefab;
    public TextAsset csv;

    void Start() {
        string[] lines = csv.ToString().Split('\n');

        //first instantiate the root node at the origin and instantiate its x, y, and z coords so that we can keep the relative structure of the neuron the same while moving it to the user
        float x = 0f;
        float y = 0f;
        float z = 0f;
        string currLine = lines[0];
        string[] positions = currLine.Split(',');
        x = float.Parse(positions[0]);
        y = float.Parse(positions[1]);
        z = float.Parse(positions[2]);
        Instantiate(spherePrefab, new Vector3(float.Parse(positions[0]) - x, float.Parse(positions[1]) - y, float.Parse(positions[2]) - z), Quaternion.identity);


        for (int i = 1; i< lines.Length; i++)
        {
            currLine = lines[i];
            positions = currLine.Split(',');
            Instantiate(spherePrefab, new Vector3(float.Parse(positions[0])- x, float.Parse(positions[1]) -y, float.Parse(positions[2])-z), Quaternion.identity);
            Debug.Log(i);
        }
	}
	

}
