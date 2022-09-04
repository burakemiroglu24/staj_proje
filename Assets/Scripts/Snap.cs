using UnityEngine;

public class Snap : MonoBehaviour
{
    [SerializeField] private Vector3 gridSize = default;
    private void Update()
    {
        snapToGrid2();
    }
    private void OnDrawGizmos()
    {
        if(!Application.isPlaying && this.transform.hasChanged)
        {
            snapToGrid2();
        }
    }
    private void snapToGrid2()
    {
        var position = new Vector3(
        Mathf.Round(this.transform.position.x / this.gridSize.x) * (this.gridSize.x),
        Mathf.Round(this.transform.position.y / this.gridSize.y) * (this.gridSize.y),
        Mathf.Round(this.transform.position.z / this.gridSize.z) * (this.gridSize.z));
        this.transform.position = position;
    }
}
