using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Player;


    // Start is called before the first frame update
    class userInputHandler : IUserInputHandler
    {
       public PlayerModel PlayerSet(string playerName)
    {
        PlayerModel playerInstance = new PlayerModel(playerName);
        return playerInstance;
    }
       public void GoLobby(PlayerModel player)
    {
        DataConvention.Instance.setPlayer(player);
    }
    }

