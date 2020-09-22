using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{

    public GameObject wave;

    private Vector2 scaleChange, positionChange;
    private float waveHeight;
    private float waveWidth;

    //youtube guy variables: https://www.youtube.com/watch?v=GB5mKBALeZw&t=131s&ab_channel=RenaissanceCoders
    public Vector2 maxScale;
    Vector2 minScale;
    public float speed = 2f;
    public float duration = 6f;

    IEnumerator Start()
    {
        //use lerp function to steadily grow the size of the wave
        minScale = transform.localScale;
        yield return RepeatLerp(minScale, maxScale, duration);


        //use sprite dimensions to set a boundary that the player can move within
        waveWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x * -1;
        waveHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y * -1;


    }


    public IEnumerator RepeatLerp(Vector2 a, Vector2 b, float time)
    {
        float i = 0.0f;
        float rate = (0.05f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }
}
