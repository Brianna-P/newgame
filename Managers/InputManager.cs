using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace newgame.Core;

    public static class InputManager
    {
        private static KeyboardState _currentKeyboardState;
        private static KeyboardState _previousKeyboardState;

        private static MouseState _currentMouseState;
        private static MouseState _previousMouseState;

        public static void Update()
        {
            _previousKeyboardState = _currentKeyboardState;
            _currentKeyboardState = Keyboard.GetState();

            _previousMouseState = _currentMouseState;
            _currentMouseState = Mouse.GetState();
        }

        // Keyboard helpers
        public static bool IsKeyPressed(Keys key) => 
            _currentKeyboardState.IsKeyDown(key) && !_previousKeyboardState.IsKeyDown(key);

        public static bool IsKeyReleased(Keys key) => 
            !_currentKeyboardState.IsKeyDown(key) && _previousKeyboardState.IsKeyDown(key);

        public static bool IsKeyDown(Keys key) => _currentKeyboardState.IsKeyDown(key);

        // Mouse helpers
        public static bool IsLeftClick() =>
            _currentMouseState.LeftButton == ButtonState.Pressed && _previousMouseState.LeftButton == ButtonState.Released;

        public static bool IsRightClick() =>
            _currentMouseState.RightButton == ButtonState.Pressed && _previousMouseState.RightButton == ButtonState.Released;

        public static Point GetMousePosition() => _currentMouseState.Position;
    }

