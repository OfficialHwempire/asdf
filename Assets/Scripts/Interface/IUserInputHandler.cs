using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;
public class IUserInputHandler : MonoBehaviour
{
    // Start is called before the first frame update
    interface IUserInput
    {
       
        PlayerModel PlayerSet(string inputname);
        void LobbySelect(Player player);

    }
}
