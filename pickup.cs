using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This code is used on a objective and when a player touch the objective
//The objective will disappear
public class pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
