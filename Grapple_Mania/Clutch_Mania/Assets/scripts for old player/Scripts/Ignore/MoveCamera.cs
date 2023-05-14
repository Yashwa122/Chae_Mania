using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MoveCamera : MonoBehaviourPunCallbacks
{
    public Transform cameraPosition;
    public PhotonView view;

    private void Update()
    {
        if (!view.IsMine)
            return;
        transform.position = cameraPosition.position;
    }
}
