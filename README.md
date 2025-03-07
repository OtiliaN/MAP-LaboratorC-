# MAP-LaboratorC#
Jr. NBA League Romania este o competitie mixta care se adreseaza elevilor din clasele primare IIV. Federatia Romana de Baschet, prin Asociatia Judeteana de Baschet Cluj, a primit dreptul de a folosi
franciza NBA League si de a organiza, in municipiul Cluj-Napoca, cea de-a doua editie a Jr. NBA League
Romania.
Fiecare scoala a fost reprezentata de 15 elevi, apartinand uneia dintre echipele mai sus mentionate. La un
anumit meci, unii elevi au participat ca rezerva, altii au jucat la meci, iar altii nu au participat deloc.
Se vor definit urmatoarele entitati:
- Echipa(id, nume), unde nume este unul dintre cele evidentiate cu galben in lista de mai sus.
- Elev(id, nume, scoala), scoala va fi una dintre cele mentionate mai sus, iar numele elevului il veti
genera voi. Altfel spus, porniti cu cateva scoli si pt fiecare inventati 15 nume de elevi. Apoi mai
adaugati echipe.
- Jucator(echipa) si extinde clasa Elev
- Meci(Echipa, Echipa, Data)
- JucatorActiv:idJucator, idMeci, nrPuncteInscrise, tip:Rezerva, Partipicant
  
A. Cerințe funționale:
Avand datele despre echipe, jucatori, meciuri si jucatori activi se cere:
- Sa se afiseze toti jucatorii unei echipe dată
- Sa se afiseze toti jucatorii activi ai unei echipe de la un anumit meci
- Sa se afiseze toate meciurile dintr-o anumita perioada calendaristica
- Sa se determine si sa se afiseze scorul de la un anumit meci
B. Cerințe non-funționale:
- Arhitectură Stratificată
- Persistenta datelor: la alegere fisiere text sau baze de date (vezi cursul de BD)
- IRepository<ID,E> interfata generica de la temele de Java, definita in c#
- Generics, Delegates, LINQ
