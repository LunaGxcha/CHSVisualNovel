using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : monoBehaviour {
[SerializeField] private Transform gameTransform;
[SerializeField] private Transform piecePrefab;

private int emptyLocation;
private int size;

// create the game setup with size x size pieces
private void CreateGamePieces(float gapThickness) {
// this is the width of each file
float width = 1 / (float)size;
for(int row = 0; row < size; row++) {
    for (int col = 0; col < size; col ++) {
        Transform piece = Instantiate(piecePrefab, gameTransform);
        // pieces will be in a game bord going from -1 to +1
        piece.localPosition = new Vector2(-1 + (2 * width * col) + width, +1 - (2 * width * row) - width);
        piece.localScale = ((2 * width) - gapThickness) * Vector2.one;
        piece.name = $"{(row * size) + col}";
        // we want an empty space in the bottom right
        if ((row == size -1) && (col == size - 1)) {
            emptyLocation = (size * size) - 1;
            piece.gameObject.SetActive(false);
        }else {
        // we want to map the UV coordinates appropriately, they are 0->1
        float gap = gapThickness / 2;
        Mesh mesh = piece.GetComponent<MeshFilter>().mesh;
        Vector[] uv = new Vector2[4];
        // UV coord order: (0,1) (1,1) (0,0) (1,0)
        uv[0] = new Vector2((width * col) + gap, 1 - ((width *(row + 1))- gap));
        uv[1] = new Vector2((width*(col + 1)) - gap, 1 - ((width * (row + 1)) - gap));
        uv[2] = new Vector2((width * col) + gap, 1 - ((width * row) + gap));
        uv[3] = new Vector2((width * (col + 1)) - gap, 1 - ((width * row) + gap));
        }
    }
}

}



// start is called before the first frame update
void Start() {
    size = 3;
    CreateGamePieces(0.01f);
    
}

}
