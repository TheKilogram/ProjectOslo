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
            
            vertices = new Vector3[] { new Vector3(1, 1, 0), new Vector3(1, 0, 0), new Vector3(0, 0, 0), new Vector3(0, 1, 0) };
           
            mesh.vertices = vertices;
            mesh.triangles = new int[] { 0, 1, 2, 2, 1, 3 };
            mesh.RecalculateBounds();
        }
        
    }
}
