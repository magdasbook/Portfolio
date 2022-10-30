#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;
int a=0;

int main()
{
    cout << "Maszyna losujaca liczby do totka" << endl;
    srand(time(NULL));
    while(a<6)
    {
        cout<<"Wylosowana liczba: "<< rand() % 49 + 1<<endl;
        a++;
    }
    cout<<"Oto wylosowane liczby!"<<endl;
    return 0;
}
