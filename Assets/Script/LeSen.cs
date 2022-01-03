using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeSen : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangePosition();
        
    }

    void ChangePosition()
    {
        float xDirection = Input.GetAxisRaw("Horizontal");
        float distance = xDirection * Speed * Time.deltaTime;
        if ((transform.position.x >= 6.5 & xDirection > 0) || (transform.position.x <= -6.5 && xDirection < 0))
        {
            return;
        }
        transform.position += new Vector3(distance,0f,0f);
    }
}
