using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UIScripts
{
    public class RenderActivPlayer : MonoBehaviour
    {
        [SerializeField] private Image[] _imgActivPlayer;


        public void OnImage(int idImage)
        {
            OffAllimage();
            _imgActivPlayer[idImage].color=Color.red;
        }
        private void OffAllimage()
        {
            foreach(Image img in _imgActivPlayer)
            {
                img.color=Color.white;
            }
        }
    }
}