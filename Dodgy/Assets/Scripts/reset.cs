using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Application.runInBackground = true;
        FindObjectOfType<audiosettings>().Reset_();
    }    
       
    

}
