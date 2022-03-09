# Megoldás
## Adatbázis elkészítése
- Feladatleírás alapján
- Jogosultsági szintek:
   - 1 (admin), 0 (user)
## Projekt létrehozása
- Form átnevezse - > bejelentkezés
## Adatbázis osztály elkészítése
- Referencia (MySQL) hozzáadása
- using MySql.Data.MySqlClient;
- Kapcsolati string -> egyenlõségjelek, pontosvesszõk!!
- Publikus osztály
- MysqlConnection-höz tulajdonság
- Osztály tesztelése -> a form-ban
- Using felvétele a formban
- Form Shown eseményre
- Ha jü -> DB osztályban elrontani pl: user nevet -> teszt -> akkor jó ha nem jó -> visszaállítani a bejelentkezési adatokat
## Bejelentkezési form
- Beállítások
  - StartPosition
  - FormBorderStyle
  - FontSize
  - Text
- Vezérlõk elhelyezése
- Vezérlõk elnevezése
- Tab Order
- Accept button, Cancel button (opcionális)
## User osztály elkészítése (bejelentkezés)
- Az adatbázisban szereplõ mezõknek megfelelõen
- Tulajdonságok, konstruktor
## Bejelentkezés adott felhasználóval
- DB mezõ, User mezõ
- Focus -> Név textbox-ba
### Mégsem gomb esemény
- Kilépés az alkalmazásból
## Bejelentkezés gomb esemény
- Összeszedjük az adatokat (user, pwd)
- Üres mezõk ellenõrzése (try-catch)
- **Ellenõrzés**
#### Adatbázis belépés
- Adatbázis kapcsolat megnyitás (**Lezárás**)
- SQL Megírása -> kódba be
- Lekérdezés elkészítése és futtatása
- Lekérdezés eredményének ellenõrzése
- **hiba lekezelése (rossz user vagy jelszó)**
- **Ellenõrzés**
- User példányosítása
- Fõ form létrehozása -> Bejelentkezés hide, Fõ form megjelenítése
- **Ellenõrzés**
## Fõ form
- Beállítások
  - StartPosition
  - FormBorderStyle
  - FontSize
  - Text -> kódból
- Vezérlõk elhelyezése
- Vezérlõk elnevezése
- Tab Order
- Accept button, Cancel button (opcionális)
- DB mezõ, User mezõ
- Bejelentkezéskor átadás a fõ formnak
- Fõ form text tulajdonságának beállítása
### Kilépés
- Bejelentkezés hide!
- Form.Closing vagy vezérlõgombok eltüntetése
## Elérhetõségek
- Szerepkörnek megfelelõen
## Kutyafajták form
- Form elkészítése, beállítások
- aktID mezõ felvétele és beállítása
- DB mezõ, konstruktor paraméter
- Fõ formon adott gomb eseményének létrehozása
- Feladatnak megfelelõ vezérlõk elhelyezése
  - DataGridView, Button, TextBox-ok, ListBox
- Button-k láthatósága
- DataGridView beállítása
  - Add Column {**id nem látható**}
  - Edit Columns"
    - DataPropertyName
    - Méret megadás
    - AutoSizeModde (általában AllCells, Fill)
    - MultiSelect -> false
    - RowHeadersVisible -> false
## Adatok megjelenítése a DataGridView-ban
- MysqlDataAdapter -> adatok lekérdezése MySQL-bõl (hibakezelés)
- DataTable létrehozása, feltöltées
- adatok lekérdezése MySQL-bõl
- DGB -> DataSource Beállítása
- Elsõ sor legyen a kiválasztott
### DataGridView Click esemény
- TextBox-ba beírni a kutyafajtákat
- **Ellenõrzés**
### Módosítás
- Vezérlõk beállítása (külön megódtus)
- Mégsem -> Vezérlõk visszaállítása
- Mentés -> módosítani az adabzátisban
- Ellenõrzés, hogy van-e ilyen nevû más id-vel -> akkor nem jó!
- Módosítás végrehajtása, Módosítás mezõ -> false (update);
  - Módosítás mezõ -> false (update)
  - Vezérlõk beállítása
  - DataGridView frissítése
- Új fajta felvitele
- Törlés
## Kezelések form
- Form megtervezése
- Form elkészítése, beállítások
- DB mezõ, konstruktor paraméter
- 