using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
  public class PlayerModel
    { 
    // Start is called before the first frame update
    private string playerName;
    private GameObject playerObject = null;
    private int playerIndex=0;


    public PlayerModel(  string _playerName)
        {
            this.playerName = _playerName;
        }

    }

}
