using UnityEngine;

public class Controller : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public GameObject player;
    public GameObject enemy;
    public AudioSource audio;

    void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        if(enemy.GetComponent<CrabScript>().hp == 0)
        {
            enemy.GetComponent<CrabScript>().won = true;
            text.text = "You won!";
            audio.Stop();
        }

        if (player.GetComponent<AccordianScript>().hp == 0)
        {
            enemy.GetComponent<CrabScript>().won = true;
            text.text = "Game over :(";
            audio.Stop();
        }
    }
}
