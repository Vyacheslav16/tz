using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    public int x = 50;
    public int y = 50;
    public int z = 50;
    public GameObject MyCap;
    // Use this for initialization
    
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //       CreatePref _score = GetComponent<CreatePref>();
        //       if (_score.left == true)
        //      {
        //           transform.rotation *= Quaternion.Euler(0f, 50f * Time.deltaTime, 0f);
        MyCap.transform.localScale = new Vector3(x, y, z);
    }
    }

