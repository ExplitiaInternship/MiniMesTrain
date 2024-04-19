# Zadania z podstaw programowania

### Program praktyk 2024

---

Spis Treści

- [HELLO WORLD](#hello-world)
- [DODAWANIE DWÓCH LICZB](#dodawanie-dwóch-liczb)
- [DANE OD UŻYTKOWNIKA](#dane-od-użytkownika)
- [INSTRUKCJE WARUNKOWE](#instrukcje-warunkowe)
- [OPERATORY LOGICZNE](#operatory-logiczne)
- [TABLICZKA MNOŻENIA](#tabliczka-mnożenia)
- [PĘTLA WHILE](#pętla-while)  
- [LICZBA PARZYSTA](#liczba-parzysta)
- [TABLICE](#tablice)
- [MODYFIKACJA TABLICY](#modyfikacja-tablicy)
- [SORTOWANIE TABLICY](#sortowanie-tablicy)
- [DNI TYGODNIA](#dni-tygodnia)
- [PROSTA METODA](#prosta-metoda)
- [METODA Z PARAMETRAMI ZWRACAJĄCA WARTOŚĆ](#metoda-z-parametrami-zwracająca-wartość)
- [KALKULATOR](#kalkulator)
- [KLASY I OBIEKTY](#klasy-i-obiekty)
- [POLA I METODY KLAS](#pola-i-metody-klas)
- [KONSTRUKTORY](#konstruktory)
- [WŁAŚCIWOŚCI](#właściwości)
- [DZIEDZICZENIE](#dziedziczenie)
- [POLIMORFIZM](#polimorfizm)
- [ABSTRAKCJE](#abstrakcje)
- [INTERFEJSY](#interfejsy)
- [WYJĄTKI](#wyjątki)
- [PLIKI](#pliki)
- [KONWERSJA DO JSON](#konwersja-do-json)
- [PSEUDOLOSOWOŚĆ](#pseudolosowość)
- [PRZESTAW LITERY](#przestaw-litery)
- [WALIDACJA HASLA](#walidacja-hasła)
- [PROSTY ORGANIZER](#prosty-organizer)
- [KAMIEŃ PAPIER NOŻYCE](#kamień-papier-nożyce)
- [WISIELEC](#wisielec)
- [ZEGAR Z LICZNIKIEM CZASU](#zegar-z-licznikiem-czasu)
---
​  
​  
### HELLO WORLD  
Napisz program, który wyświetli napis „Hello World” w konsoli.  

Podpowiedź:  
>Wykorzystaj Console.WriteLine    

Przykładowy wynik:  
```
Hello World
```
​  
​  
### DODAWANIE DWÓCH LICZB
Napisz program, który doda dwie liczby i wyświetli wynik w konsoli.  

Podpowiedź:  
>Stwórz dwie zmienne typu int/float (Variables)
Możesz także dodać na końcu programu Console.ReadKey(), aby program oczekiwał na jakikolwiek klawisz nim się zakończy.  

Przykładowy wynik:  
```
Suma 15 i 12 wynosi 27
```
​  
​  
### DANE OD UŻYTKOWNIKA  
Napisz program, który pobiera liczbę od użytkownika, potem dodaj do niej jakąś liczbę i wyświetl.  

Podpowiedź:  
>Wykorzystaj Console.ReadLine
Przekonwertuj string na int używając np. Convert.ToInt32  

Przykładowy wynik:  
```
Podaj liczbę: 15
Zmodyfikowana liczba 15 wynosi 115
```
Zauważ że typ zmiennej uzyskanej od użytkownika zawsze będzie typem string, dlatego jeśli chcemy użyć otrzymaną zmienną w działaniu matematycznym, najpierw musimy ją przekonwertować na typ liczbowy np. int.
​  
​  
### INSTRUKCJE WARUNKOWE  
Napisz program, który pobierze dwie wartości od użytkownika,  porówna je i wyświetli dwie różne wiadomości w zależności od wyniku porównania.  

Podpowiedź:  
>Wykorzystaj instrukcję warunkową (If else)  
Np. Jeśli liczba1 < liczba2 to w konsoli ma się wyświetlić: Druga liczba jest większa  

Przykładowy wynik:  
```
Podaj liczbę: 15
Podaj liczbę: 55
Druga liczba jest większa.
```
​  
​  
### OPERATORY LOGICZNE  
Napisz program, który pobierze dwie wartości od użytkownika, a następnie wyświetli odpowiednie komunikaty dla różnych przypadków np.: Jeśli liczba1 i liczba2 są większe od 100 to wyświetl komunikat, że obie liczby są większe od 100, natomiast jeśli jedna z nich jest mniejsza od 100 to wyświetl komunikat, że tylko jedna liczba jest większa od 100, jeśli obie liczby są mniejsze od 100 to wyświetl informację, że obie liczby są mniejsze od 100.  

Podpowiedź:  
>Wykorzystaj if , if else, else i operatory logiczne && i || (Logical Operators)

Przykładowy wynik:  
```
Podaj pierwszą liczbę:
125
Podaj drugą liczbę:
87
Tylko jedna liczba, a dokładnie liczba: 125 jest większa od 100
```
​  
​  
### TABLICZKA MNOŻENIA  
Napisz program, który wyświetla tabliczkę mnożenia(1-10) dla dowolnej liczby wprowadzonej przez użytkownika.

Podpowiedź:
>Wykorzystaj pętlę do przejścia po liczbach od 1-10. (Loops)

Przykładowy wynik:
```
Podaj liczbę: 5
Tabliczka mnożenia dla liczby 5:
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
5 * 4 = 20
5 * 5 = 25
5 * 6 = 30
5 * 7 = 35
5 * 8 = 40
5 * 9 = 45
5 * 10 = 50
```
​  
​  
### PĘTLA WHILE  
Napisz program, który pobiera imię od użytkownika i zapisuje w osobnej zmiennej. Następnie stwórz kolejną zmienną wynikową do przedstawienia osoby i dodaj do niej wartość użytkownika. Później wyświetl wynikowy napis 10 razy w konsoli używając pętli while.

Podpowiedź:
>Wykorzystaj pętlę do przejścia po liczbach od 1-10. (Loops)

Przykładowy wynik:
```
Podaj swoje imię:
Jan
1 Witaj, Jan!
2 Witaj, Jan!
3 Witaj, Jan!
4 Witaj, Jan!
5 Witaj, Jan!
6 Witaj, Jan!
7 Witaj, Jan!
8 Witaj, Jan!
9 Witaj, Jan!
10 Witaj, Jan!
```
​  
​  
### LICZBA PARZYSTA  
Napisz program, który będzie przyjmował liczbę od użytkownika i informował czy ta liczba jest parzysta czy nieparzysta. 

Podpowiedź:
>Wykorzystaj modulo %

Przykładowy wynik:
```
Wpisz liczbę:
54
Ta liczba jest parzysta.
```
​  
​  
### TABLICE  
Napisz program, który będzie zawierał tablicę z dwoma wartościami do której zapisują się wartości wpisywane przez użytkownika. Następnie wyświetl ilość elementów w tablicy.

Podpowiedź:
>Wykorzystaj tablicę do przechowania liczb, a także własność .Length. (Array)

Przykładowy wynik:
```
Wpisz liczbę1:
15
Wpisz liczbę2:
52
Długość tablicy: 2. Elementy tablicy 15 52
```
​  
​  
### MODYFIKACJA TABLICY  
Napisz program, w którym zdefiniujesz tablicę i przypiszesz do niej wartości od 1 do 10. Później do każdego parzystego indexu dodaj liczbę 2 i wyświetl w konsoli całą tablicę.

Podpowiedź:
>Wykorzystaj pętlę do przypisania wartości do tablicy. Możesz skorzystać z modulo, aby sprawdzić numer indeksu. Do wyświetlenia wyników możesz użyć pętli foreach.

Przykładowy wynik:
```
Utworzona tablica:
1 2 3 4 5 6 7 8 9 10
Zmodyfikowana tablica:
3 2 5 4 7 6 9 8 11 10
```
​  
​  
### SORTOWANIE TABLICY  
Napisz program, który sortuje tablicę liczb w porządku rosnącym.

Podpowiedź:
>Wykorzystaj tablicę do przechowania liczb do sortowania, metodę Array.Sort() do posortowania i pętlę foreach do wyświetlenia zawartości tablicy. (Array, Array.Sort(), foreach)

Przykładowy wynik:
```
Tablica do posortowania:
5 9 1 2 4 8 6 3 7
Posortowana tablica:
1 2 3 4 5 6 7 8 9
```
​  
​  
### DNI TYGODNIA  
Napisz program, który po naciśnięciu odpowiedniego przycisku przez użytkownika, wyświetli odpowiednią nazwę dnia tygodnia.

Podpowiedź:
>Wykorzystaj switch, aby przedstawić różne przypadki (Switch)

Przykładowy wynik:
```
Wybierz numer dnia tygodnia (1-7):
5
Piątek
```
​  
​  
### PROSTA METODA  
Napisz program, który będzie posiadał metodę główną Main, ale także osobną metodę WyświetlTekst(), która po prostu wyświetli dowolny tekst w konsoli.

Podpowiedź:
>Wykorzystaj tworzenie i wywołanie metody. (Methods)

Przykładowy wynik:
```
Metoda wyświetlająca tekst.
```
​  
​  
### METODA Z PARAMETRAMI ZWRACAJĄCA WARTOŚĆ  
Napisz program, który pobierze od użytkownika dwie liczby, przekaże je do metody DodajLiczby() jako parametry i zwróci wynik ich dodawania w konsoli.

Podpowiedź:
>Wykorzystaj przekazywanie parametrów do metody i zwracanie wartości. (Method parameters)

Przykładowy wynik:
```
Podaj pierwszą liczbę: 15
Podaj drugą liczbę: 7
Wynik dodawania 15 i 7 to: 22
```
​  
​  
### KALKULATOR  
Stwórz prosty program kalkulatora, który będzie dodawał, odejmował, mnożył, dzielił, pierwiastkował i potęgował dwie wpisane przez użytkownika liczby. Program powinien podawać komunikaty co w danej chwili ma wpisać użytkownik: liczbę/znak działania. Program powinien przyjmować również liczby dziesiętne. Użytkownik powinien mieć możliwość wyboru działania np. poprzez wpisanie odpowiedniego znaku.

Podpowiedź:
>Wykorzystaj poprzednio poznane informacje, program możesz stworzyć dowolnie, ma tylko zawierać funkcjonalności wskazane wyżej.

Przykładowy wynik:
```
Witaj w prostym kalkulatorze!
Podaj pierwszą liczbę:
15
Wybierz działanie (+, -, *, /, sqrt, ^):
^
Podaj potęgę:
2
Wynik: 225
```
​  
​  
### KLASY I OBIEKTY  
Poza główną klasą Program, stwórz klasę Car z publiczną zmienną nazwa, następnie utwórz obiekt nazywając go swoim ulubionym samochodem np. Chevrolet Chevelle

Podpowiedź:
>Wykorzystaj tworzenie klas i obiektów (Class, Object)

Przykładowy wynik:
```
Mój obiekt: Car o nazwie: Chevrolet Chevelle
```
​  
​  
### POLA I METODY KLAS  
Rozbuduj klasę Car o trzy pola np. nazwa, kolor, moc silnika i metody Drive() i DisplayInfo(). Przypisz domyślne wartości polom. Metoda Drive może zawierać tylko wyświetlenie napisu „Driving …”. W metodzie DisplayInfo wyświetlaj pozostałe informacje. Następnie stwórz dwa osobne obiekty, przypisz im potrzebne informacje i wyświetl metody obu obiektów w konsoli.

Podpowiedź:
>Wykorzystaj tworzenie pól i metod wewnątrz klasy (Class members)
Wykorzystaj modyfikowanie pól obiektu.

Przykładowy wynik:
```
Samochód 1:
Driving ...
Nazwa: Chevrolet Chevelle
Kolor: Czerwony
Moc silnika: 350 KM

Samochód 2:
Driving ...
Nazwa: Ford Mustang
Kolor: Niebieski
Moc silnika: 450 KM
```
​  
​  
### KONSTRUKTORY  
Rozbuduj klasę Car o konstruktor z parametrami, który będzie inicjalizował obiekty i ustawiał im wartości pól. Stwórz dwa obiekty Car i przypisz im różne wartości, a następnie wyświetl te obiekty.
Podpowiedź:
> Wykorzystaj tworzenie konstruktora. (Constructor)
---
​  
​  
### WŁAŚCIWOŚCI  
Napisz program, który będzie zawierał klasę Person, w której będzie prywatne pole name i właściwość Name. Właściwość Name powinna zawierać metody get, która będzie uzyskiwała dostęp do prywatnego pola i  set, która je zaaktualizuje. Na koniec stwórz nowy obiekt, w konsoli wpisz imię i wypisz informacje o osobie w konsoli.

Podpowiedź:
>Wykorzystaj tworzenie właściwości. (Properties)

Przykładowy wynik:
```
Wpisz imię:
Adam
Imię osoby: Adam z obiektu: Person
```
​  
​  
### DZIEDZICZENIE  
Napisz program posiadający trzy klasy: jedną Vehicle jako rodzic, drugą Car jako dziecko i trzecią  Motorcycle jako dziecko. Klasa Vehicle powinna zawierać podstawowe informacje o pojazdach. Klasa Car powinna zawierać informacje specyficzne dla samochodu. Klasa Motorcycle powinna zawierać informacje specyficzne dla motocyklu. Klasy Car i Motorcycle powinny dziedziczyć po klasie Vehicle. Później stwórz obiekt Car i obiekt Motorcycle i wyświetl informacje o nich w konsoli.

Podpowiedź:
>Wykorzystaj dziedziczenie klas (Inheritance)

Przykładowy wynik:
```
Informacje o samochodzie: Car, który dziedziczy z klasy Vehicle
Marka: Toyota
Model: Corolla
Rok produkcji: 2020
Ilość drzwi: 5

Informacje o motocyklu: Motorcycle, który dziedziczy z klasy Vehicle
Marka: Harley-Davidson
Model: Street 750
Rok produkcji: 2018
Typ: Chopper
```
​  
​  
### POLIMORFIZM  
Zmodyfikuj poprzedni program, dodając do klasy Vehicle metodę Honk(), która będzie wyświetlała dowolnie wybrany napis reprezentujący dźwięk klaksonu. Dodaj słowo kluczowe virtual do tej metody. W klasach Car i Motorcycle dodaj nadpisanie tej metody, gdzie wyświetli się inny napis. Na koniec stwórz osobne obiekty dla wszystkich klas i wywołaj ich metody Honk(), aby uzyskać trzy osobne różne napisy.

Podpowiedź:
>Wykorzystaj słowa kluczowe virtual i override (Polimorphism, Keywords)

Przykładowy wynik:
```
Honk! honk!
Tut! Tut!
Beep! Beep!
```
​  
​  
### ABSTRAKCJE  
Zmodyfikuj poprzedni program zastępując modyfikator dostępu public słowem kluczowym abstract. Dodaj także abstract do metody Honk(). Stwórz kolejną metodę Stop(), która wyświetla dowolny napis w konsoli. Na koniec stwórz nowy obiekt i wywołaj wszystkie metody obiektu.

Podpowiedź:
>Wykorzystaj słowo kluczowe abstract (Abstraction)
Zauważ, że teraz niemożliwe jest stworzenie obiektu klasy Vehicle, ponieważ jest to klasa abstrakcyjna. Aby uzyskać dostęp do takiej klasy należy ją dziedziczyć z innej.

Przykładowy wynik:
```
Stopping the vehicle!
Stopping the vehicle!
```
​  
​  
### INTERFEJSY  
Stwórz dwa interfejsy: IVehicle z metodą Honk() i ILand z metodą MovingOnLand(), następnie zaimplementuj je do jakiejkolwiek klasy i dodaj zawartość metod interfejsu (mogą być tylko teksty w konsoli). Na koniec stwórz nowy obiekt i wywołaj jego metody.

Podpowiedź:
>Wykorzystaj tworzenie i implementacje interfejsów (Interfaces)
Zauważ, że możliwe jest „dziedziczenie”(implementacja) wielu interfejsów, a dziedziczyć można tylko po jednej klasie.

Przykładowy wynik:
```
Honk! Honk!
Moving on the land!
```
​  
​  
### WYJĄTKI  
Stwórz program, który będzie zawierał blok try catch do wyłapywania błędów. W try stwórz tablicę z trzema liczbami i wyświetl piąty element tablicy. W catch program powinien wyświetlać informację o błędzie. Następnie uruchom program, aby zobaczyć powstałą informację błędu.

Podpowiedź:
>Wykorzystaj try..catch

Przykładowy wynik:
```
Wystąpił błąd: Index was outside the bounds of the array.
```
​  
​  
### PLIKI  
Stwórz program, który będzie zawierał zmienną string z dowolnym tekstem, a następnie stwórz nowy plik tekstowy i przypisz jego zawartości wartość zdefiniowanej wcześniej zmiennej. W kolejnym kroku otwórz stworzony plik tekstowy i zmień jego zawartość. Następnie odczytaj zawartość pliku tekstowego i wyświetl ją w konsoli.

Podpowiedź:
>Wykorzystaj bibliotekę System.IO i metody File.WriteAllText i File.ReadAllText (Files)

Przykładowy wynik:
```
Wpisz tekst do zapisania w pliku:
Przykładowy tekst do zapisania w pliku tekstowym

Zdefiniuj ścieżkę pliku np. File.txt:
File.txt
Zapisano tekst Przykładowy tekst do zapisania w pliku tekstowym w pliku File.txt
Zawartość pliku File.txt wynosi:
Przykładowy tekst do zapisania w pliku tekstowym
```
​  
​  
### KONWERSJA DO JSON  
Stwórz program, gdzie stworzysz klasę i obiekt. Następnie przekonwertuj obiekt klasy do formatu JSON. Wyświetl przekonwertowane dane w konsoli.  

Podpowiedź:
>Wykorzystaj bibliotekę System.Text.Json i JsonSerializer.Serialize()

Przykładowy wynik:
```
{"Imie":"Jan","Wiek":30}
```

​  
### PSEUDOLOSOWOŚĆ  
Stwórz prostą grę, w której komputer wybiera losową liczbę od 1-100, a użytkownik próbuje ją zgadnąć. Informuj użytkownika, czy Jego podana liczba jest większa lub mniejsza od liczby komputera. Po odgadnięciu liczby podaj liczbę prób, po których udało się ją odgadnąć.

Podpowiedź:
>Stwórz obiekt klasy Random i wywowołaj metodę Next(). Użyj pętli while, aby program działał dopóki liczba nie zostanie odgadnięta.

Przykładowy wynik:
```
Zgadnij liczbę od 1 do 100.
Podaj swoją liczbę: 53
Za mało!
Podaj swoją liczbę: 88
Brawo! Zgadłeś liczbę po 2 próbach.
```

​  
### PRZESTAW LITERY 
Napisz program, który zamieni wielkie litery na małe i odwrotnie w wpisanym przez użytkownika zdaniu. Ten program powinien pobierać od użytkownika zdanie, a następnie zamienia wszystkie wielkie litery na małe i odwrotnie.

Podpowiedź:
>Wykorzystaj funkcje char.IsUpper, char.ToLower, char.IsLower i char.ToUpper.

Przykładowy wynik:
```
Wprowadź zdanie: Przykładowe Zdanie
Przestawione zdanie: pRZYKŁADOWE zDANIE
```

​  
### WALIDACJA HASLA 
Napisz program, który sprawdzi, czy wpisane przez użytkownika hasło spełnia określone kryteria (np. długość, obecność dużych liter, cyfr i symboli). Ten program sprawdza, czy wprowadzone przez użytkownika hasło spełnia następujące kryteria:
- Hasło musi mieć co najmniej 8 znaków.
- Hasło musi zawierać co najmniej jedną dużą literę.
- Hasło musi zawierać co najmniej jedną cyfrę.
- Hasło musi zawierać co najmniej jeden symbol.  
Jeśli hasło nie spełnia któregoś z tych kryteriów, program informuje użytkownika, które kryterium nie zostało spełnione.

Podpowiedź:
> Stwórz warunki dla każdego kryterium. Możesz wykorzystać funkcje: Any(char.IsUpper), Any(char.IsDigit), Any(char.IsSymbol), Any(char.IsPunctuation)

Przykładowy wynik:
```
Wprowadź hasło: Janek123/
Hasło jest poprawne.
```

​  
### PROSTY ORGANIZER 
Napisz program, który umożliwi użytkownikowi dodawanie, usuwanie i wyświetlanie notatek. Użytkownik może wybrać jedną z czterech opcji: dodaj notatkę, usuń notatkę, wyświetl notatki lub wyjdź. Notatki są przechowywane na liście, a numer notatki jest jej indeksem na liście plus jeden.

Podpowiedź:
> Stwórz obiekt klasy List zawierający typy string, który będzie przechowywywał notatki. Użyj switcha do stworzenia opcji interfejsu. Dla każdej opcji utwórz osobną metodę np. DodajNotatke()

Przykładowy wynik:
```
1. Dodaj notatkę
2. Usuń notatkę
3. Wyświetl notatki
4. Wyjdź
Wybierz opcję: 1
Wpisz notatkę: Przykładowa notatka

1. Dodaj notatkę
2. Usuń notatkę
3. Wyświetl notatki
4. Wyjdź
Wybierz opcję: 3

Twoje notatki:
1. Przykładowa notatka

1. Dodaj notatkę
2. Usuń notatkę
3. Wyświetl notatki
4. Wyjdź
Wybierz opcję: 2
Podaj numer notatki do usunięcia: 1

1. Dodaj notatkę
2. Usuń notatkę
3. Wyświetl notatki
4. Wyjdź
Wybierz opcję:
```

​  
### KAMIEŃ, PAPIER, NOŻYCE
Napisz prostą grę w Kamień, Papier, Nożyce, w której użytkownik będzie grać przeciwko komputerowi.
Gra ma toczyć się do momentu, aż jeden z graczy zdobędzie 3 punkty. Po każdej rundzie wyświetlany jest aktualny wynik. Na końcu gry wyświetlany jest komunikat o wygranej lub przegranej.

Podpowiedź:
> Wykorzystaj pseudolosowość do stworzenia wyborów komputera. Pętlą while sprawdzaj aktualny wynik. Wyrażeniem warunkowym sprawdź zwycięzcę.

Przykładowy wynik:
```
Wybierz Kamień, Papier, czy Nożyce:
Papier

Komputer wybrał Kamień
Użytkownik wybrał Papier

Wygrałeś!
Wynik: Użytkownik - 1, Komputer - 0

Wybierz Kamień, Papier, czy Nożyce:
Kamień

Komputer wybrał Kamień
Użytkownik wybrał Kamień

Remis!
Wynik: Użytkownik - 1, Komputer - 0

Wybierz Kamień, Papier, czy Nożyce:
Nożyce

Komputer wybrał Papier
Użytkownik wybrał Nożyce

Wygrałeś!
Wynik: Użytkownik - 2, Komputer - 0

Wybierz Kamień, Papier, czy Nożyce:
Papier

Komputer wybrał Kamień
Użytkownik wybrał Papier

Wygrałeś!
Wynik: Użytkownik - 3, Komputer - 0

Gratulacje! Wygrałeś mecz!
```
​   
### WISIELEC
Stwórz grę w Wisielca, w której gracz zgaduje ukryte słowo.
W tej grze, gracz ma 6 prób na zgadnięcie słowa. Słowo do zgadnięcia jest wybierane losowo z listy słów. Gracz podaje litery, które mogą występować w słowie. Jeżeli litera występuje w słowie, jest ona odkrywana. Jeżeli nie, liczba pozostałych prób jest zmniejszana. Gra kończy się, gdy gracz zgadnie słowo lub skończą mu się próby. Możesz użyć poniższej listy słów jako podstawy. Dodaj sprawdzanie czy gracz wpisuje literę, czy też może liczbę albo znak specjalny. Jeśli liczba lub znak specjalny to wypisz błąd.

Podpowiedź:
> Wykorzystaj pseudolosowość do wybierania słowa z listy.
Rozłóż słowo na tablicę znaków. Potem pętlą while sprawdzaj czy osiągnięto liczbę prób/zgadnięto.

Przykładowy wynik:
```
Słowo do zgadnięcia: _________
Pozostało prób: 10
Podaj literę: K
Słowo do zgadnięcia: k________
Pozostało prób: 10
Podaj literę: 5
Błąd! Wprowadź literę, nie liczbę ani znak specjalny.
Słowo do zgadnięcia: k________
Pozostało prób: 10
Podaj literę: a
Słowo do zgadnięcia: k____a___
Pozostało prób: 10
Podaj literę: q
Słowo do zgadnięcia: k____a___
Pozostało prób: 9
Podaj literę: /
Błąd! Wprowadź literę, nie liczbę ani znak specjalny.
Słowo do zgadnięcia: k____a___
Pozostało prób: 9
Podaj literę: o
Słowo do zgadnięcia: ko_o_a___
Pozostało prób: 9
Podaj literę: d
Słowo do zgadnięcia: kodo_a___
Pozostało prób: 9
Podaj literę: w
Słowo do zgadnięcia: kodowa___
Pozostało prób: 9
Podaj literę: n
Słowo do zgadnięcia: kodowan__
Pozostało prób: 9
Podaj literę: i
Słowo do zgadnięcia: kodowani_
Pozostało prób: 9
Podaj literę: e
Gratulacje! Zgadłeś słowo: kodowanie
```
​   
### ZEGAR Z LICZNIKIEM CZASU
Napisz aplikację zegara, która odlicza czas od ustalonego punktu początkowego i wyświetla go w konsoli.

Podpowiedź:
> Ustaw początkową datę na obecną używając DateTime.Now; Wykorzystaj System.Threading, i metodę Thread.Sleep(1000) do odliczania czasu.

Przykładowy wynik:
```
Podaj liczbę sekund do odliczenia:
5
Czas od punktu początkowego: 00:00:01.0051020
Czas od punktu początkowego: 00:00:02.0215789
Czas od punktu początkowego: 00:00:03.0312700
Czas od punktu początkowego: 00:00:04.0437343
Czas od punktu początkowego: 00:00:05.0540346
Koniec odliczania!
```
​   
---
​   
[POWRÓT](#program-praktyk-2024)

### Linki pomocy:  
[W3schools](https://www.w3schools.com/cs/index.php)  
[Microsoft](https://learn.microsoft.com/en-us/dotnet/csharp/)  
[ChatGPT](https://chat.openai.com/)
