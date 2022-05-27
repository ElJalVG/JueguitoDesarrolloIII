using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkLogin : MonoBehaviourPunCallbacks
{
    public static NetworkLogin instance;
    void Awake() {
     instance=this;
     DontDestroyOnLoad(gameObject);
     //Que no destruya este script   
    }

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();//estableciendo al servidor Photon
    }
    public override void OnConnectedToMaster() {
        PhotonNetwork.JoinLobby();//Conectamos al espacio de juego
        Debug.Log("Conexion Exitosa");
    }
    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Sala",new RoomOptions{MaxPlayers = 4},TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Player",new Vector2 (Random.Range(-18.53f, -8.06f),9.08f),Quaternion.identity);
    }
}
