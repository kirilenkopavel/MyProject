String[] array = {"Hello", "123", "start", "Git"};
String[] resultArray = new String[array.Length];

// Функция сравнивает длину строки {str} со значением {value} и возвращает логиеское значение
bool checkLenghtString(String str, int value) {
    if(str.Length >= value) {
        return true;
    }
    else {
        return false;
    }    
}

String[] checkArrayString(String[] array) {
    int counter = 0;
    for(int i = 0; i < array.Length; i++) {
        if(checkLenghtString(array[i], 3)) {
            resultArray[counter] = array[i];
            counter++;
        }
    }
    return resultArray;    
}

Console.WriteLine(checkArrayString(array));

