using System;
using UnityEngine;
using UnityEngine.UI;
namespace spaceExplorer.Player
{
    public class PlayerVisual : MonoBehaviour
    {
        private SpriteRenderer playerRenderer;
        [SerializeField] private Sprite[] skins; // Assign in the inspector
        public int selectedSkinIndex = 0;

        void Start()
        {
            // Load saved skin
            //selectedSkinIndex = PlayerPrefs.GetInt("SelectedSkin", 0);
            playerRenderer = GetComponent<SpriteRenderer>();
            ApplySkin();
            transform.localScale = new Vector3(3f, 3f, 1f);
        }

        public void ChangeSkin(int index)
        {
            if (index >= 0 && index < skins.Length)
            {
                selectedSkinIndex = index;
                ApplySkin();
                PlayerPrefs.SetInt("SelectedSkin", selectedSkinIndex);
                PlayerPrefs.Save();
            }
        }

        void ApplySkin()
        {
            playerRenderer.sprite = skins[selectedSkinIndex];
        }
    }
}

