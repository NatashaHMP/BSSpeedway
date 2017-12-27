using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Constants : MonoBehaviour {

    public sealed class SceneName
    {
        public const string MAIN_MENU = "MainMenu";
        public const string SELECT_LVL = "SelectLvl";
        public const string LVL = "Lvl";
        //public const string CREDITS = "Credits";
    }

    public sealed class TagName
    {
        public const string FLOOR = "Floor";
        public const string PLAYER = "Player";
        //public const string BUTTON_START = "ButtonStart";
        public const string STAR = "Star";
    }

    public sealed class ObjectName
    {
       /* public const string CAMERA = "MainCamera";
        public const string PLAYER = "Player";*/
    }

    public sealed class Code
    {
        public const string TEXT_RESET = "reset";
        public const string TEXT_CODE = "code";
        public const string TEXT_GAME_STATS = "gameStats";
        public const string TEXT_CODE_INCORRECT = "Codigo incorreto";
        public const string TEXT_MESSAGE_RESET = "RESET - ESTADO: ";
        public const int NUMBER_TO_LOCK_PLAY_BUTTON = 0;
        public const int NUMBER_TO_UNLOCK_PLAY_BUTTON = 1;
    }

    public sealed class LevelSave
    {
        public const int NUMBER_UNLOCK_LEVEL = 1;
        public const int NUMBER_LOCK_LEVEL = 0;
        public const int INDEX_LEVEL_ONE = 0;
        public const int NUMBER_MAX_LEVELS = 10;
        public const string TEXT_LEVELS_KEY = "Levels ";
    }

    public sealed class CameraProperties
    {
       /* public const float MAX_X = 100f;
        public const float MIN_X = 0f;
        public const float CAMERA_POSITION_Y = 0;*/
    }
}
