using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour {
    public TextMesh Text;
    public ParticleSystem SparksParticles;
    private List<string> TextToDisplay = new List<string>(3);
    private float TimeToNextText;
    private int CurrentText;

    string playerName = "Frank";
    void Start()
    {
        Debug.Log("Hello: " + gameObject.name + playerName);
    }

    // Start is called before the first frame update
//    void Start() {
//        TimeToNextText = 0.0f;
//        CurrentText = 0;
//        TextToDisplay.Add("Hello!");
//        TextToDisplay.Add("Congratulation");
//        TextToDisplay.Add("All Errors Fixed");
//        SparksParticles.Play();
//    }

    // Update is called once per frame
    void Update() {
        TimeToNextText += Time.deltaTime;

        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;

            if (CurrentText >= TextToDisplay.Count)
            {
                CurrentText = 0;
            }
            Text.text = TextToDisplay[CurrentText];
            CurrentText++;
        }
        if (true && !false) { Debug.Log("Success"); }
        if (true || false) { Debug.Log("Success"); }
        if (true && !true) { Debug.Log("Success"); }
        if (false || !true) { Debug.Log("Success"); }

        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        foreach (string item in strings)
        {
            print (item);
        }

        List<GameObject> objectList = new List<GameObject>();
        GameObject[] objectArray = new GameObject[];
        Dictionary<string, GameObject> objectDict = new Dictionary<string, GameObject>();
        bool isTrue = true;
    }
}