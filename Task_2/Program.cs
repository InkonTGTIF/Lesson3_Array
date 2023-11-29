int [] CreateArray(int minNum, int maxNum, int size){

    int [] array = new int [size];
    for(int i = 0; i<size; i++){
        array[i] = new Random().Next(minNum, maxNum+1);
    }
    return array;
}

void ShowArray(int [] array){
    int number = 0;
    for(int i = 0; i<array.Length;i++){
        if (array[i]%2==0)
        number++;
        Console.Write(array[i] + " ");
        }
    Console.WriteLine($"=> " + number);
}

int minNum = 1;
int maxNum = 20;
int size = 10;

int [] array = CreateArray(minNum, maxNum, size);

ShowArray(array);