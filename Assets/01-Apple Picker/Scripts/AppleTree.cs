using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{

    [Header("Set in Inspector")]

    public GameObject applePrefab;
    public float    speed = 1f;
    public float    leftAndRightEdge = 10f;
    public float    chanceToChangeDirections = 0.1f;
    public float    secondsBetweenAppleDrops = 1f;








    // Start is called before the first frame update
    void Start()
    {
      //dropping apples every second  
    }

    // Update is called once per frame
    void Update()
    {
       //tree moving and changing direction

       Vector3 pos = transform.position;
       pos.x += speed * Time.deltaTime;
       transform.position = pos;


       if (pos.x < -leftAndRightEdge){

            speed = Mathf.Abs(speed);



       } else if (pos.x > leftAndRightEdge) {


            speed = -Mathf.Abs(speed);



       }






    }
}
