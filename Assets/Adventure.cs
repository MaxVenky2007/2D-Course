using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(weekDays[2]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
