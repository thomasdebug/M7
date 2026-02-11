using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    private float speed = 5f;
    private float rotationSpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float getVertical = Input.GetAxis("Vertical");
        speed += getVertical * 0.1f;
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        float getHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, getHorizontal);
        if(Input.GetKey(KeyCode.Space)) 
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
    }
}
