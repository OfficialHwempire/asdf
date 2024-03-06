using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon;
using static ViewManager;
public class EventManager : MonoBehaviour, IEventManager
{
   
    // Start is called before the first frame update
    [SerializeField]
    GameObject userInput;

    public void OnclickStart() 
    {
        
        userInputHandler userInputHandlerInstance = new userInputHandler();
        
        userInputHandlerInstance.GoLobby(userInputHandlerInstance.PlayerSet(userInput.GetComponent<TMP_InputField>().text));
        

    }
   public  void ConnectToHost()
    {
        
    }
    public void ConnectToSearching()
    {

    }
    
}
