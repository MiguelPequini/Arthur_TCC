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
    //Os golfinhos, delfins, peixes-botos, botos ou toninhas são animais cetáceos pertencentes ao grupo dos odontocetos, que possui 10 famílias, como Delphinidae e Platanistidae. São perfeitamente adaptados para viver no ambiente aquático, sendo que existem 77 espécies conhecidas de golfinhos de água salgada e água doce.[1] A espécie mais famosa é a Delphinus delphis. É importante notar que odontocetos e golfinhos são sinônimos. Por isso, apesar de haver uma página chamada Odontocetos e outra chamada Golfinhos (esta página aqui), ambas tratam dos exatos mesmos animais.
}
