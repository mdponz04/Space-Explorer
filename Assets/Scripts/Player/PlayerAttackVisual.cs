using System.Collections;
using UnityEngine;
namespace spaceExplorer.Player
{
    public class PlayerAttackVisual : MonoBehaviour
    {
        private LineRenderer lineRenderer;
        private float laserDuration = 0.5f;
        [SerializeField] private Transform playerTransform;
        
        private void Start()
        {
            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.positionCount = 2;
            lineRenderer.useWorldSpace = false;

            // Set line width (adjust as needed)
            lineRenderer.startWidth = 0.2f;
            lineRenderer.endWidth = 0.1f;

            lineRenderer.enabled = false; // Hide laser at start
        }
        public void Shoot()
        {
            StartCoroutine(RenderLazer());
        }
        private IEnumerator RenderLazer()
        {
            lineRenderer.enabled = true;
            // Update line positions with the gameobject position
            lineRenderer.SetPosition(0, Vector3.zero);
            lineRenderer.SetPosition(1, Vector3.up * 20);

            yield return new WaitForSeconds(laserDuration); // wait for duration

            lineRenderer.enabled = false;
        }
    }
}
