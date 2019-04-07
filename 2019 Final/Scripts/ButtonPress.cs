using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
    //public varaibles
    [Header ("Basic Code Setup")]
    public int currentDoorCode = 0;
    [Header ("Door Codes")]
    public List<int> DoorCodes;
    [Header("Keypad Reset Timer")]
    public float delay;
    [Header("Code Entered")]
    public Text codeDisplay;
    private string codeString;
    public GameObject mainDoor;

    //Public property for the code string
    public string Code
    {
        //If needed returns the code string
        get { return codeString; }
        set
        {
            //set the codeString
            codeString = value;
            codeDisplay.text = Code;
        }
    }

    //private variables
    private int myCode = 0;

    //Scriptable object setup
    //Enum of Codes Available
    public enum Codes
    { DoorCode1, DoorCode2, DoorCode3, DoorCode4};
    //Current code selected
    [Header("Code Index")]
    public Codes codes = Codes.DoorCode1;
    //Array for scriptable object code index
    public CodeIndex[] codeIndex;

    //Runs on start of program
    private void Start()
    {
        //Set display on start
        codeDisplay.text = Code;
    }

    //Function to check codes
    private void CompareCodesBasic()
    {
        //Compare both code strings
        if (myCode == DoorCodes[currentDoorCode])
        {
            //If correct display
            Debug.Log("Correct Code!!!");
            //clear the code string entered
            Code = "Correct";

            //Cursor.visible = false;
            //Do Stuff
            //turn keypad off
            //unlock or set door inactive
            //play music tones
            //whatever the heck you want
        }
        else
        {
            //If incorrect display
            Debug.Log("Incorrect Code!!!");
            //clear the code string entered
            Code = "Incorrect";
            //Start timer to reset display
            StartCoroutine(keypadResetTimer(delay));
        }
    }

    //Function to check codes using scriptable object
    private void CompareCodesAdvanced()
    {
        //Compare both code strings
        if (myCode == codeIndex[(int)codes].DoorCode)
        {
            //If correct display
            Debug.Log("Correct Code!!!");
            Code = "Correct";
            Debug.Log("Calling Animation");
            mainDoor.GetComponent<DoorOpen_KeypadA>().Animation();
            //Cursor.visible = false;
            //DoorOpen_KeypadA.interfaceOff = true;
            //Do Stuff
            //turn keypad off
            //unlock or set door inactive
            //play music tones
            //whatever the heck you want
        }
        else
        {
            //If incorrect display
            Debug.Log("Incorrect Code!!!");
            Code = "Incorrect";
            //Start timer to clear display
            StartCoroutine(keypadResetTimer(delay));
        }
    }

    //Coroutine timer until display cleared
    IEnumerator keypadResetTimer(float delay)
    {
        //Wait delayed time
        yield return new WaitForSeconds(delay);
        //Clear display
        Code = "";
    }

    //UI button On-Click function for ENTER
    public void Enter()
    {
        //Converts the code string property to an int
        myCode = int.Parse(Code);

        //Run CompareCodesBasic function
        CompareCodesBasic();

        ////Run CompareCodesAdvanced function
        //CompareCodesAdvanced();
    }
    //UI button On-Click function for 1
    public void AddNumber1()
    {
        //set Local varaible 
        string buttonNumber = "1";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 2
    public void AddNumber2()
    {
        //set Local varaible 
        string buttonNumber = "2";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 3
    public void AddNumber3()
    {
        //set Local varaible 
        string buttonNumber = "3";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 4
    public void AddNumber4()
    {
        //set Local varaible 
        string buttonNumber = "4";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 5
    public void AddNumber5()
    {
        //set Local varaible 
        string buttonNumber = "5";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 6
    public void AddNumber6()
    {
        //set Local varaible 
        string buttonNumber = "6";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 7
    public void AddNumber7()
    {
        //set Local varaible 
        string buttonNumber = "7";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 8
    public void AddNumber8()
    {
        //set Local varaible 
        string buttonNumber = "8";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 9
    public void AddNumber9()
    {
        //set Local varaible 
        string buttonNumber = "9";
        Code += buttonNumber;//Add to string
    }
    //UI button On-Click function for 0
    public void AddNumber0()
    {
        //set Local varaible 
        string buttonNumber = "0";
        Code += buttonNumber; //Add to string
    }
}
