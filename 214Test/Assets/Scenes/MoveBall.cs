using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    float frame;
    // Start is called before the first frame update
    void Start()
    {
        frame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Mathf.Cos(frame * Mathf.PI), Mathf.Sin(frame * Mathf.PI), 0.0f);
        frame += 0.01f;
    }
}
