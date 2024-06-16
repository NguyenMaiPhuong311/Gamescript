using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float dropToPos;
    private float speed = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        /*transform.position = new Vector3(Random.Range(-4.51f, 7.09f), 5.51f, 0);
        dropToPos = Random.Range(2f, -3f);*/
        Destroy(gameObject,Random.Range(6f,12f));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > dropToPos) { 
        transform.position -= new Vector3(0,speed*Time.deltaTime,0);
        }
        
    
    }
}
