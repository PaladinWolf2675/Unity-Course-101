using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _points;

    private bool _hasMessageBeenSent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if space key is pressed
        //add 10 points

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //add 10 points
            _points = _points + 10;
        }

        //if point value is greater than or equal to 50
        // print you are awsome

        if (_points >= 50 && _hasMessageBeenSent == false)
        {
            Debug.Log("You are awesome!!");
            _hasMessageBeenSent = true;
        }
        
        
    }
}
