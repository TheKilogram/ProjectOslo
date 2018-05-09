using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSwordCut : MonoBehaviour {
  
    //when sword collides
    void OnCollisionEnter(Collision col)
    {
        //when sword collids with a cuttable object
        if (col.gameObject.transform.tag == "cutable")
        {
            //print("hello");  //you can uncomment for debuging
            Mesh mesh = col.gameObject.GetComponent<MeshFilter>().mesh;
            Vector3[] vertices = mesh.vertices;
            int i = 0;
            while (i < vertices.Length)
            {
                vertices[i] += Vector3.up * Time.deltaTime;
                i++;
            }
            mesh.vertices = vertices;
            mesh.RecalculateBounds();
        }
        
    }
}
