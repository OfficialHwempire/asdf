using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DataConvention :SingletonBehaviour<DataConvention>
{
    [SerializeField]
    Player.PlayerModel _playerInstance;


    public Player.PlayerModel PlayerInstance => _playerInstance;
    public void setPlayer(Player.PlayerModel player)
    {
        _playerInstance = player;
        return;
    }



}