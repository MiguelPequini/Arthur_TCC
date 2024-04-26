using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject dialogue_area;
    public GameObject dialogue;
    public List<string> npc_lines;
    void Update()
    {
        if (!dialogue_area.GetComponent<Interact>().inRange)
        {
            dialogue.GetComponent<Dialogue>().ClearLines();
        }
    }

    public void StartMyDialogue()
    {
        dialogue.GetComponent<Dialogue>().lines = npc_lines;
        dialogue.GetComponent<Dialogue>().StartDialogue();
    }
    //Os golfinhos, delfins, peixes-botos, botos ou toninhas s�o animais cet�ceos pertencentes ao grupo dos odontocetos, que possui 10 fam�lias, como Delphinidae e Platanistidae. S�o perfeitamente adaptados para viver no ambiente aqu�tico, sendo que existem 77 esp�cies conhecidas de golfinhos de �gua salgada e �gua doce.[1] A esp�cie mais famosa � a Delphinus delphis. � importante notar que odontocetos e golfinhos s�o sin�nimos. Por isso, apesar de haver uma p�gina chamada Odontocetos e outra chamada Golfinhos (esta p�gina aqui), ambas tratam dos exatos mesmos animais.
}
