using System;
using UnityEngine;
namespace spaceExplorer.UI
{
    public class InGameUI : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI pointsText;

        private void Start()
        {
            GameController.Instance.OnPointsChanged += OnPointsChanged;
        }
        private void OnPointsChanged(object sender, EventArgs e)
        {
            pointsText.text = GameController.Instance.GetPoints().ToString();
        }
    }
}

