# Objektorientering – hva er egentlig tanken bak?

Objektorientering prøver å modellere virkeligheten.

### Uten objektorientering
```
string studentName;
int age;
double averageGrade;
```
og mange funksjoner som manipulerer disse.

Etter hvert blir det vanskelig å holde oversikt.

### Med objektorientering

Man samler ting som hører sammen.
```
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Enroll()
    {
    }
}
```
Studenten har både data og oppførsel.

### Hovedideen

_Objekter skal ha ansvar. Ikke bare lagre data._

En vanlig feil er:
```
Student
```
som bare inneholder properties.

Og så ligger all logikken i:
```
StudentService
```
Da mister man mye av poenget med objektorientering.