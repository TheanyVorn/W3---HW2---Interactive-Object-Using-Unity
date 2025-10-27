# Heart Collector Game 🎮❤️

A Unity 3D game where the player controls a character to collect mini hearts scattered across the scene. Once all 5 hearts are collected, the player wins!

## 📋 Game Overview

- **Objective:** Collect all 5 mini hearts to win the game
- **Platform:** Unity 3D (3D Physics)
- **Input:** WASD or Arrow Keys for movement
- **Win Condition:** Collect all 5 hearts → "❤️ Love Full! You Win! ❤️" message appears

---

## 🎯 Game Mechanics

### Player Movement
- **Script:** `BasicMove.cs`
- **Controls:**
  - `W` / `↑` = Move Forward
  - `S` / `↓` = Move Backward
  - `A` / `←` = Move Left
  - `D` / `→` = Move Right
- **Speed:** Adjustable via Inspector (default: 5)
- **Physics:** Uses 3D Rigidbody for smooth movement

### Heart Collection
- **Script:** `MiniHeart.cs`
- **Behavior:** When player touches a heart:
  1. Heart disappears (destroyed)
  2. Score increases by 1
  3. Score displayed on UI
  4. If score reaches 5 → Win message appears

---

## 🛠️ Setup Instructions

### Player GameObject Setup

1. **Create or Select Player:**
   - Name: `Player`
   - Tag: `"Player"` (must be set for collision detection)

2. **Add Components:**
   - **Script:** Attach `BasicMove.cs`
   - **Rigidbody (3D):**
     - Body Type: `Dynamic`
     - Gravity: `OFF` (uncheck "Use Gravity")
     - Freeze Rotation: X ✓, Y ✓
   - **Collider (3D):** BoxCollider or CapsuleCollider
     - Is Trigger: `UNCHECKED` ✓
     - Size: Adjust to fit your player model

3. **Inspector Settings:**
   - Move Speed: `5` (adjust as needed)

### Heart GameObject Setup

1. **Create/Import Mini Hearts:** 
   - Import 5 Mini Heart assets into the scene
   - Place them at different positions

2. **For Each Heart, Add:**
   - **Script:** Attach `MiniHeart.cs`
   - **Collider (3D):** BoxCollider or SphereCollider
     - Is Trigger: `CHECKED` ✓
     - Size: Adjust to fit the heart model
   - **DO NOT add Rigidbody to hearts**

3. **Inspector Settings (For Each Heart):**
   - **Score Text:** Drag the Score UI element here
   - **Win Text:** Drag the Win Message UI element here
   - **Goal:** `5` (or adjust for different challenge levels)

### UI Setup

1. **Create TextMeshPro UI Elements:**
   - **Score Display:**
     - Create Text element (TextMeshPro)
     - Name: `ScoreText`
     - Position: Top-left corner
     - Shows: "Score: 0"

   - **Win Message:**
     - Create Text element (TextMeshPro)
     - Name: `WinText`
     - Position: Center of screen
     - Initially empty (appears when all hearts collected)

2. **Assign to Hearts:**
   - Select each heart
   - In `MiniHeart` script Inspector:
     - Drag `ScoreText` → Score Text field
     - Drag `WinText` → Win Text field

---

## 📁 Project Structure

```
Assets/
├── Basicmove.cs           # Player movement script
├── MiniHeart.cs           # Heart collection script
├── Scenes/
│   └── GameScene.unity    # Main gameplay scene
└── TextMesh Pro/          # UI fonts and resources
```

---

## 🎮 How to Play

1. **Start the Game:** Press Play in Unity Editor
2. **Move the Player:** Use WASD or Arrow Keys
3. **Collect Hearts:** Move the player to touch each heart
   - Each heart disappears when touched
   - Score increases on UI
4. **Win Condition:** Collect all 5 hearts
   - Win message displays: "❤️ Love Full! You Win! ❤️"

---

## 📊 Scripts Reference

### BasicMove.cs
Controls player movement using 3D physics.

**Key Variables:**
- `moveSpeed` (public float): Speed of player movement (default: 5)

**Key Methods:**
- `Start()`: Initializes Rigidbody reference
- `Update()`: Reads player input (WASD/Arrow keys)
- `FixedUpdate()`: Applies physics-based movement

### MiniHeart.cs
Handles heart collection and win condition.

**Key Variables:**
- `score` (static int): Shared counter across all hearts
- `goal` (int): Number of hearts needed to win (default: 5)
- `scoreText` (TextMeshProUGUI): UI for displaying score
- `winText` (TextMeshProUGUI): UI for displaying win message

**Key Methods:**
- `OnTriggerEnter(Collider)`: Detects player collision
- `UpdateScoreText()`: Updates score display
- `ResetScore()`: Resets counter (useful for replay)

---

## ⚙️ Customization

### Adjust Difficulty
- **Change `goal`** in MiniHeart script: Collect more/fewer hearts
- **Adjust `moveSpeed`** in BasicMove script: Make player faster/slower

### Change Win Message
- Edit the text in `MiniHeart.cs`, line with `winText.text`:
  ```csharp
  winText.text = "Your Custom Message Here!";
  ```

### Add More Hearts
- Duplicate heart GameObject in scene
- Increase `goal` value accordingly
- Each heart uses same `MiniHeart.cs` script

---

## 🐛 Troubleshooting

### Hearts Don't Disappear When Touched

**Check:**
1. ✅ Player has Tag: `"Player"`
2. ✅ Heart Collider has `Is Trigger: CHECKED`
3. ✅ Player Collider has `Is Trigger: UNCHECKED`
4. ✅ Both use 3D Colliders (not 2D)
5. ✅ `MiniHeart.cs` script is attached to each heart
6. ✅ Console shows: "Star collected! Score: X" (debug log)

### Score Not Updating

**Check:**
1. ✅ `scoreText` is assigned in Inspector
2. ✅ TextMeshPro UI element exists in scene
3. ✅ `UpdateScoreText()` is called after score increment

### Win Message Not Appearing

**Check:**
1. ✅ `winText` is assigned in Inspector
2. ✅ Score reaches exactly `goal` value
3. ✅ TextMeshPro UI element exists in scene

---

## 🎨 Assets Used

- **Player Model:** (Your player asset)
- **Mini Heart Models:** (Your imported mini heart assets)
- **UI Framework:** TextMeshPro (Unity built-in)
- **Physics Engine:** Unity 3D Physics (3D Colliders & Rigidbody)

---

## 📝 Notes

- The game uses **3D physics** (Collider3D, Rigidbody3D)
- Movement is physics-based for smooth interactions
- Score is `static`, shared across all heart instances
- Resetting the level requires calling `MiniHeart.ResetScore()`

---

## ✨ Future Enhancements

- Add sound effects for collecting hearts
- Add particle effects when hearts disappear
- Implement level restart button
- Add difficulty levels (more hearts, faster enemies, etc.)
- Add timer/score multiplier
- Add smooth camera follow
- Add heart spawn animations

---

## 📧 Support

For issues or questions, check the console output (`Ctrl + Shift + C` in Unity) for debug logs.

---

**Enjoy the game! ❤️**
