# Hva er en instanse?

Dette er ofte det punktet som virkelig får ting til å falle på plass.

**Klassen er oppskriften.**

Objektet er det ferdige produktet.
Eksempel:

Klasse:
```
public class Dog
{
    public string Name { get; set; }
}
```
Instanser:
```
Dog dog1 = new Dog();
Dog dog2 = new Dog();
```
Nå finnes to separate objekter.
```
dog1.Name = "Bella";
dog2.Name = "Max";
```
Hver instans har sin egen hukommelse.
```
Dog (klasse)

        |
        |
   +----+----+
   |         |
 dog1      dog2

 Bella      Max
```

### Hvorfor kan vi ikke instansiere en static klasse?

Fordi en static klasse skal finnes én gang for hele programmet.
```
public static class Calculator
{
}
```
Hvis man kunne skrive:
```
new Calculator();
```
ville hele poenget med static forsvinne.

Static betyr:
```
Dette representerer ikke et objekt. 
Dette er bare funksjonalitet som er tilgjengelig globalt.
```
Derfor:
```
Math.Round()
DateTime.Now
Console.WriteLine()
```
brukes uten at du lager objekter.