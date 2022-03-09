# Megold�s
## Adatb�zis elk�sz�t�se
- Feladatle�r�s alapj�n
- Jogosults�gi szintek:
   - 1 (admin), 0 (user)
## Projekt l�trehoz�sa
- Form �tnevezse - > bejelentkez�s
## Adatb�zis oszt�ly elk�sz�t�se
- Referencia (MySQL) hozz�ad�sa
- using MySql.Data.MySqlClient;
- Kapcsolati string -> egyenl�s�gjelek, pontosvessz�k!!
- Publikus oszt�ly
- MysqlConnection-h�z tulajdons�g
- Oszt�ly tesztel�se -> a form-ban
- Using felv�tele a formban
- Form Shown esem�nyre
- Ha j� -> DB oszt�lyban elrontani pl: user nevet -> teszt -> akkor j� ha nem j� -> vissza�ll�tani a bejelentkez�si adatokat
## Bejelentkez�si form
- Be�ll�t�sok
  - StartPosition
  - FormBorderStyle
  - FontSize
  - Text
- Vez�rl�k elhelyez�se
- Vez�rl�k elnevez�se
- Tab Order
- Accept button, Cancel button (opcion�lis)
## User oszt�ly elk�sz�t�se (bejelentkez�s)
- Az adatb�zisban szerepl� mez�knek megfelel�en
- Tulajdons�gok, konstruktor
## Bejelentkez�s adott felhaszn�l�val
- DB mez�, User mez�
- Focus -> N�v textbox-ba
### M�gsem gomb esem�ny
- Kil�p�s az alkalmaz�sb�l
## Bejelentkez�s gomb esem�ny
- �sszeszedj�k az adatokat (user, pwd)
- �res mez�k ellen�rz�se (try-catch)
- **Ellen�rz�s**
#### Adatb�zis bel�p�s
- Adatb�zis kapcsolat megnyit�s (**Lez�r�s**)
- SQL Meg�r�sa -> k�dba be
- Lek�rdez�s elk�sz�t�se �s futtat�sa
- Lek�rdez�s eredm�ny�nek ellen�rz�se
- **hiba lekezel�se (rossz user vagy jelsz�)**
- **Ellen�rz�s**
- User p�ld�nyos�t�sa
- F� form l�trehoz�sa -> Bejelentkez�s hide, F� form megjelen�t�se
- **Ellen�rz�s**
## F� form
- Be�ll�t�sok
  - StartPosition
  - FormBorderStyle
  - FontSize
  - Text -> k�db�l
- Vez�rl�k elhelyez�se
- Vez�rl�k elnevez�se
- Tab Order
- Accept button, Cancel button (opcion�lis)
- DB mez�, User mez�
- Bejelentkez�skor �tad�s a f� formnak
- F� form text tulajdons�g�nak be�ll�t�sa
### Kil�p�s
- Bejelentkez�s hide!
- Form.Closing vagy vez�rl�gombok elt�ntet�se
## El�rhet�s�gek
- Szerepk�rnek megfelel�en
## Kutyafajt�k form
- Form elk�sz�t�se, be�ll�t�sok
- aktID mez� felv�tele �s be�ll�t�sa
- DB mez�, konstruktor param�ter
- F� formon adott gomb esem�ny�nek l�trehoz�sa
- Feladatnak megfelel� vez�rl�k elhelyez�se
  - DataGridView, Button, TextBox-ok, ListBox
- Button-k l�that�s�ga
- DataGridView be�ll�t�sa
  - Add Column {**id nem l�that�**}
  - Edit Columns"
    - DataPropertyName
    - M�ret megad�s
    - AutoSizeModde (�ltal�ban AllCells, Fill)
    - MultiSelect -> false
    - RowHeadersVisible -> false
## Adatok megjelen�t�se a DataGridView-ban
- MysqlDataAdapter -> adatok lek�rdez�se MySQL-b�l (hibakezel�s)
- DataTable l�trehoz�sa, felt�lt�es
- adatok lek�rdez�se MySQL-b�l
- DGB -> DataSource Be�ll�t�sa
- Els� sor legyen a kiv�lasztott
### DataGridView Click esem�ny
- TextBox-ba be�rni a kutyafajt�kat
- **Ellen�rz�s**
### M�dos�t�s
- Vez�rl�k be�ll�t�sa (k�l�n meg�dtus)
- M�gsem -> Vez�rl�k vissza�ll�t�sa
- Ment�s -> m�dos�tani az adabz�tisban
- Ellen�rz�s, hogy van-e ilyen nev� m�s id-vel -> akkor nem j�!
- M�dos�t�s v�grehajt�sa, M�dos�t�s mez� -> false (update);
  - M�dos�t�s mez� -> false (update)
  - Vez�rl�k be�ll�t�sa
  - DataGridView friss�t�se
- �j fajta felvitele
- T�rl�s
## Kezel�sek form
- Form megtervez�se
- Form elk�sz�t�se, be�ll�t�sok
- DB mez�, konstruktor param�ter
- 