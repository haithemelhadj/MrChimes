using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CardRotater : MonoBehaviour
{
    public float rotationSpeed;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(FlipCard(rotationSpeed));
        }
    }
    private IEnumerator FlipCard(float speed)
    {
        float numberOfTimes = 180 / (speed * Time.fixedDeltaTime);
        int timesDone = 0;
        while (timesDone < numberOfTimes)
        {
            timesDone += 1;
            transform.RotateAround(transform.position, Vector3.up, speed * Time.fixedDeltaTime);
            yield return new WaitForFixedUpdate();
        }
    }
}
