# Logisk innkapsling (Encapsulation)

Innkapsling handler om at et objekt selv skal passe på sin egen tilstand.
En klasse bør beskytte dataene sine slik at andre deler av programmet ikke kan sette objektet i en ugyldig tilstand.

Eksempel:
```
public class BankAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException();

        Balance += amount;
    }
}
```
Her kan ingen skrive:
`account.Balance = -5000;`

Objektet bestemmer selv hvilke endringer som er lov.

### Hvor bør det brukes?

1. Når det finnes regler som må følges.

Eksempler:
- Bankkonto
- Ordre
- Kunde
- Student
- Lagerbeholdning

2. Hvis objektet har forretningsregler, bør objektet selv håndheve dem.
```
student.RegisterForCourse();
order.Cancel();
account.Withdraw();
```

### Når blir det for mye innkapsling?

Noen ganger lager utviklere metoder for absolutt alt.

```
public string GetName()
{
    return Name;
}
```

I C# er dette ofte unødvendig. Da kan man for eksempel bruke dette: 
```
public string Name { get; private set; }
```


### En tommelfingerregel

Still spørsmålet:
_"Finnes det regler rundt denne verdien?"_

- Hvis svaret er ja → innkapsle.
- Hvis svaret er nei → property er ofte nok.