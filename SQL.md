Kezelések

SELECT k.id, ku.kutyanev, kt.jelleg, k.kezdet, k.veg, k.dij FROM kezeles as k INNER JOIN kezelestipus as kt ON kt.id = k.kezelestipusId INNER JOIN kutya as ku ON ku.id = k.kutyaId;

kezelés 2

SELECT k.id, ku.kutyanev, kt.jelleg, f.fajtanev, k.kezdet, k.veg, k.dij, g.nev FROM kezeles as k INNER JOIN kezelestipus as kt ON kt.id = k.kezelestipusId INNER JOIN kutya as ku ON ku.id = k.kutyaId INNER JOIN gazda as g on g.id = ku.gazdaId INNER JOIN fajta as f ON f.id = ku.fajtaId;