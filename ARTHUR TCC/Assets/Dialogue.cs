using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI text;
    public List<string> lines;
    public GameObject panel;
    public float textSpeed;
    public int currentLine = 0;
    public int index;
    public bool active;

    void Start()
    {
        panel.gameObject.SetActive(false);
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.E))
        {
            if(text.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                text.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        if (!active)
        {
            index = 0;
            StartCoroutine(TypeLine());
            active = true;
        }
    }

    void NextLine()
    {
        if(index < lines.Count -1)
        {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            ClearLines();
        }
    }

    void ClearLine()
    {
        active = false;
        index = 0;
        text.text = "";
        panel.gameObject.SetActive(false);
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void ClearLines()
    {
        active = false;
        index = 0;
        text.text = "";
        panel.gameObject.SetActive(false);
    }
}
