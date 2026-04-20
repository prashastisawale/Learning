// Q.2. Find Second Largest Number
// Given N numbers, find the second largest number.
// Input:
// 5
// 10 4 8 20 15
// Output:
// 15

#include<iostream>
using namespace std;
int main(){

    int arr[]= {10, 4, 8, 20, 15};
    int n = 5;

    int largest = arr[0];
    int sec_large = -1;


    for (int i = 1; i < n; i++){

        if(arr[i] > largest)
        {
        sec_large = largest;
        largest = arr[i];
        }

    else if(arr[i] > sec_large && arr[i]!= largest ){
        sec_large = arr[i];

    }
}


cout <<"second largest:"<< sec_large;
return 0;

}