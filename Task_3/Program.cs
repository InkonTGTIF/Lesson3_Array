double [] CreateArray(int minNum, int maxNum, int size){

    double [] array = new double [size];
    for(int i = 0; i<size; i++){
        array[i] = Math.Round(new Random().NextDouble() * (maxNum - minNum) + minNum, 2);
    }
    return array;
}

void ShowArray(double [] array){
    double minValue = array[0];
    double maxValue = array[0];
    double diff = 0;
    for(int i = 0; i<array.Length;i++){
        if (array[i]>maxValue){
            maxValue = array[i];
        }
        else if (array[i]<minValue){
            minValue = array[i];
        }
        Console.Write(array[i] + " ");
    }
    diff = maxValue-minValue;
    Console.WriteLine($"=> " + diff);
}

int minNum = 1;
int maxNum = 10;
int size = 10;

double [] array = CreateArray(minNum, maxNum, size);

ShowArray(array);