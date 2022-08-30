using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{

    [SerializeField] private Transform cam;
    [SerializeField] private float matchCamXMovement = 0.0f;
    [SerializeField] private float matchCamYMovement = 0.0f;
    [SerializeField] private Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate() {
        transform.position = new Vector2(cam.position.x * matchCamXMovement, cam.position.y * matchCamYMovement) + offset;
    }
}
