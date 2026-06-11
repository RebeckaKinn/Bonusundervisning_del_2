# Hvordan fordele ansvar mellom klasser?

Dette er ofte den viktigste diskusjonen.

Tenk:
_"Hvem vet dette?"_

Eksempel:
```
Order.CalculateTotal()
```
eller
```
OrderService.CalculateTotal(order)
```
Hvem kjenner ordren best?

Ordren selv.

Derfor er ofte dette bedre:
```
order.CalculateTotal();
```

### God tommelfingerregel

Hvis en metode bruker mesteparten av dataene i en klasse:

- Name
- Price
- Quantity
- Discount

så bør metoden sannsynligvis ligge i den klassen.

### Når bør noe være en egen klasse?

Dette er et spørsmål seniorutviklere også stiller seg.

**Tegn 1: Eget ansvar**

Hvis du kan beskrive noe med et substantiv:

- Student
- Course
- Order
- Invoice

er det ofte en klasse.

**Tegn 2: Egen tilstand**

Hvis noe trenger egne data:
```
public class Address
{
    public string Street { get; set; }
    public string ZipCode { get; set; }
}
```
Da er det sannsynligvis en egen klasse.

**Tegn 3: Mange relaterte metoder**

Hvis du får:
```
ValidateAddress()
FormatAddress()
PrintAddress()
```
er det ofte et signal om at Address bør være en klasse.

### Når holder det med en metode?

Når oppgaven bare er en beregning.
```
CalculateVat(price)
```
trenger kanskje ikke en egen klasse.