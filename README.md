# Vurderingssystem
Prototype for APP2000

- [ ] Må legge til private/protected på det meste, da kan vi skrive i rapporten at vi har høy innkapsling/tenker mye på sikkerhet
### ASP.NET
- [x] Legge inn session for ASP delen
- [x] Ha noe som simulerer brukerinnlogging
- [x] Stjernerating
- [x] Vurderingsskjema delen   
- [x]  Brukerside (siden brukeren ser når den er innlogget)
- [x] Lage ASP siden to delt, det vil si at hvis man ikke er innlogget skal man ikke se det en innlogget bruker vil se
- [x] Søkebar (KISS kanskje bare bruke SQL. Er ikke så mye å søke etter. Og heller lage noe sykt for en BA)
- [x] Sette tidsbegrensning på innlogging i webconfig. Sette tidsbegrensning på vurderingsskjema (thread.timer)
- [ ] Lage FAQ for asp.net
- [ ] Legge inn div info på asp.net
- [x] Session redirect hvis du ikke har tilgang til siden
- [x] Lag mine fag
- [x] Lag min vurderinger
- [x] Fagside try catch - divide by zero - Hvis databasen er tom
- [x] Fiks gapet i navbar
- [ ] Sett opp størrelser på siden
- [ ] Varsel for session timeout?
- [X] Velkomstsside kan være mine fag eller mine vurderinger?

***
- [ ] Logo for vms
- [ ] Favicon
*** 
  

- [ ] Feilsøking/validering
- [ ] Kode kommentering
- [ ] Pass på å ha like størrelser, font, likt ui.
- [ ] Korrektur

### WF
- [x] Mine fag endret til sammenlign fag og sammenlign alle fag.
- [ ] Må finne på noen bedre navn på sammenlign fag, evt dropdown liste for de
- [ ] Test ut nye farger på WF
- [ ] Lage tooltip for elementer
- [ ] Lag bedre design på start ny vurdering semester
- [ ] Skrive en bedre tekst til hjelpknapp på ny vurdering semester
- [x] Fikse på lagre/endre skjema readonly/ på det første 5 tekstboksene
- [ ] Lage FAQ for WF
- [ ] Hjelpeside for WF
- [x] Lage en prosedyre som kopierer alt i vurderingshistorikk og legger det inn i en ny tabell (navn kan feks være et input parameter). deretter la prosedyren slette alt som er i vurderingshistorikk. Legg til den funksjonen i admin panel. 
- [x] Legge til knapp for å lagre til xml,pdf (evt andre filformater) på SQL editoren i WF
- [ ] Velkomstsskjerm, legge inn noe i området som nå er lilla og inneholder teksten "aner ikke hva som skal her"
- [x] Legge til flere diagramtyper på se statistikk
- [ ] Finne løsning på avatar bilde (url i db?)
- [x] Passord hash!
  
  ***
- [ ] Feilsøking/validering
- [ ] Kode kommentering
- [ ] Korrektur

### Rapport
- [ ] Gantt for rapport
- [ ] Oppdatere ER diagram (kan avvente til vi er sikre på at db strukturen er ferdig)
- [ ] UML, sekvensdiagrammer for å vise hvordan feks vurdering fungerer. Viktig når vi skal vise fram for håvard/stine  
***
- [ ] Korrektur
  
  
  


### Forslag
- [x] ny Tabell pågående vurdering
- [ ] Legg til mulighet for å kunne ta vurdering for flere fag
- [x] Finn en bruk for threads/ multithreading -- Brukes i loginForm.cs

