using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private float fallSpeed = 6f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.fixedDeltaTime, Space.World);

    }

}
