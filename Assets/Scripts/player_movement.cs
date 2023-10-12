using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.GetAxis("Vertical"));
	transform.Translate(Input.GetAxis("Vertical") * Time.deltaTime, 0f, 0f);
    }
}
