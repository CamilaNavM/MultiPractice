using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class CreateAndJoinRooms : MonoBehaviour
{
    public InputField createInput;
    public InputField joinInput;

    public void CreateRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
