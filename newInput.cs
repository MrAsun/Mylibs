using System.Collections.Generic;
using UnityEngine;


/*
    Небольшой модуль для облегчения системы ввода

    Работает также как система ввода от Unity, но для удобство 
     все обьединено в 1 класс 

    На данный момент поддерживает 
        - клавиши клавиатуры
        - кнопки мыши
*/


public enum NewKeys
{
    // Буквы
    Q, W, E, R, T, Y, U, I, O, P, A, S, D, F, G, H, J, K, L, Z, X, C, V, B, N, M,


    // Цифры
    Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num0,

    
    // Другие клавиши
    Space, LeftAlt, RightAlt, LeftControl, RightControl, LeftShift, RightShift, Escape, 
    Del, Tab, CapsLock,

    //
    F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12,


    // Кнопки мыши
    RightMouseButton, LeftMouseButton, MiddleMouseButton,

    //
    MouseWheel, MouseWheelUp, MouseWheelDown,
}



public static class NewInput 
{
    // ПОдключение к клавишам
    private static Dictionary<NewKeys, KeyCode> KeyCodes = new Dictionary<NewKeys, KeyCode>() 
        {
        // Буквы
        {NewKeys.Q, KeyCode.Q}, {NewKeys.W, KeyCode.W}, {NewKeys.E, KeyCode.E}, {NewKeys.R, KeyCode.R}, {NewKeys.T, KeyCode.T},
        {NewKeys.Y, KeyCode.Y}, {NewKeys.U, KeyCode.U}, {NewKeys.I, KeyCode.I}, {NewKeys.O, KeyCode.O}, {NewKeys.P, KeyCode.P},
        {NewKeys.A, KeyCode.A}, {NewKeys.S, KeyCode.S}, {NewKeys.D, KeyCode.D}, {NewKeys.F, KeyCode.F}, {NewKeys.G, KeyCode.G},
        {NewKeys.H, KeyCode.H}, {NewKeys.J, KeyCode.J}, {NewKeys.K, KeyCode.K}, {NewKeys.L, KeyCode.L}, {NewKeys.Z, KeyCode.Z},
        {NewKeys.X, KeyCode.X}, {NewKeys.C, KeyCode.C}, {NewKeys.V, KeyCode.V}, {NewKeys.B, KeyCode.B}, {NewKeys.N, KeyCode.N},
        {NewKeys.M, KeyCode.M},
        // Цифры
        {NewKeys.Num0, KeyCode.Alpha0}, {NewKeys.Num1, KeyCode.Alpha1}, {NewKeys.Num2, KeyCode.Alpha2}, {NewKeys.Num3, KeyCode.Alpha3}, {NewKeys.Num4, KeyCode.Alpha4},
        {NewKeys.Num5, KeyCode.Alpha5}, {NewKeys.Num6, KeyCode.Alpha6}, {NewKeys.Num7, KeyCode.Alpha7}, {NewKeys.Num8, KeyCode.Alpha8}, {NewKeys.Num9, KeyCode.Alpha9},
        //
        {NewKeys.Space, KeyCode.Space},
        {NewKeys.LeftAlt, KeyCode.LeftAlt},{NewKeys.RightAlt, KeyCode.RightAlt},
        {NewKeys.LeftControl, KeyCode.LeftControl}, {NewKeys.RightControl, KeyCode.RightControl}, 
        {NewKeys.LeftShift, KeyCode.LeftShift}, {NewKeys.RightShift, KeyCode.RightShift},

        //
        {NewKeys.F1, KeyCode.F1}, {NewKeys.F2, KeyCode.F2}, {NewKeys.F3, KeyCode.F3}, {NewKeys.F4, KeyCode.F4}, {NewKeys.F5, KeyCode.F5},
        {NewKeys.F6, KeyCode.F6}, {NewKeys.F7, KeyCode.F7}, {NewKeys.F8, KeyCode.F8}, {NewKeys.F9, KeyCode.F9}, {NewKeys.F10, KeyCode.F10},
        {NewKeys.F11, KeyCode.F11}, {NewKeys.F12, KeyCode.F12},
        };


    // Подключение к мыши
    private static Dictionary<NewKeys, int> MouseButtons = new Dictionary<NewKeys, int>()
        {
        // Кнопки мыши
        {NewKeys.LeftMouseButton, 0}, {NewKeys.RightMouseButton, 1},{NewKeys.MiddleMouseButton, 2},
        };

    //
    


    // Проверка, нажата ли клавиша
    public static bool NewGetKey(NewKeys key)
    {
        // Клавиатура
        if (KeyCodes.TryGetValue(key, out var keyCode)) return Input.GetKey(keyCode);

        // Мышь
        if (MouseButtons.TryGetValue(key, out var button)) return Input.GetMouseButton(button);

        //
        if (key == NewKeys.MouseWheel) return (Input.GetAxisRaw("Mouse ScrollWheel") != 0);
        if (key == NewKeys.MouseWheelUp) return (Input.GetAxisRaw("Mouse ScrollWheel") > 0);
        if (key == NewKeys.MouseWheelDown) return (Input.GetAxisRaw("Mouse ScrollWheel") < 0);

        // Иное
        return false;
    }


    //
    public static bool NewGetKeyUp(NewKeys key)
    {
        // Клавиатура
        if (KeyCodes.TryGetValue(key, out var keyCode)) return Input.GetKeyUp(keyCode);

        // Мышь
        if (MouseButtons.TryGetValue(key, out var button)) return Input.GetMouseButtonUp(button);

        // Иное
        return false;
    }


    //
    public static bool NewGetKeyDown(NewKeys key)
    {
        // Клавиатура
        if (KeyCodes.TryGetValue(key, out var keyCode)) return Input.GetKeyDown(keyCode);

        // Мышь
        if (MouseButtons.TryGetValue(key, out var button)) return Input.GetMouseButtonDown(button);

        // Иное
        return false;
    }






    // Получение оси
    public static int NewGetAxis(NewKeys KeyForMin, NewKeys KeyForMax) 
    {
        // Значение
        int value = 0;


        // Проверка на то, нажата ли какая-либо клавиша
        if (NewGetKey(KeyForMin)) value = -1;
        if (NewGetKey(KeyForMax)) value = 1;


        // возврат значения
        return value;
    }
}

