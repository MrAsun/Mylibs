#pragma once

#include <iostream>
#include <map>
#include <conio.h> 

namespace Input {


    // Проверка на то, нажата ли клавиша
    bool GetKey(char Key) {

        // Проверка на то, нажата ли какая-либо клавиша
        if (_kbhit()) {

            // Возвращаем значение клавиши
            return (_getch() == Key);
        }
        return false;
    }

    // Проверка на то, нажата ли клавиша с определенным кодом
    bool GetCode(int Key) {

        // Проверка на то, нажата ли какая-либо клавиша
        if (_kbhit()) {

            // Возвращаем значение клавиши
            return (_getch() == Key);
        }
        return false;
    }
}
