using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector2 newPos = Vector2.zero;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    public FadeScene fade;

    private void Start()
    {
        fade = GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>();
    }

    public void StartFade()
    {
        fade.Fade(newPos);
        fade.minX= minX;
        fade.minY= minY;
        fade.maxX= maxX;
        fade.maxY= maxY;
    }
}
