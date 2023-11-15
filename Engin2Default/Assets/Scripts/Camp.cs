using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camp : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        Worker.s_Camps.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Worker.s_Camps.Remove(this);
    }

}
