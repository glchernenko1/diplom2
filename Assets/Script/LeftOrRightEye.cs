using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftOrRightEye : MonoBehaviour
{
    [SerializeField] MeshRenderer renderer;
        [SerializeField] bool right = true;
       
        // Start is called before the first frame update
        void Start()
        {
            renderer = GetComponent<MeshRenderer>();
           
            renderer.material.SetFloat("_IndexEye", right ? 1 : 0);
            renderer.material.color = right ?  Color.green : Color.red;
        }
}
