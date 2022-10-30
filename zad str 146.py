#Specyfikacja
#Dane: pkt - punkty(należy do C), f - frekwencja, so - średnia ocen; f i so - nalezy do R
#Wynik: Całkowita liczba pkt całej klasy

print("Podaj liczbę punktów zdobytych przez klasę: ")
pkt =  int(input())
print("Podaj frekwencje klasy: ")
f = float(input())
print("Podaj średnią ocen klasy")
so = float(input())
if f > 94 and so >= 4:
    pkt = pkt + 20 #można zapisać jako pkt +=20
print("Aktualna liczba punktów wynosi: ", pkt)

