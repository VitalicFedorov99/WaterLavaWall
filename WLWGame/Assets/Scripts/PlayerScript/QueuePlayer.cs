using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UIScripts;
namespace PlayerScripts
{
    public class QueuePlayer : MonoBehaviour
    {
        [SerializeField] private Player _player1;
        [SerializeField] private Player _player2;

        [SerializeField] private RenderActivPlayer _renderActivPlayer;
        Queue<Player> _queuePlayers=new Queue<Player>();


        
        private void Start()
        {
            SetupQueue();
            _renderActivPlayer=GetComponent<RenderActivPlayer>();
        }
        public void SetupQueue()
        {
            _queuePlayers.Enqueue(_player1);
            _queuePlayers.Enqueue(_player2);
        }

        public void UpdateQueuePlayer()
        {
            Player player=_queuePlayers.Dequeue();
            Debug.Log(player.name);
            _queuePlayers.Enqueue(player);
            _renderActivPlayer.OnImage(checkNumberPlayer(player));
        }

        private int checkNumberPlayer(Player player)
        {
            if(player ==_player1)
            return 0;
            else return 1;
        }

    }
}
