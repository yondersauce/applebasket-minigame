using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class HarvestSimulation : MonoBehaviour
{

    public int applesCollected;
    public int appleMax = 150;

    public AudioSource successSound;
    public AudioSource failureSound;


    public string pressedKey;

    public int selectedAppleIndex;

    public List<string> keys;
    public List<string> ripeAppleKeys;

    public List<GameObject> Apples;

    public int framecount;
    public int appleSpawnRate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        StorePressedKeyCharacter();

        HarvestApple();

        if (framecount % appleSpawnRate == 0) { 
        
        }

        framecount++;
    }

    public bool IsAppleRipe(string x) {
        //check if pressed key is in ripe apple list of keys and store index for later use when removing the key from the list
        selectedAppleIndex = ripeAppleKeys.IndexOf(x);
        return ripeAppleKeys.Contains(x);

    }

    public void HarvestApple() {

        //remove key from ripe apple list of keys if exists
        //remove apple from tree
        if (IsAppleRipe(pressedKey)) {

            ripeAppleKeys.RemoveAt(selectedAppleIndex);
            successSound.Play();
        }

    }

    public void StorePressedKeyCharacter() {
        if (Input.GetKeyDown(KeyCode.A))
        {

            pressedKey = "a";
        }

        if (Input.GetKeyDown(KeyCode.B))
        {

            pressedKey = "b";
        }

        if (Input.GetKeyDown(KeyCode.C))
        {

            pressedKey = "c";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            pressedKey = "d";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

            pressedKey = "e";
        }
        if (Input.GetKeyDown(KeyCode.F))
        {

            pressedKey = "f";
        }
        if (Input.GetKeyDown(KeyCode.G))
        {

            pressedKey = "G";
        }
        if (Input.GetKeyDown(KeyCode.H))
        {

            pressedKey = "h";
        }
        if (Input.GetKeyDown(KeyCode.I))
        {

            pressedKey = "i";
        }
        if (Input.GetKeyDown(KeyCode.J))
        {

            pressedKey = "j";
        }
        if (Input.GetKeyDown(KeyCode.K))
        {

            pressedKey = "k";
        }
        if (Input.GetKeyDown(KeyCode.L))
        {

            pressedKey = "l";
        }
        if (Input.GetKeyDown(KeyCode.M))
        {

            pressedKey = "m";
        }
        if (Input.GetKeyDown(KeyCode.N))
        {

            pressedKey = "n";
        }
        if (Input.GetKeyDown(KeyCode.O))
        {

            pressedKey = "o";
        }
        if (Input.GetKeyDown(KeyCode.P))
        {

            pressedKey = "p";
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            pressedKey = "q";
        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            pressedKey = "r";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            pressedKey = "s";
        }
        if (Input.GetKeyDown(KeyCode.T))
        {

            pressedKey = "t";
        }
        if (Input.GetKeyDown(KeyCode.U))
        {

            pressedKey = "u";
        }
        if (Input.GetKeyDown(KeyCode.V))
        {

            pressedKey = "v";
        }
        if (Input.GetKeyDown(KeyCode.X))
        {

            pressedKey = "x";
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {

            pressedKey = "y";
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {

            pressedKey = "z";
        }
    }
}
