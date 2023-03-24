﻿using System;
using Mirror;
using Network;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Player
{
    public class LobbyMenu : NetworkBehaviour
    {
        [Header("UI Buttons")]
        [SerializeField] private Button disconnectButton;

        // [Header("Player")]
        // [SerializeField] private GameObject playerListCanva;

        private RoomManager roomManager;

        #region Trigger

        #region Add/Remove Trigger

        private void AddListener()
        {
            disconnectButton.onClick.AddListener(OnDisconnectButton);
        }
        private void RemoveListener()
        {
            disconnectButton.onClick.RemoveAllListeners();
        }

        #endregion

        private void OnDisconnectButton()
        {
            if (isClientOnly)
            {
                roomManager.StopClient();
            } else {
                roomManager.StopHost();
            }
        }

        #endregion

        private void Start()
        {
            roomManager = (RoomManager)NetworkManager.singleton;
        }

        private void OnEnable()
        {
            AddListener();
        }
        private void OnDisable()
        {
            RemoveListener();
        }

        private void OnDestroy()
        {
            RemoveListener();
        }

        // private void AddPlayer(GameObject playerRoom)
        // {
        //     playerRoom.transform.SetParent(playerListCanva.transform);
        // }
    }
}