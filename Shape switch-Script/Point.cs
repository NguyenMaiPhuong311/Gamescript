using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private TMP_Text point;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        int score = Collision.count + Collision2.count;
        point.text = "Point: " + score.ToString();
    }
}
