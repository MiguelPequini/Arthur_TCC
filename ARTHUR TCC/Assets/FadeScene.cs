using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScene : MonoBehaviour
{
    public CameraMovement cameraMovement;
    public Animator animator;
    public Vector2 newPos;
    public GameObject player;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public void Fade(Vector2 pos)
    {
        animator.SetTrigger("Fade");
        player.GetComponent<Player>().canInteract = false;
        newPos = pos;
    }

    public void Transition()
    {
        player.transform.position = new Vector3(newPos.x, newPos.y, 0);
        player.GetComponent<Player>().canInteract = true;
        cameraMovement.minX = minX;
        cameraMovement.maxX = maxX;
        cameraMovement.minY = minY; 
        cameraMovement.maxY = maxY;
    }
}
