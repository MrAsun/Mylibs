#pragma once

#include <iostream>
#include <map>
#include <conio.h> 

#include "Time.h"


// Коды клавиш
std::map <int, char> keys_codes = {
    // Цифры
    {48, '0'}, {49, '1'}, {50, '2'}, {51, '3'}, {52, '4'},
    {53, '5'}, {54, '6'}, {55, '7'}, {56, '8'}, {57, '9'},

    //
};


// Состояние нажатия клавиш
std::map <char, bool> keys = {
    // Цифры
    {'0', false}, {'1', false}, {'2', false}, {'3', false}, {'4', false},
    {'5', false}, {'6', false}, {'7', false}, {'8', false}, {'9', false},

    //
};
namespace Input {
    //
    bool GetKey(char key) {
        return keys[key];
    }


    // Начало приема в кадре
    void InputStart(){
        // Проверка на нажатость клавиш
        if (_kbhit()) {


            // Проверка на существование  клавиши
            if (keys_codes.find(_getch()) != keys_codes.end()) {
                //
                keys[keys_codes[_getch()]] = true;
            }
        }
        
    }

    // Конец приема в кадре
    void InputEnd() {

        // Проходим по всем клавишам
        for (const auto& KeyValue : keys) 
        {
            // Получаем значение
            char key = KeyValue.first;
            bool value = KeyValue.second;

            // Обнуляем 
            if (keys[key]) keys[key] = false;
        }
    }
}
