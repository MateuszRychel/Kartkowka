tablica = ['Anna', 'Anna', 'Jan']
licznik = {}
for imie in tablica:
  current = licznik.get(imie, 0)
  licznik[imie] = current + 1
print(licznik)
