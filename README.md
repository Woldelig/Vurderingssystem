# Vurderingssystem
Prototype for APP2000


Linker til ideer:

For å vise hvilke foreleser som er innlogget på WF applikasjon.
Og en mulig løsning på hvordan vi kan vise brukernavnet til en foreleser som er innlogget.
https://stackoverflow.com/questions/14599127/session-for-windows-forms-application-in-c-sharp 

### Ting som må gjøres
- [x] Legge inn session for ASP delen
- [ ] Ha noe som simulerer brukerinnlogging
- [x] Stjernerating
- [x] Vurderingsskjema delen   
- [ ]  Legge til thread på vurderingsskjema som tar tiden på brukern (etter 10 min kan de få en advarsel)
- [ ]  Brukerside (siden brukeren ser når den er innlogget)
- [ ] Lage ASP siden to delt, det vil si at hvis man ikke er innlogget skal man ikke se det en innlogget bruker vil se
- [ ] Søkebar (KISS kanskje bare bruke SQL. Er ikke så mye å søke etter. Og heller lage noe sykt for en BA)
- [ ] Oppdatere ER diagram (kan avvente til vi er sikre på at db strukturen er ferdig)
- [ ] Sette tidsbegrensning på innlogging i webconfig. Sette tidsbegrensning på vurderingsskjema (thread.timer)
- [ ] Lage FAQ for asp.net
- [ ] Lage FAQ for WF
- [ ] Hjelpeside for WF
- [ ] Legge inn div info på asp.net
- [ ] Lage en prosedyre som kopierer alt i vurderingshistorikk og legger det inn i en ny tabell (navn kan feks være et input parameter). deretter la prosedyren slette alt som er i vurderingshistorikk. Legg til den funksjonen i admin panel. 

