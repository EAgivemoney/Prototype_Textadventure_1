using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public enum States
    {
        FrogPond,
        ChoiceGoodOrEvil,
        HeroBase,
        VillainBase,
        Forest,
        City,
        Bandits,
        Goblins,
        SavetheCity,
        RobTheBank,
        Death,
        Victory
    }

    private States currentState;

    [SerializeField]
    private TMP_Text textArea;

    void Start()
    {
        currentState = States.FrogPond;
    }

    void Update()
    {
        if (currentState == States.FrogPond)
        {
            FrogPond();
        }
        else if (currentState == States.ChoiceGoodOrEvil)
        {
            ChoiceGoodOrEvil();
        }
        else if (currentState == States.HeroBase)
        {
            HeroBase();
        }
        else if (currentState == States.VillainBase)
        {
            VillainBase();
        }
        else if (currentState == States.Forest)
        {
            Forest();
        }
        else if (currentState == States.City)
        {
            City();
        }
        else if (currentState == States.Bandits)
        {
            Bandits();
        }
        else if (currentState == States.Goblins)
        {
            Goblins();
        }
        else if (currentState == States.SavetheCity)
        {
            SavetheCity();
        }
        else if (currentState == States.RobTheBank)
        {
            RobTheBank();
        }
        else if (currentState == States.Death)
        {
            Death();
        }
        else if (currentState == States.Victory)
        {
            Victory();
        }
    }

    private void FrogPond()
    {
        textArea.text = "You've spent 10 peaceful months in the Frog Pond, learning the ways of the world-or at least, the ways of frogs. \n" +
                        "But now, the time has come for you to leap out into the wider world. It's time to find a mate and begin your adventure! \n" +
                        "\n" +
                        "Press space to hop out of the pond and begin your journey.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.ChoiceGoodOrEvil;
        }
    }

    private void ChoiceGoodOrEvil()
    {
        textArea.text = "Unfortunately, your first venture into the world doesn't go as planned. No mates in sight... But you encounter two strange frogs! \n" +
                        "One frog is glowing with a radiant heroic aura, the other is shrouded in a mysterious, villainous shadow. \n" +
                        "Both frogs extend a slimy hand, offering to guide you down a new path. Will you choose heroism or villainy? \n" +
                        "\n" +
                        "Press H to follow the heroic frog \n" +
                        "Press V to follow the villainous frog";

        if (Input.GetKeyDown(KeyCode.H))
        {
            currentState = States.HeroBase;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            currentState = States.VillainBase;
        }
    } 

    private void HeroBase()
    {
        textArea.text = "You followed the heroic frog and trained tirelessly under his guidance. Now, you are a frog of justice, leaping into action! \n" +
                        "Your first mission awaits: will you venture into the mysterious forest or investigate strange happenings in the city? \n" +
                        "\n" +
                        "Press F to investigate the forest \n" +
                        "Press C to investigate the city \n";

        if (Input.GetKeyDown(KeyCode.F))
        {
            currentState = States.Forest;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            currentState = States.City;
        }
    }

    private void VillainBase()
    {
        textArea.text = "You chose the path of darkness, folowwing the villainous frog into his lair. He trained you in the art of chaos and destruction. \n" +
                        "Your first task is clear: will you help the bandits rob a bank or aid the goblins in seizing control of the forest? \n" +
                        "\n" +
                        "Press B to help the bandits rob the bank. \n" +
                        "Press G to assist the goblins in their forest takeover. \n";

        if (Input.GetKeyDown(KeyCode.B))
        {
            currentState = States.Bandits;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            currentState = States.Goblins;
        }
    }

    private void Forest()
    {
        textArea.text = "You hop into the thick forest, the trees towering above you. It's quiet-too quiet. As you're about to head back, a salamander with blood-red eyes leaps from the shadows! \n" +
                        "Will you survive this deadly ambush? \n" +
                        "\n" +
                        "Press space to find out your fate";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.Death;
        }
    }

    private void City()
    {
        textArea.text = "The city is bustling with activity, but something's not right. You hear a shout from the bank: bandits are trying to rob it! \n" +
                        "Now's your chance to prove yourself as the hero your frog mentor knew you could be. \n" +
                        "\n" +
                        "Press space to confront the bandits.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.SavetheCity;
        }
    }

    private void Bandits()
    {
        textArea.text = "You chose to help the bandits and arrive at the city's grand bank, ready for the biggest heist of the century. \n" +
                        "With the vault in sight, you begin the robbery, but something feels... off. \n" +
                        "\n" +
                        "Press space to continue the robbery";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.RobTheBank;
        }
    }

    private void Goblins()
    {
        textArea.text = "The goblins welcome you at first, but their loyalty is fickle. Before you know it, they're attacking you! \n" +
                        "Just as the battle reaches its peak, a salamander strikes from the shadows, targeting everyone. \n" +
                        "Will you survive, or meet a grim fate? \n" +
                        "\n" +
                        "Press space to discover what happens next.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.Death;
        }
    }

    private void SavetheCity()
    {
        textArea.text = "With heroic skill, you defeat the bandits and save the day! The citizens of the city cheer for you, and you're hailed as a true hero. \n" +
                        "Your name will go down in frog history as a legend! \n" +
                        "\n" +
                        "Press space to see your victory screen";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.Victory;
        }
    }

    private void RobTheBank()
    {
        textArea.text = "The heist was going smoothly... until the heroic frog showed up! He quickly takes down the bandits and confronts you. \n" +
                        "But instead of finishing you off, he leaves you to the authorities. Unofrtunately, frog justice is swift, and you face the ultimate penalty. \n" +
                        "\n" +
                        "Press space to end your story.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.Death;
        }
    }

    private void Death()
    {
        textArea.text = "You have met an untimely end. But don't be discouraged! Perhaps next time, you can hop towards a brighter fate. \n" +
                        "\n" +
                        "Press space to try again";
                        
       if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.FrogPond;
        }
    }

    private void Victory()
    {
        textArea.text = "Congratulations! You have saved the city and become a legend among frogs! \n" +
                        "But there are other paths to explore. Who knows what adventures await? \n" +
                        "\n" +
                        "Press space to restart and explore new possibilities.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = States.FrogPond;
        }
    }

}