Instrukcje
Widzimy kod symulujący proces zakładania nowego konta w portalu społecznościowym 'Start Line'.

Proces zakładania konta wygląda następująco:
walidacja adresu email
sprawdzenie czy email jest wolny (email jest unikalnym identyfikatorem użytkownika)
dodanie użytkownika do bazy danych (lista na potrzeby zadania)
wysłanie maila do użytkownika, z potwierdzeniem założenia konta
Zaczniemy od implementacji brakujących fragmentów kodu (TODO, NotImplementedException), następnie stworzymy metodę umożliwiającą usunięcie użytkownika.

Na usunięcie użytkownika powinno składać się:
sprawdzenie czy użytkownik istnieje (jeśli nie to przerywamy proces wyrzuceniem wyjątku)
usunięcie użytkownika z bazy danych (lista na potrzeby zadania)
wysłanie maila do użytkownika potwierdzającego usunięcie konta
Aby udowodnić działanie nowej metody wypisz w konsoli stan listy 'users' przed wykonaniem metody, następnie wywołaj ją dla istniejącego użytkownika i ponownie wypisz stan listy.

Przykładowo:

Przed usunięciem: 10 Wywołuje operacje usunięcia dla uzytkownika john.doe@gmail.com Po usunięciu: 9