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
        Debug.Log("Conexion Exitosa");
    }
}
