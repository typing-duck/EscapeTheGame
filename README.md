# EscapeTheGame

## AMVCC (toptal.com)

GameObject Model zawiera wszystkie skrypty Model.\
Musi zawierać dane dla wszystkich obiektów (np. obecny stan każdego przycisku).

GameObject View zawiera wszystkie skrypty View.\
GameObject Controller zawiera wszystkie skrypty Controller.

Odpowiednie obiekty mają podłączone skrypty Application.

![](https://i.imgur.com/DLKJoaq.png)

![](https://i.imgur.com/YdtUkjS.png)

![](https://i.imgur.com/ZNbDDFW.png)

## MVC (obecne)

Skrypty Model podczepione są pod odpowiednie obiekty.\
Dzięki temu każdy obiekt ma swój skrypt i przechowuje tylko swoje dane.

GameObject Views zawiera wszystkie skrypty View.\
Funkcje wywoływane są pośrednictwem Controller.

GameObject Controllers zawiera wszystkie skrypty Controller.\
Skrypt Controller znajduje wszystkie obiekty z komponentem Model i obsługuje je po kolei.

## Zalety obecnego rozwiązania
1) Nie tworzymy dodatkowego skryptu Application.
2) Nie dodajemy możliwości komunikacji między View i Model.
3) Dzięki temu, że obiekty mają swoje skrypty Model, przechowują tylko swoje dane.\
Gdy istniał jeden skrypt Model musiał zawierać dane wszystkich obiektów.\
Dodanie nowego obiektu byłoby bardziej skomplikowane, ponieważ trzeba by było edytować skrypt i/lub dodawać identyfikatory.\
W obecnej wersji wystarczy przeciągnąć do gry odpowiedni prefab (łatwość dodawania nowych elementów!).
4) Model MVC ciągle istnieje - jest podział na Model, View i Controller. Dodanie wielu skryptów Model zamiast jednego nic nie psuje.
