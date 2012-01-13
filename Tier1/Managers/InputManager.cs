using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML;
using SFML.Graphics;
using SFML.Window;

namespace AdventureGame.Tier1.Managers
{
    /// <summary>
    /// This is riped from the SFML Source
    /// </summary>
    public enum Keys
    {
        Num0 = 48,
        Num1 = 49,
        Num2 = 50,
        Num3 = 51,
        Num4 = 52,
        Num5 = 53,
        Num6 = 54,
        Num7 = 55,
        Num8 = 56,
        Num9 = 57,
        A = 97,
        B = 98,
        C = 99,
        D = 100,
        E = 101,
        F = 102,
        G = 103,
        H = 104,
        I = 105,
        J = 106,
        K = 107,
        L = 108,
        M = 109,
        N = 110,
        O = 111,
        P = 112,
        Q = 113,
        R = 114,
        S = 115,
        T = 116,
        U = 117,
        V = 118,
        W = 119,
        X = 120,
        Y = 121,
        Z = 122,
        Escape = 256,
        LControl = 257,
        LShift = 258,
        LAlt = 259,
        LSystem = 260,
        RControl = 261,
        RShift = 262,
        RAlt = 263,
        RSystem = 264,
        Menu = 265,
        LBracket = 266,
        RBracket = 267,
        SemiColon = 268,
        Comma = 269,
        Period = 270,
        Quote = 271,
        Slash = 272,
        BackSlash = 273,
        Tilde = 274,
        Equal = 275,
        Dash = 276,
        Space = 277,
        Return = 278,
        Back = 279,
        Tab = 280,
        PageUp = 281,
        PageDown = 282,
        End = 283,
        Home = 284,
        Insert = 285,
        Delete = 286,
        Add = 287,
        Subtract = 288,
        Multiply = 289,
        Divide = 290,
        Left = 291,
        Right = 292,
        Up = 293,
        Down = 294,
        Numpad0 = 295,
        Numpad1 = 296,
        Numpad2 = 297,
        Numpad3 = 298,
        Numpad4 = 299,
        Numpad5 = 300,
        Numpad6 = 301,
        Numpad7 = 302,
        Numpad8 = 303,
        Numpad9 = 304,
        F1 = 305,
        F2 = 306,
        F3 = 307,
        F4 = 308,
        F5 = 309,
        F6 = 310,
        F7 = 311,
        F8 = 312,
        F9 = 313,
        F10 = 314,
        F11 = 315,
        F12 = 316,
        F13 = 317,
        F14 = 318,
        F15 = 319,
        Pause = 320,
    }

    public static class InputManager
    {
        public static List<Keys> KeysPressed = new List<Keys>();

        internal static void NewFrame()
        {
            KeysPressed.Clear();
        }

        internal static void KeyPress(KeyCode item)
        {
            KeysPressed.Add((Keys)item);
        }

        public static bool IsKeyPressed(Keys key)
        {
            return KeysPressed.Contains(key);
        }

    }
}
