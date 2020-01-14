# The idea
First, we'll need to define how the chess pieces will move on a 3D board. This file will try to describe the movesets using vectors.

**First, we need to define what a vector is our project:**

A vector is a 3-int data structure and will be represented as **(X, Y, Z)**, where:
- **X** is a change in the X dimension (Aka left and right).
- **Y** is a change in the Y dimension (Aka up and down).
- **Z** is a change in the Z dimension (Aka forward and backward).

Please note that vectors only represent a displacement in space, we will not consider the position inside the board yet, so some movesets may be illegal in certain situations.

## The pawn
The pawn is the simplest piece in 2D chess, but thinking about it in 3D dimension can be a bit tricky.

For our project, we'll consider that each player starts on opposite sides on the Y dimension.


#### Moving the pawn
In 2D chess, the pawn moves toward the enemy side, the same concept will apply in our 3D chess, the pawn can only move in the Y dimension towards the enemy side.

The first move of each pawn (if not obstructed) can be up to 2 spaces, after that, the pawn can only move 1 space, whatever it has moved 2 spaces or not in the first place.

The vectors that can represent the moveset of the pawn can be define as (0, +-1, 0) or (0, +-2, 0).

The pawn can only move it the there is no piece in it's way, otherwise the movement to that position is not possible.

#### Capturing enemy pieces with the pawn
While the pawn can not move if there is a piece in your way (either friendly or enemy), the pawn can move diagonally to eat enemy pieces towards the enemy base. The rule in 2D chess is as follows: The pawn will move 1 space forward and 1 space sideway.

The same concept will apply in our 3D chess project, the pawn can only capture enemy pieces if they are 1 space forward and 1 space sideway, but defining sideways in 3D chess is a bit more tricky, because there is one more dimension to consider, if we assume that a sideway space is a space that's perpendicular to the forward movement of the pawn, then both the X and Z dimensions need to be considered, but we also need to consider if a sideway space is only a displacement in the X or Z dimensions, or a displacement in the XZ dimension is also acceptable for the pawn moving sideway.

In our project, we will consider the latter (YUP, not only the pawn capture pieces diagonally, but it can also move diagonally in it's diagonally path, now imagine that in 4D x.x), so the vectors that represent the moveset of a pawn capturing an enemy piece can be described as: **(m, 1, n)**, where
- **m** can range between -1 and 1.
- **n** can range between -1 and 1.
- Either m or n can not be 0.

#### Conclusion
With that, the possible movements for pawn are:
- **When moving the pawn**
  - (0, +-2, 0) Only as first move of the pawn.
  - (0, +-1, 0)
- **While capturing with the pawn**
  - (-1, +-1, -1)
  - (-1, +-1, 0)
  - (-1, +-1, 1)
  - (0, +-1, -1)
  - (0, +-1, 1)
  - (1, +-1, -1)
  - (1, +-1, 0)
  - (1, +-1, 1)
  
  
  
  
  
  
  TODO: the rest of the pieces.
