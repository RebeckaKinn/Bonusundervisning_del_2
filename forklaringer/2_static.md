# Static – hva er det egentlig?

Dette er et område mange misforstår.

Tenk på en bilklasse.
```
public class Car
{
    public string Brand { get; set; }
}
```

Hver bil er et eget objekt.
```
Car car1 = new Car();
Car car2 = new Car();
```

Disse har hver sin tilstand.

En static klasse er mer som en verktøykasse.
```
public static class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
```

Brukes slik:
```
MathHelper.Add(2, 3);
```

Ingen objekter opprettes.

### Når bør static brukes?

1. Hjelpefunksjoner
```
Math.Round()
Convert.ToInt32()
```
Dette er klassiske static-metoder.

2. Felles data

Eksempel:
```
public class User
{
    public static int UserCount { get; private set; }

    public User()
    {
        UserCount++;
    }
}
```
Alle objekter deler samme verdi.

3. Konstanter
```
public static class Settings
{
    public const int MaxStudents = 30;
}
```

### Når bør static ikke brukes?

Når noe representerer en virkelig ting med egen tilstand.

_Dårlig:_
```
public static class Student
{
    public static string Name;
}
```
Da kan du bare ha én student.

Hva om du trenger 50 studenter?

Derfor:
```
Student student1 = new Student();
Student student2 = new Student();
```