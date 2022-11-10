using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class FriendObject : MonoBehaviour
{
    public SteamId steamid;

    public async void Invite()
    {
        if (SteamLobbyManager.UserInLobby)
        {
            SteamLobbyManager.currentLobby.InviteFriend(steamid);
        }
        else
        {
            bool result = await SteamLobbyManager.CreateLobby();
            if(result)
            {
                SteamLobbyManager.currentLobby.InviteFriend(steamid);
            }
        }
    }
}
