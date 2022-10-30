#include <iostream>

using namespace std;
string n;
int dl, s=0, a=0;

int main()
{
    cout << "Napisz tekst: ";
    getline(cin,n);
    dl=n.size()-1;
    while(n[a]==' ')
    {
        a++;
    }
    for(int i=a;i<dl;i++)
    {
        if((n[i]==' ')&&(n[i+1]!=' '))
        {
            s+=1;
        }
    }
    s+=1;
    cout<<"Liczba wyrazow to: "<<s;
    return 0;
}
